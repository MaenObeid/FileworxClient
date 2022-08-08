Imports System.IO

Public Class Users

    Dim files As ArrayList
    Dim records As ArrayList = New ArrayList
    Dim buttonDecision As Boolean
    Dim selectedIndex As Integer


    Public Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            files = New ArrayList(Directory.GetFiles(FileworxClient.usersDirectory))

            For Each file In files

                FileworxClient.fileStreamReader = New FileStream(file, FileMode.Open, FileAccess.Read)
                FileworxClient.streamReader = New StreamReader(FileworxClient.fileStreamReader)

                Dim record = FileworxClient.streamReader.ReadLine().Split({"$$"}, System.StringSplitOptions.RemoveEmptyEntries)
                records.Add(record)

                UsersList.Rows.Add(record(0), record(1), record(2), record(3))

                FileworxClient.streamReader.Close()

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub UsersList_SelectionChanged(sender As Object, e As EventArgs) Handles UsersList.SelectionChanged

        selectedIndex = UsersList.SelectedRows.Item(0).Index

        Try

            If records(selectedIndex)(4) = True Then

                buttonDecision = False
                ActivityButton.Text = "Disable"
                ActivityButton.BackColor = Color.Crimson

            Else

                buttonDecision = True
                ActivityButton.Text = "Enable"
                ActivityButton.BackColor = Color.SteelBlue

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ActivityButton_Click(sender As Object, e As EventArgs) Handles ActivityButton.Click

        If buttonDecision = True OrElse buttonDecision = False Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to change this user activity?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = Windows.Forms.DialogResult.Yes Then

                ChangeActivity(buttonDecision)

                _Refresh()
                Users_Load(sender, e)

            End If

        End If

    End Sub

    Private Sub Users_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        UsersList.Width = Me.Width - 40

    End Sub

    Private Sub ChangeActivity(activity As Boolean)

        Try

            Dim user = New User(records(selectedIndex)(0), records(selectedIndex)(1), records(selectedIndex)(2), FirstPage.currentUserName, activity)
            FileworxClient.fileStreamWriter = New FileStream(files(selectedIndex), FileMode.Open, FileAccess.Write)
            FileworxClient.streamWriter = New StreamWriter(FileworxClient.fileStreamWriter)

            FileworxClient.streamWriter.WriteLine(user.toFileReprisintation)
            FileworxClient.streamWriter.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Users_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        _Refresh()

    End Sub

    Public Sub _Refresh()

        files.Clear()
        records.Clear()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again

    End Sub

    Private Sub UsersList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersList.CellDoubleClick

        Dim addUserForm = New AddUser(records(selectedIndex), files(selectedIndex))
        addUserForm.ShowDialog()

    End Sub

    Private Sub Users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()
    End Sub

End Class