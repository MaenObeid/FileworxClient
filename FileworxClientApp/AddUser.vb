Imports System.IO

Public Class AddUser

    Dim filePath As String = FileworxClient.usersDirectory & Guid.NewGuid().ToString() & ".txt"
    Dim filePathToEdit As String
    Dim recordToEdit() As String

    Public Sub New(Optional record() As String = Nothing, Optional filePath As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        recordToEdit = record
        filePathToEdit = filePath

    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If recordToEdit IsNot Nothing Then

            nameSignUp.Text = recordToEdit(0)
            loginNameSignUp.Text = recordToEdit(1)
            passwordSignUp.Text = recordToEdit(2)

        End If

    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click

        Dim name = nameSignUp.Text.Trim
        Dim loginName = loginNameSignUp.Text.Trim
        Dim password = passwordSignUp.Text.Trim
        Dim refreshFlag As Boolean = False

        If name <> String.Empty AndAlso loginName <> String.Empty AndAlso password <> String.Empty Then

            Try

                Dim user = New User(name, loginName, password, FirstPage.currentUserName)

                If filePathToEdit IsNot Nothing Then

                    filePath = filePathToEdit

                    user.LastModifier = FirstPage.currentUserName
                    user.Activity = recordToEdit(4)

                    'on EDIT only, refresh the Users page
                    refreshFlag = True

                Else

                    filePath = FileworxClient.usersDirectory & Guid.NewGuid().ToString() & ".txt"

                End If

                FileworxClient.fileStreamWriter = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)
                FileworxClient.streamWriter = New StreamWriter(FileworxClient.fileStreamWriter)

                FileworxClient.streamWriter.WriteLine(user.toFileReprisintation)
                FileworxClient.streamWriter.Close()

                If refreshFlag Then

                    Users._Refresh()
                    Users.Users_Load(sender, e)

                End If


                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AddUserCancelButton.Click

        Me.Close()

    End Sub

    Private Sub AddUser_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        Panel1.Width = Me.Width - 140
        Panel1.Left = (Me.Width - Panel1.Width) / 2 - 10
        Panel1.Top = (Me.Height - Panel1.Height) / 2 - 40

        nameSignUp.Width = Panel1.Width - 158
        loginNameSignUp.Width = Panel1.Width - 158
        passwordSignUp.Width = Panel1.Width - 158

        AddUserCancelButton.Location = New Point(passwordSignUp.Location.X + passwordSignUp.Width - AddUserCancelButton.Width, AddUserCancelButton.Location.Y)
        SignUp.Location = New Point(AddUserCancelButton.Location.X - AddUserCancelButton.Width - 6, SignUp.Location.Y)

    End Sub

End Class