Imports System.IO

Public Class frmUsers


    Dim buttonDecision As Boolean
    Dim selectedIndex As Integer
    Dim user As User


    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ApplicationSettings.usersList.Count <> 0 Then

            LoadDataSource()
            Return

        End If

        Dim files() As String

        Try

            files = Directory.GetFiles(ApplicationSettings.usersDirectory)

            For Each file As String In files

                Using fileStreamReader As New FileStream(file, FileMode.Open, FileAccess.Read)

                    Using streamReader = New StreamReader(fileStreamReader)

                        Dim record = streamReader.ReadLine().Split({ApplicationSettings.separator}, System.StringSplitOptions.RemoveEmptyEntries)
                        ApplicationSettings.usersList.Add(New User(record, file))

                    End Using

                End Using

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        LoadDataSource()

    End Sub

    Private Sub UsersList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsersList.SelectionChanged

        Try

            selectedIndex = dgvUsersList.SelectedRows.Item(0).Index

        Catch ex As Exception

            selectedIndex = 0

        End Try

        user = ApplicationSettings.usersList(selectedIndex)

        Try

            If user.Activity = True Then

                btnActivityButton.Text = "Disable"
                btnActivityButton.BackColor = Color.Crimson
                buttonDecision = False

            Else

                btnActivityButton.Text = "Enable"
                btnActivityButton.BackColor = Color.SteelBlue
                buttonDecision = True

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try

    End Sub

    Private Sub ActivityButton_Click(sender As Object, e As EventArgs) Handles btnActivityButton.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change this user activity?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then

            Return

        End If

        ChangeActivity(buttonDecision)

        LoadDataSource()

    End Sub


    Private Sub UsersList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsersList.CellDoubleClick

        Dim editUserForm = New frmAddUser(ApplicationSettings.usersList(selectedIndex))
        editUserForm.ShowDialog()

        dgvUsersList.Refresh()

    End Sub


    Private Sub Users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Me.Close()
        ApplicationSettings.usersList.Clear()

    End Sub


    Private Sub ChangeActivity(activity As Boolean)

        Try

            user.LastModifier = ApplicationSettings.currentUserName
            user.Activity = activity

            Using fileStreamWriter As New FileStream(user.FilePath, FileMode.Open, FileAccess.Write)

                Using streamWriter As New StreamWriter(fileStreamWriter)

                    streamWriter.WriteLine(user.toFileReprisintation())

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub LoadDataSource()

        dgvUsersList.DataSource = Nothing
        dgvUsersList.DataSource = ApplicationSettings.usersList

        dgvUsersList.Columns.Item(0).HeaderText = "Name"
        dgvUsersList.Columns.Item(1).HeaderText = "Login Name"
        dgvUsersList.Columns.Item(2).Visible = False
        dgvUsersList.Columns.Item(3).HeaderText = "Last Modifier"
        dgvUsersList.Columns.Item(4).Visible = False
        dgvUsersList.Columns.Item(5).Visible = False

    End Sub


End Class