Imports System.IO

Public Class frmAddPhoto

    Dim imagePath As String = ""
    Private Row As Photo


    Public Sub New(Optional row As Photo = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Row = row

    End Sub


    Private Sub AddPhoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Row Is Nothing Then

            Return

        End If

        With Row

            txtPhotoTitle.Text = .Title
            txtPhotoDescription.Text = .Description
            txtPhotoBody.Text = .Body

            imagePath = .Image
            lblImagePathLabel.Text = imagePath
            picImageViewer.Image = Image.FromFile(imagePath)

        End With

    End Sub


    Private Sub PhotoSaveButton_Click(sender As Object, e As EventArgs) Handles PhotoSaveButton.Click

        Dim title = txtPhotoTitle.Text.Trim
        Dim description = txtPhotoDescription.Text.Trim
        Dim body = txtPhotoBody.Text.Trim

        If String.IsNullOrWhiteSpace(title) OrElse String.IsNullOrWhiteSpace(description) OrElse String.IsNullOrWhiteSpace(body) OrElse String.IsNullOrWhiteSpace(imagePath) Then

            MessageBox.Show("All fields and image are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        Try

            If Row Is Nothing Then

                Row = New Photo(title, description, body, imagePath)

            Else
                With Row

                    .Title = title
                    .Description = description
                    .Body = body
                    .Image = imagePath

                End With
            End If

            If Not Directory.Exists(ApplicationSettings.photosDirectory) Then

                Directory.CreateDirectory(ApplicationSettings.photosDirectory)

            End If

            Dim fileStreamWriter = New FileStream(Row.FilePath, FileMode.OpenOrCreate, FileAccess.Write)

            Using streamWriter As New StreamWriter(fileStreamWriter)

                streamWriter.WriteLine(Row.toFileReprisintation())

                If Not ApplicationSettings.postsMenu.Contains(Row) Then

                    ApplicationSettings.postsMenu.Add(Row)

                End If

            End Using

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim result As DialogResult

        'choosing the image
        Using imagePicker As New OpenFileDialog()
            imagePicker.Filter = "Choose Image(*.jpg;*.png;*.jfif;)|*jpg;*.png;*.jfif;"
            result = imagePicker.ShowDialog()
            imagePath = imagePicker.FileName
        End Using


        If result = DialogResult.Cancel Then

            Return

        End If

        'display the image and it's path
        lblImagePathLabel.Text = imagePath
        picImageViewer.Image = Image.FromFile(imagePath)

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class