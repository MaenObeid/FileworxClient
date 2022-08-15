Imports System.IO

Public Class frmAddNews

    Dim category As Category
    Private Row As News


    Public Sub New(Optional row As News = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Row = row

    End Sub


    Private Sub AddNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNewsTitle.Select()

        For Each i In [Enum].GetValues(GetType(Category))
            cboNewsCategory.Items.Add(i)
        Next

        If Row Is Nothing Then

            cboNewsCategory.SelectedIndex = Category.General
            Return

        End If

        With Row

            txtNewsTitle.Text = .Title
            txtNewsDesc.Text = .Description
            cboNewsCategory.SelectedIndex = .Category
            rtxtNewsBody.Text = .Body

        End With

    End Sub


    Private Sub PhotoSaveButton_Click(sender As Object, e As EventArgs) Handles btnNewsSaveButton.Click

        Dim title = txtNewsTitle.Text.Trim
        Dim description = txtNewsDesc.Text.Trim
        Dim body = rtxtNewsBody.Text.Trim

        If String.IsNullOrWhiteSpace(title) OrElse String.IsNullOrWhiteSpace(description) OrElse String.IsNullOrWhiteSpace(body) Then

            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        Try

            If Row Is Nothing Then

                Row = New News(title, description, category, body)

            Else

                With Row

                    .Title = title
                    .Description = description
                    .Category = cboNewsCategory.SelectedIndex
                    .Body = body

                End With

            End If

            If Not Directory.Exists(ApplicationSettings.newsDirectory) Then

                Directory.CreateDirectory(ApplicationSettings.newsDirectory)

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
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub NewsCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewsCategory.SelectedIndexChanged

        category = cboNewsCategory.SelectedIndex

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class