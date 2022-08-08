Imports System.IO

Public Class FirstPage

    Public Shared currentUserName As String
    Dim users As ArrayList = New ArrayList()

    Public Sub FirstPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim files() As String = Directory.GetFiles(FileworxClient.usersDirectory)

            For Each file In files
                FileworxClient.fileStreamReader = New FileStream(file, FileMode.Open, FileAccess.Read)
                FileworxClient.streamReader = New StreamReader(FileworxClient.fileStreamReader)

                Dim record() As String = FileworxClient.streamReader.ReadLine().Split({"$$"}, System.StringSplitOptions.RemoveEmptyEntries)

                'creating new user object and save it in users array
                users.Add(New User(record(0), record(1), record(2), record(3), record(4)))

                FileworxClient.streamReader.Close()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim name = loginNameSignIn.Text.Trim
        Dim password = passwordSignIn.Text.Trim

        If name <> String.Empty AndAlso password <> String.Empty Then

            Dim realUserFlag As Boolean = False

            Try

                For Each user In users

                    With CType(user, User)

                        If .LoginName = name AndAlso .Password = password AndAlso .Activity Then
                            realUserFlag = True
                            currentUserName = .FullName
                            Exit For
                        End If

                    End With

                Next

                If realUserFlag Then
                    moveToHome()
                Else
                    MessageBox.Show("Wrong Name or password, or the user disabled/not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FirstPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel1.BackColor = Color.FromArgb(100, Color.White)
        Panel2.BackColor = Color.FromArgb(150, Color.White)
        Panel2.Width = Me.Width
        Panel2.Top = (Me.Height - Panel2.Height) / 2 - 30
        Panel1.Left = (Panel2.Width - Panel1.Width) / 2
        Panel1.Top = (Panel2.Height - Panel1.Height) / 2
    End Sub

    Private Sub FirstPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Public Sub moveToHome()

        Me.Hide()
        Home.Show()
        Home.WindowState = FormWindowState.Maximized

    End Sub

    Public Sub _Refresh()

        users.Clear()
        Me.Controls.Clear()
        InitializeComponent()

    End Sub

End Class