Imports System.IO

Public Class AddPhoto

    Dim imagePath As String = ""
    Dim filePathToEdit As String
    Dim recordToEdit() As String

    Public Sub New(Optional record() As String = Nothing, Optional filePath As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        recordToEdit = record
        filePathToEdit = filePath

    End Sub

    Private Sub AddPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If recordToEdit IsNot Nothing Then

            PhotoTitle.Text = recordToEdit(0)
            PhotoDescription.Text = recordToEdit(1)

            imagePath = recordToEdit(2)
            ImagePathLabel.Text = imagePath
            ImageViewer.Image = Image.FromFile(imagePath)

            PhotoBody.Text = recordToEdit(3)

        End If

    End Sub

    Private Sub AddPhoto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        PhotoTabControl.Width = Me.Width - 140
        PhotoTabControl.Left = (Me.Width - PhotoTabControl.Width) / 2 - 10
        PhotoTabControl.Top = (Me.Height - PhotoTabControl.Height) / 2 - 40

        PhotoTitle.Width = PhotoTabControl.Width - 138
        PhotoDescription.Width = PhotoTabControl.Width - 138
        PhotoBody.Width = PhotoTabControl.Width - 138

    End Sub

    Private Sub PhotoSaveButton_Click(sender As Object, e As EventArgs) Handles PhotoSaveButton.Click

        Dim title = PhotoTitle.Text.Trim
        Dim description = PhotoDescription.Text.Trim
        Dim body = PhotoBody.Text.Trim

        Dim filePath As String


        If title <> String.Empty AndAlso description <> String.Empty AndAlso body <> String.Empty AndAlso imagePath <> String.Empty Then

            Try

                Dim photo = New Photo(title, description, body, imagePath)

                If filePathToEdit IsNot Nothing Then

                    filePath = filePathToEdit
                    photo.CreationDate = recordToEdit(4)

                Else

                    filePath = FileworxClient.photosDirectory & Guid.NewGuid().ToString() & ".txt"

                End If

                If Not Directory.Exists(FileworxClient.photosDirectory) Then

                    Directory.CreateDirectory(FileworxClient.photosDirectory)

                End If

                FileworxClient.fileStreamWriter = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)
                FileworxClient.streamWriter = New StreamWriter(FileworxClient.fileStreamWriter)

                FileworxClient.streamWriter.WriteLine(photo.toFileReprisintation)
                FileworxClient.streamWriter.Close()

                Home._Refresh()
                Home.Home_Load(sender, e)
                Home.Home_Resize(sender, e)

                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("All fields and image are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As DialogResult

        'choosing the image
        Using imagePicker As New OpenFileDialog()
            imagePicker.Filter = "Choose Image(*.jpg;*.png;*.jfif;)|*jpg;*.png;*.jfif;"
            result = imagePicker.ShowDialog()
            imagePath = imagePicker.FileName
        End Using

        'display the image and it's path
        If result <> Windows.Forms.DialogResult.Cancel Then
            ImagePathLabel.Text = imagePath
            ImageViewer.Image = Image.FromFile(imagePath)
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class