Module MainModule
    Function Main() As Integer

        Application.EnableVisualStyles()
        Application.DoEvents()

        Dim signInForm As New frmSignIn()
        signInForm.ShowDialog()

        While (Not signInForm.UserExists)

            MessageBox.Show("Wrong Name or password, or the user disabled/not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Try
                signInForm.ShowDialog()

            Catch ex As System.ObjectDisposedException
                Return 0
            End Try

        End While

        Dim homeForm As New frmHome()
        homeForm.ShowDialog()

        Return 0

    End Function

End Module
