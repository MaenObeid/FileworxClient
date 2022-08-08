Imports System.IO

Public Class Home

    Dim files As ArrayList
    Dim records As ArrayList = New ArrayList
    Dim selectedIndex As Integer
    Dim directoryName As String

    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PreviewPanel.Height = My.Computer.Screen.Bounds.Height
        PreviewPanel.SplitterDistance = My.Computer.Screen.Bounds.Height / 3

        Try

            files = New ArrayList(Directory.GetFiles(FileworxClient.newsDirectory))

            For Each photo In Directory.GetFiles(FileworxClient.photosDirectory)

                files.Add(photo)

            Next

            For Each file In files

                FileworxClient.fileStreamReader = New FileStream(file, FileMode.Open, FileAccess.Read)
                FileworxClient.streamReader = New StreamReader(FileworxClient.fileStreamReader)

                Dim record = FileworxClient.streamReader.ReadLine().Split({"$$"}, System.StringSplitOptions.RemoveEmptyEntries)
                records.Add(record)

                DataGridView1.Rows.Add(record(0), record(4), record(1))

                FileworxClient.streamReader.Close()

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        selectedIndex = DataGridView1.SelectedRows.Item(0).Index

        directoryName = Directory.GetParent(files(selectedIndex)).Name.ToString
        Dim row = records(selectedIndex)

        If directoryName = "News" Then

            titleLabel.Text = row(0)
            creationLabel.Text = row(4)
            categoryLabel.Text = CType(row(2), FileworxClient.Category).ToString
            PreviewText.Text = row(3)

            categoryLabel.Visible = True
            categoryL.Visible = True
            previewControl.TabPages.Remove(ImagePage)

        ElseIf directoryName = "Photos" Then

            titleLabel.Text = row(0)
            creationLabel.Text = row(4)
            PreviewText.Text = row(3)
            ImageReview.Image = Image.FromFile(row(2))

            categoryLabel.Visible = False
            categoryL.Visible = False

            If Not previewControl.TabPages.Contains(ImagePage) Then
                previewControl.TabPages.Add(ImagePage)
            End If

        End If

    End Sub

    'Edit News/Photo
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If directoryName = "News" Then

            Dim newsForm = New AddNews(records(selectedIndex), files(selectedIndex))
            newsForm.ShowDialog()

        ElseIf directoryName = "Photos" Then

            Dim photoForm = New AddPhoto(records(selectedIndex), files(selectedIndex))
            photoForm.ShowDialog()

        End If


    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If e.Button = MouseButtons.Right Then
            Try

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the file", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If result = Windows.Forms.DialogResult.Yes Then

                    My.Computer.FileSystem.DeleteFile(files(selectedIndex))

                    _Refresh()
                    Home_Load(sender, e)
                    Home_Resize(sender, e)

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

        End If

    End Sub

    Public Sub Home_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        DataGridView1.Width = Me.Width - 40
        titleLabel.Width = Me.Width - 140
        creationLabel.Width = Me.Width - 140
        categoryLabel.Width = Me.Width - 140
        previewControl.Width = Me.Width - 38
        PreviewPanel.Width = Me.Width

    End Sub
    Private Sub PreviewPanel_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles PreviewPanel.SplitterMoved
        previewControl.Height = PreviewPanel.SplitterDistance - 100

    End Sub

    Public Sub _Refresh()

        files.Clear()
        records.Clear()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again

    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Users.ShowDialog()
    End Sub

    Private Sub AddNewsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewsToolStripMenuItem1.Click

        Dim newsForm = New AddNews()
        newsForm.ShowDialog()

    End Sub

    Private Sub AddPhotoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddPhotoToolStripMenuItem1.Click

        Dim photoForm = New AddPhoto()
        photoForm.ShowDialog()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click

        Dim addUserForm = New AddUser()
        addUserForm.ShowDialog()

    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click

        Me.Hide()
        FirstPage._Refresh()
        FirstPage.FirstPage_Load(sender, e)
        FirstPage.Show()

    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class