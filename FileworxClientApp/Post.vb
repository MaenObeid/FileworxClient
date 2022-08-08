﻿'Abstract class

Public MustInherit Class Post
    Public Property Title() As String
    Public Property Description() As String
    Public Property Body() As String
    Public Property CreationDate() As DateTime

    Public Sub New(title As String, description As String, body As String)

        ' checking the limits before creating the object
        If title.Length < 255 AndAlso description.Length < 255 AndAlso body.Length < 10000 Then
            With Me
                .Title = title
                .Description = description
                .Body = body
                .CreationDate = DateTime.Now

            End With
        Else
            Throw New Exception("Exception -> Some fields exceeded the limit")
        End If

    End Sub

    Public MustOverride Function toFileReprisintation() As String

End Class
