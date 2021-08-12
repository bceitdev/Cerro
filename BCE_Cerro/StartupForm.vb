Public Class StartupForm
    Public Shared Sub Main()

        'The form that we will end up showing
        Dim formToShow As System.Windows.Forms.Form = Nothing

        'The determiner as to which form to show
        'Choose the appropriate form
        Select Case MainMenuId
            Case 2
                MainMenu.Dispose()
                formToShow = New BCEParent
            Case 3
                MainMenu.Dispose()
                formToShow = New BCEParent
        End Select

        'Show the form, and keep it open until it's explicitly closed.
        formToShow.ShowDialog()

    End Sub
End Class
