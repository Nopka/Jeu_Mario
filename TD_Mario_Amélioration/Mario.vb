Public Class Mario
    Private Taille As Size
    Private CoordonneesActuelles As Point
    Sub New(ByVal PositionOrigine As Point, ByVal TailleMario As Size)
        'Constructeur de Mario
        'Initialisation des paramètres d'un nouvel objet Mario
        CoordonneesActuelles = New Point(PositionOrigine)
        Taille = New Size(TailleMario)
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

#Region "Méthodes de déplacement de l'objet Mario"

    Public Sub Gauche()
        'L'objet Mario recule de sa position actuelle d'un pas = sa largeur
        CoordonneesActuelles.X = CoordonneesActuelles.X - PasX()
        If CoordonneesActuelles.X < 0 Then
            CoordonneesActuelles.X = 1160
        End If
    End Sub

    Public Sub Droit()
        'L'objet Mario avance de sa position actuelle d'un pas = sa largeur
        CoordonneesActuelles.X = CoordonneesActuelles.X + PasX()
        If CoordonneesActuelles.X > 1160 Then
            CoordonneesActuelles.X = 0
        End If
    End Sub

    Public Sub Haut()
        'L'objet Mario monte d'une hauteur par rapport à sa position
        CoordonneesActuelles.Y = CoordonneesActuelles.Y - PasY()
        If CoordonneesActuelles.Y < 0 Then
            CoordonneesActuelles.Y = 600
        End If
    End Sub

    Public Sub Bas()
        'L'objet Mario descend d'une hauteur par rapport à sa position
        CoordonneesActuelles.Y = CoordonneesActuelles.Y + PasY()
        If CoordonneesActuelles.Y > 600 Then
            CoordonneesActuelles.Y = 0
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
