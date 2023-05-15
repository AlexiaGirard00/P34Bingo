<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelCarteBingo = New System.Windows.Forms.Panel()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.gbInitierBingo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMode = New System.Windows.Forms.ComboBox()
        Me.numNbJoueur = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBoulier = New System.Windows.Forms.Panel()
        Me.lblNumBoule = New System.Windows.Forms.Label()
        Me.lblBoulier = New System.Windows.Forms.Label()
        Me.txtBouleOut = New System.Windows.Forms.TextBox()
        Me.gbInitierBingo.SuspendLayout()
        CType(Me.numNbJoueur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBoulier.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCarteBingo
        '
        Me.PanelCarteBingo.Location = New System.Drawing.Point(702, 28)
        Me.PanelCarteBingo.Name = "PanelCarteBingo"
        Me.PanelCarteBingo.Size = New System.Drawing.Size(916, 899)
        Me.PanelCarteBingo.TabIndex = 0
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnJouer.Location = New System.Drawing.Point(133, 205)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(263, 51)
        Me.btnJouer.TabIndex = 1
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'gbInitierBingo
        '
        Me.gbInitierBingo.Controls.Add(Me.Label2)
        Me.gbInitierBingo.Controls.Add(Me.btnJouer)
        Me.gbInitierBingo.Controls.Add(Me.cbMode)
        Me.gbInitierBingo.Controls.Add(Me.numNbJoueur)
        Me.gbInitierBingo.Controls.Add(Me.Label1)
        Me.gbInitierBingo.Location = New System.Drawing.Point(32, 28)
        Me.gbInitierBingo.Name = "gbInitierBingo"
        Me.gbInitierBingo.Size = New System.Drawing.Size(555, 284)
        Me.gbInitierBingo.TabIndex = 3
        Me.gbInitierBingo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mode"
        '
        'cbMode
        '
        Me.cbMode.FormattingEnabled = True
        Me.cbMode.Items.AddRange(New Object() {"Ligne, colonne, diagonale", "Carte pleine", "Quatre coins", "X", "Croix"})
        Me.cbMode.Location = New System.Drawing.Point(215, 132)
        Me.cbMode.Name = "cbMode"
        Me.cbMode.Size = New System.Drawing.Size(242, 40)
        Me.cbMode.TabIndex = 2
        '
        'numNbJoueur
        '
        Me.numNbJoueur.Location = New System.Drawing.Point(298, 51)
        Me.numNbJoueur.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numNbJoueur.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numNbJoueur.Name = "numNbJoueur"
        Me.numNbJoueur.Size = New System.Drawing.Size(159, 39)
        Me.numNbJoueur.TabIndex = 1
        Me.numNbJoueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numNbJoueur.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de joueurs"
        '
        'PanelBoulier
        '
        Me.PanelBoulier.Controls.Add(Me.lblNumBoule)
        Me.PanelBoulier.Controls.Add(Me.lblBoulier)
        Me.PanelBoulier.Controls.Add(Me.txtBouleOut)
        Me.PanelBoulier.Location = New System.Drawing.Point(32, 332)
        Me.PanelBoulier.Name = "PanelBoulier"
        Me.PanelBoulier.Size = New System.Drawing.Size(556, 595)
        Me.PanelBoulier.TabIndex = 5
        '
        'lblNumBoule
        '
        Me.lblNumBoule.AutoSize = True
        Me.lblNumBoule.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNumBoule.Location = New System.Drawing.Point(155, 48)
        Me.lblNumBoule.Name = "lblNumBoule"
        Me.lblNumBoule.Size = New System.Drawing.Size(63, 32)
        Me.lblNumBoule.TabIndex = 2
        Me.lblNumBoule.Text = "num"
        '
        'lblBoulier
        '
        Me.lblBoulier.AutoSize = True
        Me.lblBoulier.Location = New System.Drawing.Point(53, 48)
        Me.lblBoulier.Name = "lblBoulier"
        Me.lblBoulier.Size = New System.Drawing.Size(96, 32)
        Me.lblBoulier.TabIndex = 1
        Me.lblBoulier.Text = "Boule #"
        '
        'txtBouleOut
        '
        Me.txtBouleOut.Location = New System.Drawing.Point(53, 143)
        Me.txtBouleOut.Multiline = True
        Me.txtBouleOut.Name = "txtBouleOut"
        Me.txtBouleOut.ReadOnly = True
        Me.txtBouleOut.Size = New System.Drawing.Size(448, 396)
        Me.txtBouleOut.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1647, 1023)
        Me.Controls.Add(Me.PanelBoulier)
        Me.Controls.Add(Me.gbInitierBingo)
        Me.Controls.Add(Me.PanelCarteBingo)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbInitierBingo.ResumeLayout(False)
        Me.gbInitierBingo.PerformLayout()
        CType(Me.numNbJoueur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBoulier.ResumeLayout(False)
        Me.PanelBoulier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCarteBingo As Panel
    Friend WithEvents btnJouer As Button
    Friend WithEvents gbInitierBingo As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMode As ComboBox
    Friend WithEvents numNbJoueur As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelBoulier As Panel
    Friend WithEvents txtBouleOut As TextBox
    Friend WithEvents lblNumBoule As Label
    Friend WithEvents lblBoulier As Label
End Class
