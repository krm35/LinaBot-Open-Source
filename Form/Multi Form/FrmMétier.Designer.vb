<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMétier
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.ProgressBarMétier = New System.Windows.Forms.ProgressBar()
        Me.LabelMétier = New System.Windows.Forms.Label()
        Me.CheckBoxRessource = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGratuit = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPayant = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxMetier = New System.Windows.Forms.ComboBox()
        Me.CheckBoxPublic = New System.Windows.Forms.CheckBox()
        Me.ListViewMétier = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBoxMetier = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxMetier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarMétier
        '
        Me.ProgressBarMétier.Location = New System.Drawing.Point(180, 3)
        Me.ProgressBarMétier.Name = "ProgressBarMétier"
        Me.ProgressBarMétier.Size = New System.Drawing.Size(180, 23)
        Me.ProgressBarMétier.TabIndex = 1
        '
        'LabelMétier
        '
        Me.LabelMétier.AutoSize = True
        Me.LabelMétier.ForeColor = System.Drawing.Color.White
        Me.LabelMétier.Location = New System.Drawing.Point(109, 7)
        Me.LabelMétier.Name = "LabelMétier"
        Me.LabelMétier.Size = New System.Drawing.Size(56, 13)
        Me.LabelMétier.TabIndex = 14
        Me.LabelMétier.Text = "Niveau : 0"
        Me.LabelMétier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxRessource
        '
        Me.CheckBoxRessource.AutoSize = True
        Me.CheckBoxRessource.ForeColor = System.Drawing.Color.White
        Me.CheckBoxRessource.Location = New System.Drawing.Point(149, 81)
        Me.CheckBoxRessource.Name = "CheckBoxRessource"
        Me.CheckBoxRessource.Size = New System.Drawing.Size(160, 17)
        Me.CheckBoxRessource.TabIndex = 17
        Me.CheckBoxRessource.Text = "Ne fournit aucune ressource"
        Me.CheckBoxRessource.UseVisualStyleBackColor = True
        '
        'CheckBoxGratuit
        '
        Me.CheckBoxGratuit.AutoSize = True
        Me.CheckBoxGratuit.ForeColor = System.Drawing.Color.White
        Me.CheckBoxGratuit.Location = New System.Drawing.Point(171, 58)
        Me.CheckBoxGratuit.Name = "CheckBoxGratuit"
        Me.CheckBoxGratuit.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxGratuit.TabIndex = 16
        Me.CheckBoxGratuit.Text = "Gratuit sur échec"
        Me.CheckBoxGratuit.UseVisualStyleBackColor = True
        '
        'CheckBoxPayant
        '
        Me.CheckBoxPayant.AutoSize = True
        Me.CheckBoxPayant.ForeColor = System.Drawing.Color.White
        Me.CheckBoxPayant.Location = New System.Drawing.Point(149, 35)
        Me.CheckBoxPayant.Name = "CheckBoxPayant"
        Me.CheckBoxPayant.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxPayant.TabIndex = 15
        Me.CheckBoxPayant.Text = "Payant"
        Me.CheckBoxPayant.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre minimum d'ingrédients                cases"
        '
        'ComboBoxMetier
        '
        Me.ComboBoxMetier.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBoxMetier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMetier.ForeColor = System.Drawing.Color.White
        Me.ComboBoxMetier.FormattingEnabled = True
        Me.ComboBoxMetier.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8"})
        Me.ComboBoxMetier.Location = New System.Drawing.Point(274, 110)
        Me.ComboBoxMetier.Name = "ComboBoxMetier"
        Me.ComboBoxMetier.Size = New System.Drawing.Size(35, 21)
        Me.ComboBoxMetier.TabIndex = 345
        '
        'CheckBoxPublic
        '
        Me.CheckBoxPublic.AutoSize = True
        Me.CheckBoxPublic.ForeColor = System.Drawing.Color.White
        Me.CheckBoxPublic.Location = New System.Drawing.Point(112, 361)
        Me.CheckBoxPublic.Name = "CheckBoxPublic"
        Me.CheckBoxPublic.Size = New System.Drawing.Size(123, 17)
        Me.CheckBoxPublic.TabIndex = 346
        Me.CheckBoxPublic.Text = "Mode Public (Inactif)"
        Me.CheckBoxPublic.UseVisualStyleBackColor = True
        '
        'ListViewMétier
        '
        Me.ListViewMétier.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ListViewMétier.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewMétier.ForeColor = System.Drawing.Color.White
        Me.ListViewMétier.FullRowSelect = True
        Me.ListViewMétier.GridLines = True
        Me.ListViewMétier.HideSelection = False
        Me.ListViewMétier.Location = New System.Drawing.Point(6, 140)
        Me.ListViewMétier.Name = "ListViewMétier"
        Me.ListViewMétier.Size = New System.Drawing.Size(354, 215)
        Me.ListViewMétier.TabIndex = 348
        Me.ListViewMétier.UseCompatibleStateImageBehavior = False
        Me.ListViewMétier.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Action"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Temps/Cases"
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantité/%"
        Me.ColumnHeader4.Width = 67
        '
        'PictureBoxMetier
        '
        Me.PictureBoxMetier.Location = New System.Drawing.Point(4, 3)
        Me.PictureBoxMetier.Name = "PictureBoxMetier"
        Me.PictureBoxMetier.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxMetier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMetier.TabIndex = 349
        Me.PictureBoxMetier.TabStop = False
        '
        'FrmMétier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.PictureBoxMetier)
        Me.Controls.Add(Me.ListViewMétier)
        Me.Controls.Add(Me.CheckBoxPublic)
        Me.Controls.Add(Me.ComboBoxMetier)
        Me.Controls.Add(Me.CheckBoxRessource)
        Me.Controls.Add(Me.CheckBoxGratuit)
        Me.Controls.Add(Me.CheckBoxPayant)
        Me.Controls.Add(Me.LabelMétier)
        Me.Controls.Add(Me.ProgressBarMétier)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMétier"
        Me.Size = New System.Drawing.Size(363, 387)
        CType(Me.PictureBoxMetier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBarMétier As ProgressBar
    Friend WithEvents LabelMétier As Label
    Friend WithEvents CheckBoxRessource As CheckBox
    Friend WithEvents CheckBoxGratuit As CheckBox
    Friend WithEvents CheckBoxPayant As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxMetier As ComboBox
    Friend WithEvents CheckBoxPublic As CheckBox
    Friend WithEvents ListViewMétier As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents PictureBoxMetier As PictureBox
End Class
