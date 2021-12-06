Public Class Shadow_Mario
    Private Taille As Size
    Private CoordonneesActuelles As Point
    Dim NombreAleatoire As Integer
    Dim NombreAleatoire2 As Integer


    Sub New(ByVal PositionOrigine As Point, ByVal TailleShadow_Mario As Size)
        'Constructeur de Shadow_Mario
        'Initialisation des paramètres d'un nouvel objet Shadow_Mario
        CoordonneesActuelles = New Point(PositionOrigine)
        Taille = New Size(TailleShadow_Mario)
    End Sub


#Region "Fonctions privées caractéristiques Mario"
    'Fonction retournant la taille dont le déplacement selon l'axe X
    Private Function PasX()
        Return Taille.Width
    End Function
    'Fonction retournant la hauteur dont le déplacement selon l'axe Y
    Private Function PasY()
        Return Taille.Height
    End Function
#End Region

#Region "Déplacement aléatoire du Shadow_Mario"
    Public Sub Deplacement_Shadow_Mario()
        NombreAleatoire = 5 * Rnd() + 1
        NombreAleatoire2 = (2 * Rnd() + 1)

        If NombreAleatoire = 1 Then
            CoordonneesActuelles.X = CoordonneesActuelles.X - NombreAleatoire2 * PasX()
            If CoordonneesActuelles.X < 0 Then
                CoordonneesActuelles.X = 1160
            End If
        End If
        If NombreAleatoire = 2 Then
            CoordonneesActuelles.X = CoordonneesActuelles.X + NombreAleatoire2 * PasX()
            If CoordonneesActuelles.X > 1160 Then
                CoordonneesActuelles.X = 0
            End If
        End If
        If NombreAleatoire = 3 Then
            CoordonneesActuelles.Y = CoordonneesActuelles.Y - NombreAleatoire2 * PasY()
            If CoordonneesActuelles.Y < 0 Then
                CoordonneesActuelles.Y = 600
            End If
        End If
        If NombreAleatoire = 4 Then
            CoordonneesActuelles.Y = CoordonneesActuelles.Y + NombreAleatoire2 * PasY()
            If CoordonneesActuelles.Y > 600 Then
                CoordonneesActuelles.Y = 0
            End If
        End If
        If NombreAleatoire = 5 Then
            CoordonneesActuelles.Y = CoordonneesActuelles.Y
            CoordonneesActuelles.X = CoordonneesActuelles.X
        End If


    End Sub
#End Region





    Public Property Position() As Point
        Set(ByVal value As Point)
            CoordonneesActuelles = value
        End Set
        Get
            Return CoordonneesActuelles
        End Get
    End Property
End Class
