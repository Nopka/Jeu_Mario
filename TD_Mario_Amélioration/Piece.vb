Public Class Piece
    Private Taille As Size
    Private CoordonneesActuelles As Point
    Dim NombreAleatoire As Integer
    Dim NombreAleatoire2 As Integer


    Sub New(ByVal PositionOrigine As Point, ByVal TaillePiece As Size)
        'Constructeur de Piece
        'Initialisation des paramètres d'un nouvel objet Piece
        CoordonneesActuelles = New Point(PositionOrigine)
        Taille = New Size(TaillePiece)
    End Sub
    'déplacement de la piece sur une position aléatoire du plateau
    Public Sub Deplacement_Piece()
        NombreAleatoire = Int((29 * Rnd() + 1)) * 40
        NombreAleatoire2 = Int((15 * Rnd() + 1)) * 40
        CoordonneesActuelles.X = NombreAleatoire
        CoordonneesActuelles.Y = NombreAleatoire2
    End Sub


    Public Property Position() As Point
        Set(ByVal value As Point)
            CoordonneesActuelles = value
        End Set
        Get
            Return CoordonneesActuelles
        End Get
    End Property

End Class
