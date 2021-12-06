Public Class Form1
    '--------------------------Déclaration de variables--------------------------

    Dim MonMario As Mario

    Dim MonShadow_Mario1 As Shadow_Mario
    Dim MonShadow_Mario2 As Shadow_Mario
    Dim MonShadow_Mario3 As Shadow_Mario
    Dim MonShadow_Mario4 As Shadow_Mario

    Dim Ma_Piece As Piece

    Dim Mon_Golden_Mushroom1 As Golden_Mushroom
    Dim Mon_Golden_Mushroom2 As Golden_Mushroom
    Dim Mon_Golden_Mushroom3 As Golden_Mushroom
    Dim Mon_Golden_Mushroom4 As Golden_Mushroom

    Dim Compteur_Piece As Integer
    Dim Compteur_Mushroom As Integer

    Dim Golden_Mushroom1_Taken As Boolean = False
    Dim Golden_Mushroom2_Taken As Boolean = False
    Dim Golden_Mushroom3_Taken As Boolean = False
    Dim Golden_Mushroom4_Taken As Boolean = False

    Dim Mon_Golden_Mario As Golden_Mario

    Dim temp As Point

    Dim GoldenMushroomNotHiding1 As Boolean = False
    Dim GoldenMushroomNotHiding2 As Boolean = False
    Dim GoldenMushroomNotHiding3 As Boolean = False
    Dim GoldenMushroomNotHiding4 As Boolean = False

    Dim GoldenMarioForm As Boolean = False

    Dim ShadowMario1Killed As Boolean = False
    Dim ShadowMario2Killed As Boolean = False
    Dim ShadowMario3Killed As Boolean = False
    Dim ShadowMario4Killed As Boolean = False

    Dim CompteurDeKill As Integer

    Dim compteur_Timer As Integer

    Dim compteur_de_timer As Integer
    '--------------------------Fin de déclaration de variable--------------------------


    Private Sub PlateauJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciation de MonMario en appellant le constructeur de la Classe
        MonMario = New Mario(ImageMario.Location, ImageMario.Size)
        'Instanciation des Shadow_Mario en appellant le constructeur de la Classe
        MonShadow_Mario1 = New Shadow_Mario(ShadowMario1.Location, ShadowMario1.Size)
        MonShadow_Mario2 = New Shadow_Mario(ShadowMario1.Location, ShadowMario1.Size)
        MonShadow_Mario3 = New Shadow_Mario(ShadowMario1.Location, ShadowMario1.Size)
        MonShadow_Mario4 = New Shadow_Mario(ShadowMario1.Location, ShadowMario1.Size)
        'Instanciation de Ma_Piece en appellant le constructeur de la Classe
        Ma_Piece = New Piece(Piece.Location, Piece.Size)
        'Instanciation de Mon_Golden_Mushroom en appellant le constructeur de la Classe
        Mon_Golden_Mushroom1 = New Golden_Mushroom(Golden_Mushroom1.Location, Golden_Mushroom1.Size)
        Mon_Golden_Mushroom2 = New Golden_Mushroom(Golden_Mushroom2.Location, Golden_Mushroom1.Size)
        Mon_Golden_Mushroom3 = New Golden_Mushroom(Golden_Mushroom3.Location, Golden_Mushroom1.Size)
        Mon_Golden_Mushroom4 = New Golden_Mushroom(Golden_Mushroom4.Location, Golden_Mushroom1.Size)
        'On "cache" les panneaux de victoire et de defaite ainsi que les golden mushrooms
        Golden_Mushroom1.Hide()
        Golden_Mushroom2.Hide()
        Golden_Mushroom3.Hide()
        Golden_Mushroom4.Hide()
        'Permet de laisser le programme savoir si une touche est appuyer
        Me.KeyPreview = True
        CompteurDeKill = 0
        compteur_de_timer = 0
    End Sub

    'Permet de prendre les Golden Mushroom et de lancer leurs timer respectif, ainsi que de lancer le timer de défaite lorsque l'on prend un 
    'golden mushroom pour la 4 eme fois.
    Function Golden_Mushroom_Taken()
        If Golden_Mushroom1.Location = ImageMario.Location And Golden_Mushroom1_Taken = False And GoldenMushroomNotHiding1 = True Then
            Golden_Mushroom1.Hide()
            Golden_Mushroom1_Taken = True
            GoldenMushroomNotHiding1 = True
            ImageMario.Image = My.Resources.GoldenMario
            GoldenMarioForm = True
            compteur_Timer = 15

            If compteur_de_timer <> 3 Then
                Timer_Golden_Mario.Start()
                Timer1.Start()
                compteur_de_timer = compteur_de_timer + 1
            ElseIf compteur_de_timer = 3 Then
                Timer_Defaite.Start()
                Timer1.Start()
            End If

        ElseIf Golden_Mushroom2.Location = ImageMario.Location And Golden_Mushroom2_Taken = False And GoldenMushroomNotHiding2 = True Then
            Golden_Mushroom2.Hide()
            Golden_Mushroom2_Taken = True
            GoldenMushroomNotHiding2 = True
            ImageMario.Image = My.Resources.GoldenMario
            GoldenMarioForm = True
            compteur_Timer = 15

            If compteur_de_timer <> 3 Then
                Timer_Golden_Mario.Start()
                Timer1.Start()
                compteur_de_timer = compteur_de_timer + 1
            ElseIf compteur_de_timer = 3 Then
                Timer_Defaite.Start()
                Timer1.Start()
            End If

        ElseIf Golden_Mushroom3.Location = ImageMario.Location And Golden_Mushroom3_Taken = False And GoldenMushroomNotHiding3 = True Then
            Golden_Mushroom3.Hide()
            Golden_Mushroom3_Taken = True
            GoldenMushroomNotHiding3 = True
            ImageMario.Image = My.Resources.GoldenMario
            GoldenMarioForm = True
            compteur_Timer = 15

            If compteur_de_timer <> 3 Then
                Timer_Golden_Mario.Start()
                Timer1.Start()
                compteur_de_timer = compteur_de_timer + 1
            ElseIf compteur_de_timer = 3 Then
                Timer_Defaite.Start()
                Timer1.Start()
            End If

        ElseIf Golden_Mushroom4.Location = ImageMario.Location And Golden_Mushroom4_Taken = False And GoldenMushroomNotHiding4 = True Then
            Golden_Mushroom4.Hide()
            Golden_Mushroom4_Taken = True
            GoldenMushroomNotHiding4 = True
            ImageMario.Image = My.Resources.GoldenMario
            GoldenMarioForm = True
            compteur_Timer = 15

            If compteur_de_timer <> 3 Then
                Timer_Golden_Mario.Start()
                Timer1.Start()
                compteur_de_timer = compteur_de_timer + 1
            ElseIf compteur_de_timer = 3 Then
                Timer_Defaite.Start()
                Timer1.Start()
            End If


        End If
#Disable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code
    End Function
#Enable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code

    'Gestion du spawn des Golden Mushrooms
    Function Spawn_Golden_Mushroom()
        If Compteur_Piece = 3 And Golden_Mushroom1_Taken = False Then
            Golden_Mushroom1.Show()
            GoldenMushroomNotHiding1 = True
        ElseIf Compteur_Piece = 6 And Golden_Mushroom2_Taken = False Then
            Golden_Mushroom2.Show()
            GoldenMushroomNotHiding2 = True
        ElseIf Compteur_Piece = 9 And Golden_Mushroom3_Taken = False Then
            Golden_Mushroom3.Show()
            GoldenMushroomNotHiding3 = True
        ElseIf Compteur_Piece = 12 And Golden_Mushroom4_Taken = False Then
            Golden_Mushroom4.Show()
            GoldenMushroomNotHiding4 = True
        End If
#Disable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code
    End Function
#Enable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code

    'Fonction pour attrapper les pieces, augmenter le compteur et changer sa position
    Function PieceAttrapper()
        If Piece.Location = ImageMario.Location Then
            Compteur_Piece = Compteur_Piece + 1
            Case_NBPiece.Text = Compteur_Piece
            Ma_Piece.Deplacement_Piece()
            Piece.Location = Ma_Piece.Position

        End If
#Disable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code
    End Function
#Enable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code

    'Permet de faire gagner le joueur si il 'tue' tous les Shadow_Mario
    Function Victory()
        If CompteurDeKill = 4 Then
            Victoire.Show()
            Me.Hide()
        End If
#Disable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code
    End Function
#Enable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code

    'Permet de faire perdre le joueur si il entre en colision avec un shadow_Mario ou de tuer le shadow-Mario si GoldenMario
    Function Collision_defaite()
        'gère la collision avec le Shadow_Mario 1
        If ShadowMario1.Location = ImageMario.Location And GoldenMarioForm = False And ShadowMario1Killed = False Then
            Defaite.Show()
            Me.Hide()
        ElseIf ShadowMario1.Location = ImageMario.Location And GoldenMarioForm = True And ShadowMario1Killed = False Then
            ShadowMario1.Hide()
            ShadowMario1Killed = True
            CompteurDeKill = CompteurDeKill + 1
        End If
        'gère la collision avec le Shadow_Mario 2
        If ShadowMario2.Location = ImageMario.Location And GoldenMarioForm = False And ShadowMario2Killed = False Then
            Defaite.Show()
            Me.Hide()
        ElseIf ShadowMario2.Location = ImageMario.Location And GoldenMarioForm = True And ShadowMario2Killed = False Then
            ShadowMario2.Hide()
            ShadowMario2Killed = True
            CompteurDeKill = CompteurDeKill + 1
        End If
        'gère la collision avec le Shadow_Mario 3
        If ShadowMario3.Location = ImageMario.Location And GoldenMarioForm = False And ShadowMario3Killed = False Then
            Defaite.Show()
            Me.Hide()
        ElseIf ShadowMario3.Location = ImageMario.Location And GoldenMarioForm = True And ShadowMario3Killed = False Then
            ShadowMario3.Hide()
            ShadowMario3Killed = True
            CompteurDeKill = CompteurDeKill + 1
        End If
        'gère la collision avec le Shadow_Mario 4
        If ShadowMario4.Location = ImageMario.Location And GoldenMarioForm = False And ShadowMario4Killed = False Then
            Defaite.Show()
            Me.Hide()
        ElseIf ShadowMario4.Location = ImageMario.Location And GoldenMarioForm = True And ShadowMario4Killed = False Then
            ShadowMario4.Hide()
            ShadowMario4Killed = True
            CompteurDeKill = CompteurDeKill + 1
        End If

#Disable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code
    End Function
#Enable Warning BC42105 ' La fonction ne renvoie pas de valeur sur tous les chemins de code

    Private Sub BoutonFermer_Click(sender As Object, e As EventArgs) Handles Bouton_Retour_Accueil.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Z
                MonMario.Haut()
                MonShadow_Mario1.Deplacement_Shadow_Mario()
                MonShadow_Mario2.Deplacement_Shadow_Mario()
                MonShadow_Mario3.Deplacement_Shadow_Mario()
                MonShadow_Mario4.Deplacement_Shadow_Mario()
            Case Keys.Q
                MonMario.Gauche()
                MonShadow_Mario1.Deplacement_Shadow_Mario()
                MonShadow_Mario2.Deplacement_Shadow_Mario()
                MonShadow_Mario3.Deplacement_Shadow_Mario()
                MonShadow_Mario4.Deplacement_Shadow_Mario()
            Case Keys.S
                MonMario.Bas()
                MonShadow_Mario1.Deplacement_Shadow_Mario()
                MonShadow_Mario2.Deplacement_Shadow_Mario()
                MonShadow_Mario3.Deplacement_Shadow_Mario()
                MonShadow_Mario4.Deplacement_Shadow_Mario()
            Case Keys.D
                MonMario.Droit()
                MonShadow_Mario1.Deplacement_Shadow_Mario()
                MonShadow_Mario2.Deplacement_Shadow_Mario()
                MonShadow_Mario3.Deplacement_Shadow_Mario()
                MonShadow_Mario4.Deplacement_Shadow_Mario()

        End Select
        ImageMario.Location = MonMario.Position
        ShadowMario1.Location = MonShadow_Mario1.Position
        ShadowMario2.Location = MonShadow_Mario2.Position
        ShadowMario3.Location = MonShadow_Mario3.Position
        ShadowMario4.Location = MonShadow_Mario4.Position
        PieceAttrapper()
        Collision_defaite()
        Spawn_Golden_Mushroom()
        Golden_Mushroom_Taken()
        Victory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Golden_Mario.Tick
        GoldenMarioForm = False
        ImageMario.Image = My.Resources.mario
        Timer_Golden_Mario.Stop()
    End Sub

    Private Sub Timer_Defaite_Tick(sender As Object, e As EventArgs) Handles Timer_Defaite.Tick
        GoldenMarioForm = False
        ImageMario.Image = My.Resources.mario
        Defaite.Show()
        Me.Hide()
        Timer_Defaite.Stop()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If compteur_Timer <> 0 Then
            compteur_Timer = compteur_Timer - 1
            Timer_Golden_Printed.Text = compteur_Timer
        ElseIf compteur_Timer = 0 Then
            Timer1.Stop()
        End If
    End Sub
End Class