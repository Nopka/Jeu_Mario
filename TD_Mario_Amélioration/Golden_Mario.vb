﻿Public Class Golden_Mario
    Private Taille As Size
    Private CoordonneesActuelles As Point
    Dim NombreAleatoire As Integer


    Sub New(ByVal PositionOrigine As Point, ByVal TaillePiece As Size)
        'Constructeur de Golden_Mario
        'Initialisation des paramètres d'un nouvel objet Golden_Mario
        CoordonneesActuelles = New Point(PositionOrigine)
        Taille = New Size(TaillePiece)
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
