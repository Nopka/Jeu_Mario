<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Golden_Mario_Expo = New System.Windows.Forms.PictureBox()
        Me.Golden_Mushroom_Expo = New System.Windows.Forms.PictureBox()
        Me.Piece_Expo = New System.Windows.Forms.PictureBox()
        Me.ShadowMario_Expo = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Boutton_Jouer = New System.Windows.Forms.Button()
        Me.Bouton_Fermer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Golden_Mario_Expo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Golden_Mushroom_Expo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piece_Expo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowMario_Expo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.36689!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.63311!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Golden_Mario_Expo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Golden_Mushroom_Expo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Piece_Expo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ShadowMario_Expo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.33598!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.98232!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.8939!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.8939!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.8939!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(680, 293)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(581, 52)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(3, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(572, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Golden_Mario : Il s'agit de votre forme ""ultime"", vous pouvez tuez les Shadow_Mar" &
    "io tant que vous ête sous cette forme"
        '
        'Golden_Mario_Expo
        '
        Me.Golden_Mario_Expo.BackgroundImage = CType(resources.GetObject("Golden_Mario_Expo.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mario_Expo.Location = New System.Drawing.Point(603, 236)
        Me.Golden_Mario_Expo.Name = "Golden_Mario_Expo"
        Me.Golden_Mario_Expo.Size = New System.Drawing.Size(40, 40)
        Me.Golden_Mario_Expo.TabIndex = 11
        Me.Golden_Mario_Expo.TabStop = False
        '
        'Golden_Mushroom_Expo
        '
        Me.Golden_Mushroom_Expo.BackgroundImage = CType(resources.GetObject("Golden_Mushroom_Expo.BackgroundImage"), System.Drawing.Image)
        Me.Golden_Mushroom_Expo.Location = New System.Drawing.Point(603, 178)
        Me.Golden_Mushroom_Expo.Name = "Golden_Mushroom_Expo"
        Me.Golden_Mushroom_Expo.Size = New System.Drawing.Size(40, 39)
        Me.Golden_Mushroom_Expo.TabIndex = 8
        Me.Golden_Mushroom_Expo.TabStop = False
        '
        'Piece_Expo
        '
        Me.Piece_Expo.BackgroundImage = CType(resources.GetObject("Piece_Expo.BackgroundImage"), System.Drawing.Image)
        Me.Piece_Expo.Location = New System.Drawing.Point(603, 120)
        Me.Piece_Expo.Name = "Piece_Expo"
        Me.Piece_Expo.Size = New System.Drawing.Size(40, 38)
        Me.Piece_Expo.TabIndex = 10
        Me.Piece_Expo.TabStop = False
        '
        'ShadowMario_Expo
        '
        Me.ShadowMario_Expo.BackgroundImage = CType(resources.GetObject("ShadowMario_Expo.BackgroundImage"), System.Drawing.Image)
        Me.ShadowMario_Expo.Location = New System.Drawing.Point(603, 62)
        Me.ShadowMario_Expo.Name = "ShadowMario_Expo"
        Me.ShadowMario_Expo.Size = New System.Drawing.Size(40, 40)
        Me.ShadowMario_Expo.TabIndex = 10
        Me.ShadowMario_Expo.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(371, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Golden_Mushroom : Vous transforme en Golden_Mario pendant 15 secondes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(3, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(324, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Pieces : Rammasser les pour faire apparaitre un golden Mushroom !"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(333, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Shadow_Mario : Il s'agit d'un ennemie, vous mourrez si il vous touche"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Règles :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "TD_Mario_ROUSSILLON-Hugo"
        '
        'Boutton_Jouer
        '
        Me.Boutton_Jouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Boutton_Jouer.Font = New System.Drawing.Font("Yu Gothic Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boutton_Jouer.Location = New System.Drawing.Point(288, 379)
        Me.Boutton_Jouer.Name = "Boutton_Jouer"
        Me.Boutton_Jouer.Size = New System.Drawing.Size(135, 59)
        Me.Boutton_Jouer.TabIndex = 24
        Me.Boutton_Jouer.Text = "Jouer"
        Me.Boutton_Jouer.UseVisualStyleBackColor = True
        '
        'Bouton_Fermer
        '
        Me.Bouton_Fermer.Location = New System.Drawing.Point(655, 415)
        Me.Bouton_Fermer.Name = "Bouton_Fermer"
        Me.Bouton_Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Bouton_Fermer.TabIndex = 25
        Me.Bouton_Fermer.Text = "FERMER"
        Me.Bouton_Fermer.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Bouton_Fermer)
        Me.Controls.Add(Me.Boutton_Jouer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Golden_Mario_Expo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Golden_Mushroom_Expo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piece_Expo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowMario_Expo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ShadowMario_Expo As PictureBox
    Friend WithEvents Piece_Expo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Golden_Mario_Expo As PictureBox
    Friend WithEvents Golden_Mushroom_Expo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Boutton_Jouer As Button
    Friend WithEvents Bouton_Fermer As Button
End Class
