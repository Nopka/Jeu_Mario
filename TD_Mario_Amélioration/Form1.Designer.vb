<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Bouton_Retour_Accueil = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Espace_de_Jeu = New System.Windows.Forms.Panel()
        Me.ImageMario = New System.Windows.Forms.PictureBox()
        Me.Golden_Mushroom4 = New System.Windows.Forms.PictureBox()
        Me.Golden_Mushroom3 = New System.Windows.Forms.PictureBox()
        Me.Golden_Mushroom2 = New System.Windows.Forms.PictureBox()
        Me.Golden_Mushroom1 = New System.Windows.Forms.PictureBox()
        Me.Piece = New System.Windows.Forms.PictureBox()
        Me.ShadowMario4 = New System.Windows.Forms.PictureBox()
        Me.ShadowMario3 = New System.Windows.Forms.PictureBox()
        Me.ShadowMario2 = New System.Windows.Forms.PictureBox()
        Me.ShadowMario1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Case_NBPiece = New System.Windows.Forms.TextBox()
        Me.Timer_Golden_Mario = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Defaite = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer_Golden_Printed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Espace_de_Jeu.SuspendLayout()
        CType(Me.ImageMario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Golden_Mushroom4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Golden_Mushroom3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Golden_Mushroom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Golden_Mushroom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowMario4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowMario3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowMario2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowMario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bouton_Retour_Accueil
        '
        Me.Bouton_Retour_Accueil.Location = New System.Drawing.Point(1137, 698)
        Me.Bouton_Retour_Accueil.Name = "Bouton_Retour_Accueil"
        Me.Bouton_Retour_Accueil.Size = New System.Drawing.Size(75, 23)
        Me.Bouton_Retour_Accueil.TabIndex = 4
        Me.Bouton_Retour_Accueil.Text = "FERMER"
        Me.Bouton_Retour_Accueil.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1056, 698)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Espace_de_Jeu
        '
        Me.Espace_de_Jeu.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Espace_de_Jeu.Controls.Add(Me.ImageMario)
        Me.Espace_de_Jeu.Controls.Add(Me.Golden_Mushroom4)
        Me.Espace_de_Jeu.Controls.Add(Me.Golden_Mushroom3)
        Me.Espace_de_Jeu.Controls.Add(Me.Golden_Mushroom2)
        Me.Espace_de_Jeu.Controls.Add(Me.Golden_Mushroom1)
        Me.Espace_de_Jeu.Controls.Add(Me.Piece)
        Me.Espace_de_Jeu.Controls.Add(Me.ShadowMario4)
        Me.Espace_de_Jeu.Controls.Add(Me.ShadowMario3)
        Me.Espace_de_Jeu.Controls.Add(Me.ShadowMario2)
        Me.Espace_de_Jeu.Controls.Add(Me.ShadowMario1)
        Me.Espace_de_Jeu.Location = New System.Drawing.Point(12, 35)
        Me.Espace_de_Jeu.Name = "Espace_de_Jeu"
        Me.Espace_de_Jeu.Size = New System.Drawing.Size(1200, 640)
        Me.Espace_de_Jeu.TabIndex = 6
        '
        'ImageMario
        '
        Me.ImageMario.BackgroundImage = CType(resources.GetObject("ImageMario.BackgroundImage"), System.Drawing.Image)
        Me.ImageMario.Location = New System.Drawing.Point(600, 320)
        Me.ImageMario.Name = "ImageMario"
        Me.ImageMario.Size = New System.Drawing.Size(40, 40)
        Me.ImageMario.TabIndex = 15
        Me.ImageMario.TabStop = False
        '
        'Golden_Mushroom4
        '
        Me.Golden_Mushroom4.BackgroundImage = CType(resources.GetObject("Golden_Mushroom4.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mushroom4.Location = New System.Drawing.Point(240, 80)
        Me.Golden_Mushroom4.Name = "Golden_Mushroom4"
        Me.Golden_Mushroom4.Size = New System.Drawing.Size(40, 40)
        Me.Golden_Mushroom4.TabIndex = 14
        Me.Golden_Mushroom4.TabStop = False
        '
        'Golden_Mushroom3
        '
        Me.Golden_Mushroom3.BackgroundImage = CType(resources.GetObject("Golden_Mushroom3.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mushroom3.Location = New System.Drawing.Point(920, 80)
        Me.Golden_Mushroom3.Name = "Golden_Mushroom3"
        Me.Golden_Mushroom3.Size = New System.Drawing.Size(40, 40)
        Me.Golden_Mushroom3.TabIndex = 13
        Me.Golden_Mushroom3.TabStop = False
        '
        'Golden_Mushroom2
        '
        Me.Golden_Mushroom2.BackgroundImage = CType(resources.GetObject("Golden_Mushroom2.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mushroom2.Location = New System.Drawing.Point(920, 520)
        Me.Golden_Mushroom2.Name = "Golden_Mushroom2"
        Me.Golden_Mushroom2.Size = New System.Drawing.Size(40, 40)
        Me.Golden_Mushroom2.TabIndex = 12
        Me.Golden_Mushroom2.TabStop = False
        '
        'Golden_Mushroom1
        '
        Me.Golden_Mushroom1.BackgroundImage = CType(resources.GetObject("Golden_Mushroom1.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mushroom1.Location = New System.Drawing.Point(240, 520)
        Me.Golden_Mushroom1.Name = "Golden_Mushroom1"
        Me.Golden_Mushroom1.Size = New System.Drawing.Size(40, 40)
        Me.Golden_Mushroom1.TabIndex = 11
        Me.Golden_Mushroom1.TabStop = False
        '
        'Piece
        '
        Me.Piece.BackgroundImage = CType(resources.GetObject("Piece.BackgroundImage"), System.Drawing.Image)
        Me.Piece.Location = New System.Drawing.Point(160, 240)
        Me.Piece.Name = "Piece"
        Me.Piece.Size = New System.Drawing.Size(40, 40)
        Me.Piece.TabIndex = 9
        Me.Piece.TabStop = False
        '
        'ShadowMario4
        '
        Me.ShadowMario4.BackgroundImage = CType(resources.GetObject("ShadowMario4.BackgroundImage"), System.Drawing.Image)
        Me.ShadowMario4.Location = New System.Drawing.Point(1160, 0)
        Me.ShadowMario4.Name = "ShadowMario4"
        Me.ShadowMario4.Size = New System.Drawing.Size(40, 40)
        Me.ShadowMario4.TabIndex = 8
        Me.ShadowMario4.TabStop = False
        '
        'ShadowMario3
        '
        Me.ShadowMario3.BackgroundImage = CType(resources.GetObject("ShadowMario3.BackgroundImage"), System.Drawing.Image)
        Me.ShadowMario3.Location = New System.Drawing.Point(1160, 600)
        Me.ShadowMario3.Name = "ShadowMario3"
        Me.ShadowMario3.Size = New System.Drawing.Size(40, 40)
        Me.ShadowMario3.TabIndex = 7
        Me.ShadowMario3.TabStop = False
        '
        'ShadowMario2
        '
        Me.ShadowMario2.BackgroundImage = CType(resources.GetObject("ShadowMario2.BackgroundImage"), System.Drawing.Image)
        Me.ShadowMario2.Location = New System.Drawing.Point(0, 600)
        Me.ShadowMario2.Name = "ShadowMario2"
        Me.ShadowMario2.Size = New System.Drawing.Size(40, 40)
        Me.ShadowMario2.TabIndex = 6
        Me.ShadowMario2.TabStop = False
        '
        'ShadowMario1
        '
        Me.ShadowMario1.BackgroundImage = CType(resources.GetObject("ShadowMario1.BackgroundImage"), System.Drawing.Image)
        Me.ShadowMario1.Location = New System.Drawing.Point(0, 0)
        Me.ShadowMario1.Name = "ShadowMario1"
        Me.ShadowMario1.Size = New System.Drawing.Size(40, 40)
        Me.ShadowMario1.TabIndex = 5
        Me.ShadowMario1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(601, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mario"
        '
        'Case_NBPiece
        '
        Me.Case_NBPiece.Location = New System.Drawing.Point(138, 681)
        Me.Case_NBPiece.Name = "Case_NBPiece"
        Me.Case_NBPiece.Size = New System.Drawing.Size(44, 20)
        Me.Case_NBPiece.TabIndex = 13
        '
        'Timer_Golden_Mario
        '
        Me.Timer_Golden_Mario.Interval = 15000
        '
        'Timer_Defaite
        '
        Me.Timer_Defaite.Interval = 15000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(9, 684)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre de pièce récolté"
        '
        'Timer_Golden_Printed
        '
        Me.Timer_Golden_Printed.Location = New System.Drawing.Point(203, 701)
        Me.Timer_Golden_Printed.Name = "Timer_Golden_Printed"
        Me.Timer_Golden_Printed.Size = New System.Drawing.Size(43, 20)
        Me.Timer_Golden_Printed.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 704)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Temp restant en Forme Golden_Mario"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1222, 734)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Timer_Golden_Printed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Case_NBPiece)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Espace_de_Jeu)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Bouton_Retour_Accueil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu Mario"
        Me.Espace_de_Jeu.ResumeLayout(False)
        CType(Me.ImageMario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Golden_Mushroom4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Golden_Mushroom3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Golden_Mushroom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Golden_Mushroom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowMario4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowMario3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowMario2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowMario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bouton_Retour_Accueil As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Espace_de_Jeu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Piece As PictureBox
    Friend WithEvents ShadowMario4 As PictureBox
    Friend WithEvents ShadowMario3 As PictureBox
    Friend WithEvents ShadowMario2 As PictureBox
    Friend WithEvents ShadowMario1 As PictureBox
    Friend WithEvents Golden_Mushroom1 As PictureBox
    Friend WithEvents Golden_Mushroom2 As PictureBox
    Friend WithEvents Golden_Mushroom4 As PictureBox
    Friend WithEvents Golden_Mushroom3 As PictureBox
    Friend WithEvents Case_NBPiece As TextBox
    Friend WithEvents ImageMario As PictureBox
    Friend WithEvents Timer_Golden_Mario As Timer
    Friend WithEvents Timer_Defaite As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer_Golden_Printed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
