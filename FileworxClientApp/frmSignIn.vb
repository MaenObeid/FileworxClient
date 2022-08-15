Imports System.IO

Public Class frmSignIn

    Public UserExists As Boolean = False


    Private Sub FirstPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ApplicationSettings.usersList.Count <> 0 Then

            Return

        End If

        Try
            Dim files() As String = Directory.GetFiles(ApplicationSettings.usersDirectory)

            For Each file As String In files

                Using fileStreamReader As New FileStream(file, FileMode.Open, FileAccess.Read)

                    Using streamReader = New StreamReader(fileStreamReader)

                        Dim record() As String = streamReader.ReadLine().Split({ApplicationSettings.separator}, System.StringSplitOptions.RemoveEmptyEntries)

                        'creating new user object and save it in usersList
                        ApplicationSettings.usersList.Add(New User(record, file))

                    End Using

                End Using

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim name = txtUserName.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        Try

            For Each user As User In ApplicationSettings.usersList

                With user

                    If .LoginName = name AndAlso .Password = password AndAlso .Activity Then

                        UserExists = True
                        ApplicationSettings.currentUserName = .FullName
                        Exit For

                    End If

                End With

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Hide()

    End Sub


    Private Sub FirstPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Application.Exit()

    End Sub


    Private Sub AddUserCancelButton_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Application.Exit()

    End Sub


End Class