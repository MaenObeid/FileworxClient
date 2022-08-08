Public Class News
    Inherits Post

    Public Property Category() As FileworxClient.Category

    Public Sub New(title As String, description As String, category As FileworxClient.Category, body As String)

        MyBase.New(title, description, body)
        Me.Category = category

    End Sub

    Public Overrides Function toFileReprisintation() As String

        Return Title & "$$" & Description & "$$" & Category & "$$" & Body & "$$" & CreationDate

    End Function

End Class
