Imports System.IO

Public Class frmAddUser

    Private User As User


    Public Sub New(Optional user As User = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.User = user

    End Sub


    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If User Is Nothing Then

            Return

        End If

        With User

            txtName.Text = .FullName
            txtLogin.Text = .LoginName
            txtPassword.Text = .Password

        End With

    End Sub


    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim name = txtName.Text.Trim
        Dim loginName = txtLogin.Text.Trim
        Dim password = txtPassword.Text.Trim

        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(loginName) OrElse String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        Try

            If User Is Nothing Then

                User = New User(name, loginName, password, ApplicationSettings.currentUserName)

            Else

                With User
                    .FullName = name
                    .LoginName = loginName
                    .Password = password
                    .LastModifier = ApplicationSettings.currentUserName
                End With

            End If

            Dim fileStreamWriter = New FileStream(User.FilePath, FileMode.OpenOrCreate, FileAccess.Write)

            Using streamWriter As New StreamWriter(fileStreamWriter)

                streamWriter.WriteLine(User.toFileReprisintation())

            End Using

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

End Class