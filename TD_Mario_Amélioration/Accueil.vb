Public Class Accueil
    Private Sub Boutton_Jouer_Click(sender As Object, e As EventArgs) Handles Boutton_Jouer.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Bouton_Fermer_Click(sender As Object, e As EventArgs) Handles Bouton_Fermer.Click
        Close()
    End Sub
End Class