Public Class Victoire
    Private Sub Bouton_Accueil_Click(sender As Object, e As EventArgs) Handles Bouton_Accueil.Click
        Me.Hide()
        Form1.Show()
        Application.Restart()
    End Sub
End Class