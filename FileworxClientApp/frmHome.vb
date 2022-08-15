Imports System.IO

Public Class frmHome

    Dim post As Post
    Dim selectedIndex As Integer


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        scPreviewPanel.Height = My.Computer.Screen.Bounds.Height
        scPreviewPanel.SplitterDistance = My.Computer.Screen.Bounds.Height / 3

        Dim files() As String = {}

        Try

            If Directory.Exists(ApplicationSettings.newsDirectory) Then

                files = Directory.GetFiles(ApplicationSettings.newsDirectory)

            End If

            For Each file As String In files

                Using fileStreamReader As New FileStream(file, FileMode.Open, FileAccess.Read)

                    Using streamReader As New StreamReader(fileStreamReader)

                        Dim record As String() = streamReader.ReadLine().Split({ApplicationSettings.separator}, System.StringSplitOptions.RemoveEmptyEntries)

                        ApplicationSettings.postsMenu.Add(New News(record, file))

                    End Using

                End Using

            Next

            files = {}

            If Directory.Exists(ApplicationSettings.photosDirectory) Then

                files = Directory.GetFiles(ApplicationSettings.photosDirectory)

            End If

            For Each file As String In files

                Using fileStreamReader As New FileStream(file, FileMode.Open, FileAccess.Read)

                    Using StreamReader As New StreamReader(fileStreamReader)

                        Dim record As String() = StreamReader.ReadLine().Split({ApplicationSettings.separator}, System.StringSplitOptions.RemoveEmptyEntries)

                        ApplicationSettings.postsMenu.Add(New Photo(record, file.ToString))

                    End Using

                End Using

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        LoadDataSource()

    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPostsData.SelectionChanged

        Try

            selectedIndex = dgvPostsData.SelectedRows.Item(0).Index

        Catch ex As Exception

            selectedIndex = 0

        End Try

        post = ApplicationSettings.postsMenu(selectedIndex)

        If post.GetType = GetType(News) Then

            With CType(post, News)

                lblTitleData.Text = .Title
                lblCreationDateData.Text = .CreationDate
                rtxtPreviewText.Text = .Body
                lblCategoryData.Text = .Category.ToString

            End With

            lblCategoryData.Visible = True
            lblCategory.Visible = True
            tcPreviewControl.TabPages.Remove(ImagePage)

        ElseIf post.GetType = GetType(Photo) Then

            With CType(post, Photo)

                lblTitleData.Text = .Title
                lblCreationDateData.Text = .CreationDate
                rtxtPreviewText.Text = .Body
                picImageReview.Image = Image.FromFile(.Image)

            End With

            lblCategoryData.Visible = False
            lblCategory.Visible = False

            If Not tcPreviewControl.TabPages.Contains(ImagePage) Then
                tcPreviewControl.TabPages.Add(ImagePage)
            End If

        End If

    End Sub


    'Edit News/Photo
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPostsData.CellDoubleClick

        If post.GetType = GetType(News) Then

            Dim newsForm = New frmAddNews(post)
            newsForm.ShowDialog()

        ElseIf post.GetType = GetType(Photo) Then

            Dim photoForm = New frmAddPhoto(post)
            photoForm.ShowDialog()

        End If

        dgvPostsData.Refresh()

    End Sub


    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPostsData.CellMouseClick

        If e.Button <> MouseButtons.Right Then

            Return

        End If

        Try
            Dim temp As Integer = selectedIndex
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the file", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result <> DialogResult.Yes Then

                Return

            End If

            My.Computer.FileSystem.DeleteFile(ApplicationSettings.postsMenu(selectedIndex).FilePath)
            ApplicationSettings.postsMenu.RemoveAt(temp)

            LoadDataSource()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try



    End Sub


    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        frmUsers.ShowDialog()
    End Sub


    Private Sub AddNewsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewsToolStripMenuItem1.Click

        Dim newsForm = New frmAddNews()
        newsForm.ShowDialog()

        LoadDataSource()

    End Sub


    Private Sub AddPhotoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddPhotoToolStripMenuItem1.Click

        Dim photoForm = New frmAddPhoto()
        photoForm.ShowDialog()

        LoadDataSource()

    End Sub


    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

        Dim addUserForm = New frmAddUser()
        addUserForm.ShowDialog()

    End Sub


    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click

        Application.Restart()

    End Sub


    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    Private Sub LoadDataSource()

        dgvPostsData.DataSource = Nothing
        dgvPostsData.DataSource = ApplicationSettings.postsMenu

        dgvPostsData.Columns.Item(2).Visible = False
        dgvPostsData.Columns.Item(4).Visible = False

    End Sub

End Class