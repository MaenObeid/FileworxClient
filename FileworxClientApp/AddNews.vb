Imports System.IO

Public Class AddNews

    Dim category As FileworxClient.Category
    Dim filePathToEdit As String
    Dim recordToEdit() As String

    Public Sub New(Optional record() As String = Nothing, Optional filePath As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        recordToEdit = record
        filePathToEdit = filePath

    End Sub

    Private Sub AddNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NewsTitle.Select()

        For Each i In [Enum].GetValues(GetType(FileworxClient.Category))
            NewsCategory.Items.Add(i)
        Next

        If recordToEdit IsNot Nothing Then

            NewsTitle.Text = recordToEdit(0)
            NewsDesc.Text = recordToEdit(1)
            NewsCategory.SelectedIndex = recordToEdit(2)
            NewsBody.Text = recordToEdit(3)

        Else

            NewsCategory.SelectedIndex = FileworxClient.Category.General

        End If


    End Sub

    Private Sub PhotoSaveButton_Click(sender As Object, e As EventArgs) Handles NewsSaveButton.Click

        Dim title = NewsTitle.Text.Trim
        Dim description = NewsDesc.Text.Trim
        Dim body = NewsBody.Text.Trim
        Dim filePath As String

        If title <> String.Empty AndAlso description <> String.Empty AndAlso body <> String.Empty Then

            Try

                Dim news = New News(title, description, category, body)

                If filePathToEdit IsNot Nothing Then

                    filePath = filePathToEdit
                    news.CreationDate = recordToEdit(4)

                Else

                    filePath = FileworxClient.newsDirectory & Guid.NewGuid().ToString() & ".txt"

                End If

                If Directory.Exists(FileworxClient.newsDirectory) Then

                    Directory.CreateDirectory(FileworxClient.newsDirectory)

                End If

                FileworxClient.fileStreamWriter = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)
                FileworxClient.streamWriter = New StreamWriter(FileworxClient.fileStreamWriter)

                FileworxClient.streamWriter.WriteLine(news.toFileReprisintation)
                FileworxClient.streamWriter.Close()

                Home._Refresh()
                Home.Home_Load(sender, e)
                Home.Home_Resize(sender, e)

                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub NewsCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NewsCategory.SelectedIndexChanged

        category = NewsCategory.SelectedIndex

    End Sub

    Private Sub AddNews_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        AddNewsPanel.Width = Me.Width - 140
        AddNewsPanel.Left = (Me.Width - AddNewsPanel.Width) / 2 - 10
        AddNewsPanel.Top = (Me.Height - AddNewsPanel.Height) / 2 - 40

        NewsTitle.Width = AddNewsPanel.Width - 140
        NewsDesc.Width = AddNewsPanel.Width - 140
        NewsCategory.Width = AddNewsPanel.Width - 140
        NewsBody.Width = AddNewsPanel.Width - 140
        Cancel.Location = New Point(NewsBody.Location.X + NewsBody.Width - Cancel.Width, Cancel.Location.Y)
        NewsSaveButton.Location = New Point(Cancel.Location.X - Cancel.Width - 6, NewsSaveButton.Location.Y)

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class