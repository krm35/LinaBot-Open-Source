<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LinaBot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinaBot))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PanelAddCompte = New System.Windows.Forms.ToolStripTextBox()
        Me.PanelLoadCompte = New System.Windows.Forms.ToolStripTextBox()
        Me.PanelDeleteCompte = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelAddCompte, Me.PanelLoadCompte, Me.PanelDeleteCompte})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1435, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PanelAddCompte
        '
        Me.PanelAddCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelAddCompte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelAddCompte.ForeColor = System.Drawing.Color.Lime
        Me.PanelAddCompte.Name = "PanelAddCompte"
        Me.PanelAddCompte.Size = New System.Drawing.Size(110, 23)
        Me.PanelAddCompte.Text = "Ajouter un compte"
        '
        'PanelLoadCompte
        '
        Me.PanelLoadCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelLoadCompte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelLoadCompte.ForeColor = System.Drawing.Color.Cyan
        Me.PanelLoadCompte.Name = "PanelLoadCompte"
        Me.PanelLoadCompte.Size = New System.Drawing.Size(120, 23)
        Me.PanelLoadCompte.Text = "Charger un compte"
        '
        'PanelDeleteCompte
        '
        Me.PanelDeleteCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelDeleteCompte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PanelDeleteCompte.ForeColor = System.Drawing.Color.Red
        Me.PanelDeleteCompte.Name = "PanelDeleteCompte"
        Me.PanelDeleteCompte.Size = New System.Drawing.Size(130, 23)
        Me.PanelDeleteCompte.Text = "Supprimer un compte"
        '
        'LinaBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 574)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "LinaBot"
        Me.Text = "Linabot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PanelAddCompte As ToolStripTextBox
    Friend WithEvents PanelLoadCompte As ToolStripTextBox
    Friend WithEvents PanelDeleteCompte As ToolStripTextBox
End Class
