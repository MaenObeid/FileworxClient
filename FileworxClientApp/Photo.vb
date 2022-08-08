Public Class Photo
    Inherits Post

    Public Property Image() As String

    Public Sub New(title As String, description As String, body As String, image As String)

        MyBase.New(title, description, body)
        Me.Image = image

    End Sub

    Public Overrides Function toFileReprisintation() As String

        Return Title & "$$" & Description & "$$" & Image & "$$" & Body & "$$" & CreationDate

    End Function

End Class
