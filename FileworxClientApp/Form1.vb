Imports System.IO

Public Class FileworxClient

    'Category Enumeration
    Public Enum Category
        General
        Sports
        Health
        Politics
    End Enum

    Public Shared streamWriter As StreamWriter
    Public Shared fileStreamWriter As FileStream
    Public Shared streamReader As StreamReader
    Public Shared fileStreamReader As FileStream

    Shared currentDir As String = Directory.GetCurrentDirectory.ToString.Split("FileworxClientApp")(0)
    Public Shared usersDirectory As String = currentDir & "FileworxClientApp\Users\"
    Public Shared newsDirectory As String = currentDir & "FileworxClientApp\News\"
    Public Shared photosDirectory As String = currentDir & "FileworxClientApp\Photos\"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FirstPage.Show()
        FirstPage.WindowState = FormWindowState.Maximized

        Me.Hide()

    End Sub

End Class
