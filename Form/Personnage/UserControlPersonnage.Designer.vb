<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlPersonnage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlPersonnage))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Initiative", "0", "0", "0", "0", "0"}, 8)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Prospection", "0", "0", "0", "0", "0"}, 9)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Points d'action (PA)", "0", "0", "0", "0", "0"}, 5)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Points de mouvement (PM)", "0", "0", "0", "0", "0"}, 6)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Force", "0", "0", "0", "0", "0"}, 1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Vitalité", "0", "0", "0", "0", "0"}, 10)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sagesse", "0", "0", "0", "0", "0"}, 7)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Chance", "0", "0", "0", "0", "0"}, 4)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Agilité", "0", "0", "0", "0", "0"}, 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Intelligence", "0", "0", "0", "0", "0"}, 2)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Portée (PO)", "0", "0", "0", "0", "0"}, 26)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Maximum de créatures invocables", "0", "0", "0", "0", "0"}, 27)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dégâts", "0", "0", "0", "0", "0"}, 12)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dégâts physique", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus de maîtrise d'arme", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux dommages (%)", "0", "0", "0", "0", "0"}, 13)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux soins", "0", "0", "0", "0", "0"}, 22)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux pièges", "0", "0", "0", "0", "0"}, 16)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux pièges (%)", "0", "0", "0", "0", "0"}, 17)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Renvoi de dommages", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux coups critiques", "0", "0", "0", "0", "0"}, 19)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Bonus aux échecs critiques", "0", "0", "0", "0", "0"}, -1)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Esquive PA", "0", "0", "0", "0", "0"}, 5)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Esquive PM", "0", "0", "0", "0", "0"}, 6)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (Fixe - PVM)", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (% - PVM)", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (Fixe - PVP)", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance neutre (% - PVP)", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (Fixe - PVM)", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (% - PVM)", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (Fixe - PVP)", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance terre (% - PVP)", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (Fixe - PVM)", "0", "0", "0", "0", "0"}, 25)
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (% - PVM)", "0", "0", "0", "0", "0"}, 25)
        Dim ListViewItem35 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (Fixe - PVP)", "0", "0", "0", "0", "0"}, 25)
        Dim ListViewItem36 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance eau (% - PVP)", "0", "0", "0", "0", "0"}, 25)
        Dim ListViewItem37 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (Fixe - PVM)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem38 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (% - PVM)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem39 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (Fixe - PVP)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem40 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance air (% - PVP)", "0", "0", "0", "0", "0"}, 18)
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (Fixe - PVM)", "0", "0", "0", "0", "0"}, 21)
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (% - PVM)", "0", "0", "0", "0", "0"}, 21)
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (Fixe - PVP)", "0", "0", "0", "0", "0"}, 21)
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Résistance feu (% - PVP)", "0", "0", "0", "0", "0"}, 21)
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewItem45 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Vitalité", "0", "0", "0", "0", "0"}, 10)
        Dim ListViewItem46 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sagesse", "0", "0", "0", "0", "0"}, 7)
        Dim ListViewItem47 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Force", "0", "0", "0", "0", "0"}, 1)
        Dim ListViewItem48 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Intelligence", "0", "0", "0", "0", "0"}, 2)
        Dim ListViewItem49 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Chance", "0", "0", "0", "0", "0"}, 4)
        Dim ListViewItem50 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Agilité", "0", "0", "0", "0", "0"}, 0)
        Dim ListViewItem51 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PA", "0", "0", "0", "0", "0"}, 5)
        Dim ListViewItem52 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PM", "0", "0", "0", "0", "0"}, 6)
        Dim ListViewItem53 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"PO", "0", "0", "0", "0", "0"}, 26)
        Dim ListViewItem54 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Créature Invocable", "0", "0", "0", "0", "0"}, 27)
        Dim ListViewItem55 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Initiative", "0", "0", "0", "0", "0"}, 8)
        Dim ListViewItem56 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Prospection", "0", "0", "0", "0", "0"}, 9)
        Dim ListViewItem57 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Pods", "0", "0", "0", "0", "0"}, 15)
        Dim ListViewItem58 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Coups Critiques", "0", "0", "0", "0", "0"}, 19)
        Dim ListViewItem59 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dommage", "0", "0", "0", "0", "0"}, 12)
        Dim ListViewItem60 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Piège", "0", "0", "0", "0", "0"}, 16)
        Dim ListViewItem61 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Dommage", "0", "0", "0", "0", "0"}, 13)
        Dim ListViewItem62 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Piège", "0", "0", "0", "0", "0"}, 17)
        Dim ListViewItem63 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Soins", "0", "0", "0", "0", "0"}, 22)
        Dim ListViewItem64 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Renvoie dommage", "0", "0", "0", "0", "0"}, 24)
        Dim ListViewItem65 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rés Neutre", "0", "0", "0", "0", "0"}, 3)
        Dim ListViewItem66 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rés Terre", "0", "0", "0", "0", "0"}, 1)
        Dim ListViewItem67 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rés Feu", "0", "0", "0", "0", "0"}, 2)
        Dim ListViewItem68 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rés Eau", "0", "0", "0", "0", "0"}, 4)
        Dim ListViewItem69 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rés Air", "0", "0", "0", "0", "0"}, 0)
        Dim ListViewItem70 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Rés Neutre", "0", "0", "0", "0", "0"}, 23)
        Dim ListViewItem71 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Rés Terre", "0", "0", "0", "0", "0"}, 20)
        Dim ListViewItem72 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Rés Feu", "0", "0", "0", "0", "0"}, 21)
        Dim ListViewItem73 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Rés Eau", "0", "0", "0", "0", "0"}, 25)
        Dim ListViewItem74 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"%Rés Air", "0", "0", "0", "0", "0"}, 18)
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TimerStatut = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageTchat = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage_Tchat = New System.Windows.Forms.TabPage()
        Me.TextBoxTchatJoueur = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.LabelMap = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ProgressBarPods = New System.Windows.Forms.ProgressBar()
        Me.RichTextBoxSocket = New System.Windows.Forms.RichTextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ProgressBarEnergie = New System.Windows.Forms.ProgressBar()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ProgressBarVitalite = New System.Windows.Forms.ProgressBar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ProgressBarExperience = New System.Windows.Forms.ProgressBar()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelKamas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelAbonnement = New System.Windows.Forms.Label()
        Me.LabelStatut = New System.Windows.Forms.Label()
        Me.ButtonConnexion = New System.Windows.Forms.Button()
        Me.CheckBox_Canal_Communs_1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Commerce_6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Recrutement_5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Alignement_4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Guilde_3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Groupe_2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Canal_Information_0 = New System.Windows.Forms.CheckBox()
        Me.ComboBoxTchat = New System.Windows.Forms.ComboBox()
        Me.Button_Tchat_Envoyer = New System.Windows.Forms.Button()
        Me.TextBoxTchat = New System.Windows.Forms.TextBox()
        Me.RichTextBoxTchat = New System.Windows.Forms.RichTextBox()
        Me.TabPage_TchatOption = New System.Windows.Forms.TabPage()
        Me.ImageListUser = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageSocket = New System.Windows.Forms.TabPage()
        Me.TabPageCaractéristique = New System.Windows.Forms.TabPage()
        Me.DataGridView_BonusPanoplie = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListViewCaractéristique = New System.Windows.Forms.ListView()
        Me.Caractéristique_Caractéristique = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Base = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Equipement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Dons = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Boost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Caractéristique_Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LabelCaracteristiqueCapital = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelNiveau = New System.Windows.Forms.Label()
        Me.TabPageInventaire = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewInventaire = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripInventaire = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MettreLitemDansLeTchatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéséquiperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtiliserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPageSort = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridViewSort = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LabelSortCapital = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPageMap = New System.Windows.Forms.TabPage()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridViewMapSol = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewMap = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridViewDivers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPageMetier = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelMetier = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageDragodinde = New System.Windows.Forms.TabPage()
        Me.DataGridViewDragodindeEquipé = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewDragodindeEtable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewDragodindeEnclo = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageCraft = New System.Windows.Forms.TabPage()
        Me.ListView_Forgemagie = New System.Windows.Forms.ListView()
        Me.ColumnHeader194 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader195 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader196 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader197 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader198 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataGridViewMoi = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewLui = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerRegeneration = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageTchat.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage_Tchat.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCaractéristique.SuspendLayout()
        CType(Me.DataGridView_BonusPanoplie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageInventaire.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewInventaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripInventaire.SuspendLayout()
        Me.TabPageSort.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMap.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridViewMapSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridViewDivers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMetier.SuspendLayout()
        Me.TabPageDragodinde.SuspendLayout()
        CType(Me.DataGridViewDragodindeEquipé, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDragodindeEtable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDragodindeEnclo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCraft.SuspendLayout()
        CType(Me.DataGridViewMoi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerStatut
        '
        Me.TimerStatut.Enabled = True
        Me.TimerStatut.Interval = 1000
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageTchat)
        Me.TabControl1.Controls.Add(Me.TabPageSocket)
        Me.TabControl1.Controls.Add(Me.TabPageCaractéristique)
        Me.TabControl1.Controls.Add(Me.TabPageInventaire)
        Me.TabControl1.Controls.Add(Me.TabPageSort)
        Me.TabControl1.Controls.Add(Me.TabPageMap)
        Me.TabControl1.Controls.Add(Me.TabPageMetier)
        Me.TabControl1.Controls.Add(Me.TabPageDragodinde)
        Me.TabControl1.Controls.Add(Me.TabPageCraft)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.ImageList = Me.ImageListUser
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1865, 851)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageTchat
        '
        Me.TabPageTchat.AutoScroll = True
        Me.TabPageTchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageTchat.Controls.Add(Me.TabControl2)
        Me.TabPageTchat.ImageIndex = 0
        Me.TabPageTchat.Location = New System.Drawing.Point(4, 47)
        Me.TabPageTchat.Name = "TabPageTchat"
        Me.TabPageTchat.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTchat.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageTchat.TabIndex = 0
        Me.TabPageTchat.Text = "Tchat"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage_Tchat)
        Me.TabControl2.Controls.Add(Me.TabPage_TchatOption)
        Me.TabControl2.ImageList = Me.ImageListUser
        Me.TabControl2.Location = New System.Drawing.Point(6, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1845, 788)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage_Tchat
        '
        Me.TabPage_Tchat.AutoScroll = True
        Me.TabPage_Tchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_Tchat.Controls.Add(Me.Button2)
        Me.TabPage_Tchat.Controls.Add(Me.TextBoxTchatJoueur)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox10)
        Me.TabPage_Tchat.Controls.Add(Me.LabelMap)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox9)
        Me.TabPage_Tchat.Controls.Add(Me.ProgressBarPods)
        Me.TabPage_Tchat.Controls.Add(Me.RichTextBoxSocket)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox8)
        Me.TabPage_Tchat.Controls.Add(Me.ProgressBarEnergie)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox5)
        Me.TabPage_Tchat.Controls.Add(Me.ProgressBarVitalite)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox4)
        Me.TabPage_Tchat.Controls.Add(Me.ProgressBarExperience)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox3)
        Me.TabPage_Tchat.Controls.Add(Me.LabelKamas)
        Me.TabPage_Tchat.Controls.Add(Me.PictureBox1)
        Me.TabPage_Tchat.Controls.Add(Me.LabelAbonnement)
        Me.TabPage_Tchat.Controls.Add(Me.LabelStatut)
        Me.TabPage_Tchat.Controls.Add(Me.ButtonConnexion)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Communs_1)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Commerce_6)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Recrutement_5)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Alignement_4)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Guilde_3)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Groupe_2)
        Me.TabPage_Tchat.Controls.Add(Me.CheckBox_Canal_Information_0)
        Me.TabPage_Tchat.Controls.Add(Me.ComboBoxTchat)
        Me.TabPage_Tchat.Controls.Add(Me.Button_Tchat_Envoyer)
        Me.TabPage_Tchat.Controls.Add(Me.TextBoxTchat)
        Me.TabPage_Tchat.Controls.Add(Me.RichTextBoxTchat)
        Me.TabPage_Tchat.ImageIndex = 0
        Me.TabPage_Tchat.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_Tchat.Name = "TabPage_Tchat"
        Me.TabPage_Tchat.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Tchat.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage_Tchat.TabIndex = 0
        Me.TabPage_Tchat.Text = "Tchat"
        '
        'TextBoxTchatJoueur
        '
        Me.TextBoxTchatJoueur.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextBoxTchatJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTchatJoueur.ForeColor = System.Drawing.Color.White
        Me.TextBoxTchatJoueur.Location = New System.Drawing.Point(162, 708)
        Me.TextBoxTchatJoueur.MaxLength = 199
        Me.TextBoxTchatJoueur.Name = "TextBoxTchatJoueur"
        Me.TextBoxTchatJoueur.Size = New System.Drawing.Size(86, 22)
        Me.TextBoxTchatJoueur.TabIndex = 370
        Me.TextBoxTchatJoueur.Text = "Nom Joueur"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(1620, 193)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(211, 33)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 369
        Me.PictureBox10.TabStop = False
        '
        'LabelMap
        '
        Me.LabelMap.AutoSize = True
        Me.LabelMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMap.ForeColor = System.Drawing.Color.White
        Me.LabelMap.Location = New System.Drawing.Point(1689, 229)
        Me.LabelMap.Name = "LabelMap"
        Me.LabelMap.Size = New System.Drawing.Size(77, 24)
        Me.LabelMap.TabIndex = 368
        Me.LabelMap.Text = "[XX,YY]"
        Me.LabelMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(1620, 373)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 367
        Me.PictureBox9.TabStop = False
        '
        'ProgressBarPods
        '
        Me.ProgressBarPods.Location = New System.Drawing.Point(1668, 373)
        Me.ProgressBarPods.Name = "ProgressBarPods"
        Me.ProgressBarPods.Size = New System.Drawing.Size(163, 33)
        Me.ProgressBarPods.TabIndex = 366
        '
        'RichTextBoxSocket
        '
        Me.RichTextBoxSocket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxSocket.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RichTextBoxSocket.Location = New System.Drawing.Point(6, 346)
        Me.RichTextBoxSocket.Name = "RichTextBoxSocket"
        Me.RichTextBoxSocket.Size = New System.Drawing.Size(1608, 356)
        Me.RichTextBoxSocket.TabIndex = 364
        Me.RichTextBoxSocket.Text = ""
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1620, 334)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 363
        Me.PictureBox8.TabStop = False
        '
        'ProgressBarEnergie
        '
        Me.ProgressBarEnergie.Location = New System.Drawing.Point(1668, 334)
        Me.ProgressBarEnergie.Name = "ProgressBarEnergie"
        Me.ProgressBarEnergie.Size = New System.Drawing.Size(163, 33)
        Me.ProgressBarEnergie.TabIndex = 362
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1620, 256)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 361
        Me.PictureBox5.TabStop = False
        '
        'ProgressBarVitalite
        '
        Me.ProgressBarVitalite.Location = New System.Drawing.Point(1668, 256)
        Me.ProgressBarVitalite.Name = "ProgressBarVitalite"
        Me.ProgressBarVitalite.Size = New System.Drawing.Size(163, 33)
        Me.ProgressBarVitalite.TabIndex = 360
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1620, 295)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 359
        Me.PictureBox4.TabStop = False
        '
        'ProgressBarExperience
        '
        Me.ProgressBarExperience.Location = New System.Drawing.Point(1668, 295)
        Me.ProgressBarExperience.Name = "ProgressBarExperience"
        Me.ProgressBarExperience.Size = New System.Drawing.Size(163, 33)
        Me.ProgressBarExperience.TabIndex = 358
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1620, 130)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(211, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 357
        Me.PictureBox3.TabStop = False
        '
        'LabelKamas
        '
        Me.LabelKamas.AutoSize = True
        Me.LabelKamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKamas.ForeColor = System.Drawing.Color.White
        Me.LabelKamas.Location = New System.Drawing.Point(1718, 166)
        Me.LabelKamas.Name = "LabelKamas"
        Me.LabelKamas.Size = New System.Drawing.Size(20, 24)
        Me.LabelKamas.TabIndex = 356
        Me.LabelKamas.Text = "0"
        Me.LabelKamas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1620, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 355
        Me.PictureBox1.TabStop = False
        '
        'LabelAbonnement
        '
        Me.LabelAbonnement.AutoSize = True
        Me.LabelAbonnement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbonnement.ForeColor = System.Drawing.Color.White
        Me.LabelAbonnement.Location = New System.Drawing.Point(1682, 92)
        Me.LabelAbonnement.Name = "LabelAbonnement"
        Me.LabelAbonnement.Size = New System.Drawing.Size(84, 32)
        Me.LabelAbonnement.TabIndex = 354
        Me.LabelAbonnement.Text = "XX/YY/XXYY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "xxhyymxys"
        Me.LabelAbonnement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelStatut
        '
        Me.LabelStatut.AutoSize = True
        Me.LabelStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatut.ForeColor = System.Drawing.Color.Red
        Me.LabelStatut.Location = New System.Drawing.Point(1682, 34)
        Me.LabelStatut.Name = "LabelStatut"
        Me.LabelStatut.Size = New System.Drawing.Size(81, 16)
        Me.LabelStatut.TabIndex = 353
        Me.LabelStatut.Text = "Déconnecté"
        Me.LabelStatut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonConnexion
        '
        Me.ButtonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConnexion.ForeColor = System.Drawing.Color.White
        Me.ButtonConnexion.Location = New System.Drawing.Point(1620, 6)
        Me.ButtonConnexion.Name = "ButtonConnexion"
        Me.ButtonConnexion.Size = New System.Drawing.Size(211, 23)
        Me.ButtonConnexion.TabIndex = 352
        Me.ButtonConnexion.Text = "Connexion"
        Me.ButtonConnexion.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Communs_1
        '
        Me.CheckBox_Canal_Communs_1.AutoSize = True
        Me.CheckBox_Canal_Communs_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Communs_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Communs_1.ForeColor = System.Drawing.Color.White
        Me.CheckBox_Canal_Communs_1.Location = New System.Drawing.Point(1642, 546)
        Me.CheckBox_Canal_Communs_1.Name = "CheckBox_Canal_Communs_1"
        Me.CheckBox_Canal_Communs_1.Size = New System.Drawing.Size(89, 24)
        Me.CheckBox_Canal_Communs_1.TabIndex = 351
        Me.CheckBox_Canal_Communs_1.Text = "Commun"
        Me.CheckBox_Canal_Communs_1.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Commerce_6
        '
        Me.CheckBox_Canal_Commerce_6.AutoSize = True
        Me.CheckBox_Canal_Commerce_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Commerce_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Commerce_6.ForeColor = System.Drawing.Color.Sienna
        Me.CheckBox_Canal_Commerce_6.Location = New System.Drawing.Point(1642, 696)
        Me.CheckBox_Canal_Commerce_6.Name = "CheckBox_Canal_Commerce_6"
        Me.CheckBox_Canal_Commerce_6.Size = New System.Drawing.Size(102, 24)
        Me.CheckBox_Canal_Commerce_6.TabIndex = 350
        Me.CheckBox_Canal_Commerce_6.Text = "Commerce"
        Me.CheckBox_Canal_Commerce_6.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Recrutement_5
        '
        Me.CheckBox_Canal_Recrutement_5.AutoSize = True
        Me.CheckBox_Canal_Recrutement_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Recrutement_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Recrutement_5.ForeColor = System.Drawing.Color.Gray
        Me.CheckBox_Canal_Recrutement_5.Location = New System.Drawing.Point(1642, 666)
        Me.CheckBox_Canal_Recrutement_5.Name = "CheckBox_Canal_Recrutement_5"
        Me.CheckBox_Canal_Recrutement_5.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox_Canal_Recrutement_5.TabIndex = 349
        Me.CheckBox_Canal_Recrutement_5.Text = "Recrutement"
        Me.CheckBox_Canal_Recrutement_5.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Alignement_4
        '
        Me.CheckBox_Canal_Alignement_4.AutoSize = True
        Me.CheckBox_Canal_Alignement_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Alignement_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Alignement_4.ForeColor = System.Drawing.Color.Orange
        Me.CheckBox_Canal_Alignement_4.Location = New System.Drawing.Point(1642, 636)
        Me.CheckBox_Canal_Alignement_4.Name = "CheckBox_Canal_Alignement_4"
        Me.CheckBox_Canal_Alignement_4.Size = New System.Drawing.Size(105, 24)
        Me.CheckBox_Canal_Alignement_4.TabIndex = 348
        Me.CheckBox_Canal_Alignement_4.Text = "Alignement"
        Me.CheckBox_Canal_Alignement_4.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Guilde_3
        '
        Me.CheckBox_Canal_Guilde_3.AutoSize = True
        Me.CheckBox_Canal_Guilde_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Guilde_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Guilde_3.ForeColor = System.Drawing.Color.Violet
        Me.CheckBox_Canal_Guilde_3.Location = New System.Drawing.Point(1642, 606)
        Me.CheckBox_Canal_Guilde_3.Name = "CheckBox_Canal_Guilde_3"
        Me.CheckBox_Canal_Guilde_3.Size = New System.Drawing.Size(71, 24)
        Me.CheckBox_Canal_Guilde_3.TabIndex = 347
        Me.CheckBox_Canal_Guilde_3.Text = "Guilde"
        Me.CheckBox_Canal_Guilde_3.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Groupe_2
        '
        Me.CheckBox_Canal_Groupe_2.AutoSize = True
        Me.CheckBox_Canal_Groupe_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Groupe_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Groupe_2.ForeColor = System.Drawing.Color.Cyan
        Me.CheckBox_Canal_Groupe_2.Location = New System.Drawing.Point(1642, 576)
        Me.CheckBox_Canal_Groupe_2.Name = "CheckBox_Canal_Groupe_2"
        Me.CheckBox_Canal_Groupe_2.Size = New System.Drawing.Size(79, 24)
        Me.CheckBox_Canal_Groupe_2.TabIndex = 346
        Me.CheckBox_Canal_Groupe_2.Text = "Groupe"
        Me.CheckBox_Canal_Groupe_2.UseVisualStyleBackColor = True
        '
        'CheckBox_Canal_Information_0
        '
        Me.CheckBox_Canal_Information_0.AutoSize = True
        Me.CheckBox_Canal_Information_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Canal_Information_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Canal_Information_0.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox_Canal_Information_0.Location = New System.Drawing.Point(1642, 516)
        Me.CheckBox_Canal_Information_0.Name = "CheckBox_Canal_Information_0"
        Me.CheckBox_Canal_Information_0.Size = New System.Drawing.Size(106, 24)
        Me.CheckBox_Canal_Information_0.TabIndex = 345
        Me.CheckBox_Canal_Information_0.Text = "Information"
        Me.CheckBox_Canal_Information_0.UseVisualStyleBackColor = True
        '
        'ComboBoxTchat
        '
        Me.ComboBoxTchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBoxTchat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTchat.ForeColor = System.Drawing.Color.White
        Me.ComboBoxTchat.FormattingEnabled = True
        Me.ComboBoxTchat.Items.AddRange(New Object() {"Commun", "Message privée", "Groupe", "Equipe", "Guilde", "Alignement", "Recrutement", "Commerce"})
        Me.ComboBoxTchat.Location = New System.Drawing.Point(6, 708)
        Me.ComboBoxTchat.Name = "ComboBoxTchat"
        Me.ComboBoxTchat.Size = New System.Drawing.Size(150, 21)
        Me.ComboBoxTchat.TabIndex = 344
        '
        'Button_Tchat_Envoyer
        '
        Me.Button_Tchat_Envoyer.BackgroundImage = CType(resources.GetObject("Button_Tchat_Envoyer.BackgroundImage"), System.Drawing.Image)
        Me.Button_Tchat_Envoyer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_Tchat_Envoyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Tchat_Envoyer.Location = New System.Drawing.Point(1589, 706)
        Me.Button_Tchat_Envoyer.Name = "Button_Tchat_Envoyer"
        Me.Button_Tchat_Envoyer.Size = New System.Drawing.Size(25, 25)
        Me.Button_Tchat_Envoyer.TabIndex = 7
        Me.Button_Tchat_Envoyer.UseVisualStyleBackColor = True
        '
        'TextBoxTchat
        '
        Me.TextBoxTchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextBoxTchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTchat.ForeColor = System.Drawing.Color.White
        Me.TextBoxTchat.Location = New System.Drawing.Point(254, 708)
        Me.TextBoxTchat.MaxLength = 199
        Me.TextBoxTchat.Name = "TextBoxTchat"
        Me.TextBoxTchat.Size = New System.Drawing.Size(1329, 22)
        Me.TextBoxTchat.TabIndex = 4
        Me.TextBoxTchat.Text = "Votre message ici."
        Me.TextBoxTchat.WordWrap = False
        '
        'RichTextBoxTchat
        '
        Me.RichTextBoxTchat.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RichTextBoxTchat.ForeColor = System.Drawing.Color.White
        Me.RichTextBoxTchat.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBoxTchat.Name = "RichTextBoxTchat"
        Me.RichTextBoxTchat.Size = New System.Drawing.Size(1608, 334)
        Me.RichTextBoxTchat.TabIndex = 3
        Me.RichTextBoxTchat.Text = ""
        '
        'TabPage_TchatOption
        '
        Me.TabPage_TchatOption.AutoScroll = True
        Me.TabPage_TchatOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage_TchatOption.ImageIndex = 2
        Me.TabPage_TchatOption.Location = New System.Drawing.Point(4, 47)
        Me.TabPage_TchatOption.Name = "TabPage_TchatOption"
        Me.TabPage_TchatOption.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_TchatOption.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage_TchatOption.TabIndex = 1
        Me.TabPage_TchatOption.Text = "Option"
        '
        'ImageListUser
        '
        Me.ImageListUser.ImageStream = CType(resources.GetObject("ImageListUser.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListUser.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListUser.Images.SetKeyName(0, "Tchat.png")
        Me.ImageListUser.Images.SetKeyName(1, "Console.png")
        Me.ImageListUser.Images.SetKeyName(2, "Option.png")
        Me.ImageListUser.Images.SetKeyName(3, "1294.png")
        Me.ImageListUser.Images.SetKeyName(4, "1292.png")
        Me.ImageListUser.Images.SetKeyName(5, "1296.png")
        Me.ImageListUser.Images.SetKeyName(6, "56px-Rose.png")
        Me.ImageListUser.Images.SetKeyName(7, "plant-leaf.png")
        Me.ImageListUser.Images.SetKeyName(8, "22003.png")
        Me.ImageListUser.Images.SetKeyName(9, "Alchimiste.png")
        Me.ImageListUser.Images.SetKeyName(10, "Bijoutier.png")
        Me.ImageListUser.Images.SetKeyName(11, "Boucher.png")
        Me.ImageListUser.Images.SetKeyName(12, "Boulanger.png")
        Me.ImageListUser.Images.SetKeyName(13, "Bricoleur.png")
        Me.ImageListUser.Images.SetKeyName(14, "Bûcheron.png")
        Me.ImageListUser.Images.SetKeyName(15, "Chasseur.png")
        Me.ImageListUser.Images.SetKeyName(16, "Cordomage.png")
        Me.ImageListUser.Images.SetKeyName(17, "Cordonnier.png")
        Me.ImageListUser.Images.SetKeyName(18, "Costumage.png")
        Me.ImageListUser.Images.SetKeyName(19, "Forgemage de Dagues.png")
        Me.ImageListUser.Images.SetKeyName(20, "Forgemage de Haches.png")
        Me.ImageListUser.Images.SetKeyName(21, "Forgemage de Marteaux.png")
        Me.ImageListUser.Images.SetKeyName(22, "Forgemage de Pelles.png")
        Me.ImageListUser.Images.SetKeyName(23, "Forgemage d'Épées.png")
        Me.ImageListUser.Images.SetKeyName(24, "Forgeur de Bouclier.png")
        Me.ImageListUser.Images.SetKeyName(25, "Forgeur de dagues.png")
        Me.ImageListUser.Images.SetKeyName(26, "Forgeur de Haches.png")
        Me.ImageListUser.Images.SetKeyName(27, "Forgeur de Marteau.png")
        Me.ImageListUser.Images.SetKeyName(28, "Forgeur de pelle.png")
        Me.ImageListUser.Images.SetKeyName(29, "Forgeur d'épée.png")
        Me.ImageListUser.Images.SetKeyName(30, "Joaillomage.png")
        Me.ImageListUser.Images.SetKeyName(31, "Mineur.png")
        Me.ImageListUser.Images.SetKeyName(32, "Paysan.png")
        Me.ImageListUser.Images.SetKeyName(33, "Pêcheur.png")
        Me.ImageListUser.Images.SetKeyName(34, "Poissonnier.png")
        Me.ImageListUser.Images.SetKeyName(35, "Sculptemage d'Arcs.png")
        Me.ImageListUser.Images.SetKeyName(36, "Sculptemage de Baguettes.png")
        Me.ImageListUser.Images.SetKeyName(37, "Sculptemage de Bâtons.png")
        Me.ImageListUser.Images.SetKeyName(38, "Sculpteur d'arc.png")
        Me.ImageListUser.Images.SetKeyName(39, "Sculpteur de baguette.png")
        Me.ImageListUser.Images.SetKeyName(40, "Sculpteur de bâton.png")
        Me.ImageListUser.Images.SetKeyName(41, "Tailleur.png")
        Me.ImageListUser.Images.SetKeyName(42, "2200.png")
        Me.ImageListUser.Images.SetKeyName(43, "Marteau.png")
        '
        'TabPageSocket
        '
        Me.TabPageSocket.AutoScroll = True
        Me.TabPageSocket.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageSocket.ImageIndex = 1
        Me.TabPageSocket.Location = New System.Drawing.Point(4, 47)
        Me.TabPageSocket.Name = "TabPageSocket"
        Me.TabPageSocket.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSocket.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageSocket.TabIndex = 1
        Me.TabPageSocket.Text = "Socket"
        '
        'TabPageCaractéristique
        '
        Me.TabPageCaractéristique.AutoScroll = True
        Me.TabPageCaractéristique.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageCaractéristique.Controls.Add(Me.DataGridView_BonusPanoplie)
        Me.TabPageCaractéristique.Controls.Add(Me.ListViewCaractéristique)
        Me.TabPageCaractéristique.Controls.Add(Me.PictureBox6)
        Me.TabPageCaractéristique.Controls.Add(Me.LabelCaracteristiqueCapital)
        Me.TabPageCaractéristique.Controls.Add(Me.PictureBox2)
        Me.TabPageCaractéristique.Controls.Add(Me.LabelNiveau)
        Me.TabPageCaractéristique.ImageIndex = 3
        Me.TabPageCaractéristique.Location = New System.Drawing.Point(4, 47)
        Me.TabPageCaractéristique.Name = "TabPageCaractéristique"
        Me.TabPageCaractéristique.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCaractéristique.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageCaractéristique.TabIndex = 2
        Me.TabPageCaractéristique.Text = "Caractéristique"
        '
        'DataGridView_BonusPanoplie
        '
        Me.DataGridView_BonusPanoplie.AllowUserToAddRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_BonusPanoplie.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_BonusPanoplie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_BonusPanoplie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_BonusPanoplie.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_BonusPanoplie.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_BonusPanoplie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_BonusPanoplie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DataGridView_BonusPanoplie.GridColor = System.Drawing.Color.Black
        Me.DataGridView_BonusPanoplie.Location = New System.Drawing.Point(436, 6)
        Me.DataGridView_BonusPanoplie.MultiSelect = False
        Me.DataGridView_BonusPanoplie.Name = "DataGridView_BonusPanoplie"
        Me.DataGridView_BonusPanoplie.RowHeadersWidth = 4
        Me.DataGridView_BonusPanoplie.Size = New System.Drawing.Size(353, 788)
        Me.DataGridView_BonusPanoplie.TabIndex = 364
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Id Panoplie"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Width = 83
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nom Objet"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 83
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'ListViewCaractéristique
        '
        Me.ListViewCaractéristique.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ListViewCaractéristique.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Caractéristique_Caractéristique, Me.Caractéristique_Base, Me.Caractéristique_Equipement, Me.Caractéristique_Dons, Me.Caractéristique_Boost, Me.Caractéristique_Total})
        Me.ListViewCaractéristique.ForeColor = System.Drawing.Color.White
        Me.ListViewCaractéristique.FullRowSelect = True
        Me.ListViewCaractéristique.GridLines = True
        Me.ListViewCaractéristique.HideSelection = False
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        ListViewItem25.StateImageIndex = 0
        ListViewItem26.StateImageIndex = 0
        ListViewItem27.StateImageIndex = 0
        ListViewItem28.StateImageIndex = 0
        ListViewItem29.StateImageIndex = 0
        ListViewItem30.StateImageIndex = 0
        ListViewItem31.StateImageIndex = 0
        ListViewItem32.StateImageIndex = 0
        ListViewItem33.StateImageIndex = 0
        ListViewItem34.StateImageIndex = 0
        ListViewItem35.StateImageIndex = 0
        ListViewItem36.StateImageIndex = 0
        ListViewItem37.StateImageIndex = 0
        ListViewItem38.StateImageIndex = 0
        ListViewItem39.StateImageIndex = 0
        ListViewItem40.StateImageIndex = 0
        ListViewItem41.StateImageIndex = 0
        ListViewItem42.StateImageIndex = 0
        ListViewItem43.StateImageIndex = 0
        ListViewItem44.StateImageIndex = 0
        Me.ListViewCaractéristique.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34, ListViewItem35, ListViewItem36, ListViewItem37, ListViewItem38, ListViewItem39, ListViewItem40, ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44})
        Me.ListViewCaractéristique.Location = New System.Drawing.Point(6, 6)
        Me.ListViewCaractéristique.Name = "ListViewCaractéristique"
        Me.ListViewCaractéristique.Size = New System.Drawing.Size(424, 788)
        Me.ListViewCaractéristique.SmallImageList = Me.ImageList1
        Me.ListViewCaractéristique.TabIndex = 360
        Me.ListViewCaractéristique.UseCompatibleStateImageBehavior = False
        Me.ListViewCaractéristique.View = System.Windows.Forms.View.Details
        '
        'Caractéristique_Caractéristique
        '
        Me.Caractéristique_Caractéristique.Text = "Caractéristique"
        Me.Caractéristique_Caractéristique.Width = 193
        '
        'Caractéristique_Base
        '
        Me.Caractéristique_Base.Text = "Base"
        Me.Caractéristique_Base.Width = 42
        '
        'Caractéristique_Equipement
        '
        Me.Caractéristique_Equipement.Text = "Equipement"
        Me.Caractéristique_Equipement.Width = 68
        '
        'Caractéristique_Dons
        '
        Me.Caractéristique_Dons.Text = "Dons"
        Me.Caractéristique_Dons.Width = 37
        '
        'Caractéristique_Boost
        '
        Me.Caractéristique_Boost.Text = "Boost"
        Me.Caractéristique_Boost.Width = 39
        '
        'Caractéristique_Total
        '
        Me.Caractéristique_Total.Text = "Total"
        Me.Caractéristique_Total.Width = 41
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1 (2).png")
        Me.ImageList1.Images.SetKeyName(1, "1 (3).png")
        Me.ImageList1.Images.SetKeyName(2, "1 (4).png")
        Me.ImageList1.Images.SetKeyName(3, "1 (5).png")
        Me.ImageList1.Images.SetKeyName(4, "1.png")
        Me.ImageList1.Images.SetKeyName(5, "1151.png")
        Me.ImageList1.Images.SetKeyName(6, "1155.png")
        Me.ImageList1.Images.SetKeyName(7, "2182.png")
        Me.ImageList1.Images.SetKeyName(8, "2184.png")
        Me.ImageList1.Images.SetKeyName(9, "2186.png")
        Me.ImageList1.Images.SetKeyName(10, "2188.png")
        Me.ImageList1.Images.SetKeyName(11, "78014.png")
        Me.ImageList1.Images.SetKeyName(12, "78015.png")
        Me.ImageList1.Images.SetKeyName(13, "78016.png")
        Me.ImageList1.Images.SetKeyName(14, "78019.png")
        Me.ImageList1.Images.SetKeyName(15, "78020.png")
        Me.ImageList1.Images.SetKeyName(16, "78023.png")
        Me.ImageList1.Images.SetKeyName(17, "78024.png")
        Me.ImageList1.Images.SetKeyName(18, "Air_square.png")
        Me.ImageList1.Images.SetKeyName(19, "Critical_Hit.png")
        Me.ImageList1.Images.SetKeyName(20, "Earth_square.png")
        Me.ImageList1.Images.SetKeyName(21, "Fire_square.png")
        Me.ImageList1.Images.SetKeyName(22, "Heals.png")
        Me.ImageList1.Images.SetKeyName(23, "Neutral_square.png")
        Me.ImageList1.Images.SetKeyName(24, "Power.png")
        Me.ImageList1.Images.SetKeyName(25, "Water_square.png")
        Me.ImageList1.Images.SetKeyName(26, "Range.png")
        Me.ImageList1.Images.SetKeyName(27, "Summon.png")
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(795, 45)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 359
        Me.PictureBox6.TabStop = False
        '
        'LabelCaracteristiqueCapital
        '
        Me.LabelCaracteristiqueCapital.AutoSize = True
        Me.LabelCaracteristiqueCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaracteristiqueCapital.ForeColor = System.Drawing.Color.White
        Me.LabelCaracteristiqueCapital.Location = New System.Drawing.Point(836, 54)
        Me.LabelCaracteristiqueCapital.Name = "LabelCaracteristiqueCapital"
        Me.LabelCaracteristiqueCapital.Size = New System.Drawing.Size(66, 16)
        Me.LabelCaracteristiqueCapital.TabIndex = 358
        Me.LabelCaracteristiqueCapital.Text = "Capital : 0"
        Me.LabelCaracteristiqueCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(795, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 357
        Me.PictureBox2.TabStop = False
        '
        'LabelNiveau
        '
        Me.LabelNiveau.AutoSize = True
        Me.LabelNiveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNiveau.ForeColor = System.Drawing.Color.White
        Me.LabelNiveau.Location = New System.Drawing.Point(836, 15)
        Me.LabelNiveau.Name = "LabelNiveau"
        Me.LabelNiveau.Size = New System.Drawing.Size(67, 16)
        Me.LabelNiveau.TabIndex = 356
        Me.LabelNiveau.Text = "Niveau : 0"
        Me.LabelNiveau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageInventaire
        '
        Me.TabPageInventaire.AutoScroll = True
        Me.TabPageInventaire.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageInventaire.Controls.Add(Me.TabControl3)
        Me.TabPageInventaire.ImageIndex = 4
        Me.TabPageInventaire.Location = New System.Drawing.Point(4, 47)
        Me.TabPageInventaire.Name = "TabPageInventaire"
        Me.TabPageInventaire.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInventaire.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageInventaire.TabIndex = 3
        Me.TabPageInventaire.Text = "Inventaire"
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.ImageList = Me.ImageListUser
        Me.TabControl3.Location = New System.Drawing.Point(6, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1845, 788)
        Me.TabControl3.TabIndex = 363
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridViewInventaire)
        Me.TabPage1.ImageIndex = 4
        Me.TabPage1.Location = New System.Drawing.Point(4, 47)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventaire"
        '
        'DataGridViewInventaire
        '
        Me.DataGridViewInventaire.AllowUserToAddRows = False
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInventaire.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewInventaire.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInventaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewInventaire.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInventaire.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventaire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridViewInventaire.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewInventaire.GridColor = System.Drawing.Color.Black
        Me.DataGridViewInventaire.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewInventaire.MultiSelect = False
        Me.DataGridViewInventaire.Name = "DataGridViewInventaire"
        Me.DataGridViewInventaire.RowHeadersWidth = 4
        Me.DataGridViewInventaire.Size = New System.Drawing.Size(1825, 725)
        Me.DataGridViewInventaire.TabIndex = 362
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID Objet"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 86
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID Unique"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 96
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nom"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Quantité"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 88
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Information"
        Me.Column5.Name = "Column5"
        '
        'ContextMenuStripInventaire
        '
        Me.ContextMenuStripInventaire.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MettreLitemDansLeTchatToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.EquipéToolStripMenuItem, Me.DéséquiperToolStripMenuItem, Me.UtiliserToolStripMenuItem})
        Me.ContextMenuStripInventaire.Name = "ContextMenuStripInventaire"
        Me.ContextMenuStripInventaire.Size = New System.Drawing.Size(214, 114)
        '
        'MettreLitemDansLeTchatToolStripMenuItem
        '
        Me.MettreLitemDansLeTchatToolStripMenuItem.Image = CType(resources.GetObject("MettreLitemDansLeTchatToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MettreLitemDansLeTchatToolStripMenuItem.Name = "MettreLitemDansLeTchatToolStripMenuItem"
        Me.MettreLitemDansLeTchatToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MettreLitemDansLeTchatToolStripMenuItem.Text = "Mettre l'item dans le Tchat"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = CType(resources.GetObject("SupprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'EquipéToolStripMenuItem
        '
        Me.EquipéToolStripMenuItem.Image = CType(resources.GetObject("EquipéToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EquipéToolStripMenuItem.Name = "EquipéToolStripMenuItem"
        Me.EquipéToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EquipéToolStripMenuItem.Text = "Equiper"
        '
        'DéséquiperToolStripMenuItem
        '
        Me.DéséquiperToolStripMenuItem.Image = CType(resources.GetObject("DéséquiperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DéséquiperToolStripMenuItem.Name = "DéséquiperToolStripMenuItem"
        Me.DéséquiperToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DéséquiperToolStripMenuItem.Text = "Déséquiper"
        '
        'UtiliserToolStripMenuItem
        '
        Me.UtiliserToolStripMenuItem.Image = CType(resources.GetObject("UtiliserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UtiliserToolStripMenuItem.Name = "UtiliserToolStripMenuItem"
        Me.UtiliserToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.UtiliserToolStripMenuItem.Text = "Utiliser"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage2.ImageIndex = 2
        Me.TabPage2.Location = New System.Drawing.Point(4, 47)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Option"
        '
        'TabPageSort
        '
        Me.TabPageSort.AutoScroll = True
        Me.TabPageSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageSort.Controls.Add(Me.TabControl4)
        Me.TabPageSort.ImageIndex = 5
        Me.TabPageSort.Location = New System.Drawing.Point(4, 47)
        Me.TabPageSort.Name = "TabPageSort"
        Me.TabPageSort.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSort.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageSort.TabIndex = 4
        Me.TabPageSort.Text = "Sort"
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage3)
        Me.TabControl4.Controls.Add(Me.TabPage4)
        Me.TabControl4.ImageList = Me.ImageListUser
        Me.TabControl4.Location = New System.Drawing.Point(6, 6)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(1845, 788)
        Me.TabControl4.TabIndex = 364
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.DataGridViewSort)
        Me.TabPage3.Controls.Add(Me.PictureBox7)
        Me.TabPage3.Controls.Add(Me.LabelSortCapital)
        Me.TabPage3.ImageIndex = 5
        Me.TabPage3.Location = New System.Drawing.Point(4, 47)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Sort"
        '
        'DataGridViewSort
        '
        Me.DataGridViewSort.AllowUserToAddRows = False
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSort.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewSort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSort.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewSort.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSort.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSort.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column6})
        Me.DataGridViewSort.GridColor = System.Drawing.Color.Black
        Me.DataGridViewSort.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewSort.MultiSelect = False
        Me.DataGridViewSort.Name = "DataGridViewSort"
        Me.DataGridViewSort.RowHeadersWidth = 4
        Me.DataGridViewSort.Size = New System.Drawing.Size(1700, 725)
        Me.DataGridViewSort.TabIndex = 362
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Sort"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 64
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Niveau"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Description"
        Me.Column6.Name = "Column6"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1754, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 361
        Me.PictureBox7.TabStop = False
        '
        'LabelSortCapital
        '
        Me.LabelSortCapital.AutoSize = True
        Me.LabelSortCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSortCapital.ForeColor = System.Drawing.Color.White
        Me.LabelSortCapital.Location = New System.Drawing.Point(1712, 42)
        Me.LabelSortCapital.Name = "LabelSortCapital"
        Me.LabelSortCapital.Size = New System.Drawing.Size(66, 16)
        Me.LabelSortCapital.TabIndex = 360
        Me.LabelSortCapital.Text = "Capital : 0"
        Me.LabelSortCapital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage4.ImageIndex = 2
        Me.TabPage4.Location = New System.Drawing.Point(4, 47)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Option"
        '
        'TabPageMap
        '
        Me.TabPageMap.AutoScroll = True
        Me.TabPageMap.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageMap.Controls.Add(Me.TabControl5)
        Me.TabPageMap.ImageIndex = 6
        Me.TabPageMap.Location = New System.Drawing.Point(4, 47)
        Me.TabPageMap.Name = "TabPageMap"
        Me.TabPageMap.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMap.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageMap.TabIndex = 5
        Me.TabPageMap.Text = "Map"
        '
        'TabControl5
        '
        Me.TabControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl5.Controls.Add(Me.TabPage6)
        Me.TabControl5.Controls.Add(Me.TabPage5)
        Me.TabControl5.Controls.Add(Me.TabPage7)
        Me.TabControl5.ImageList = Me.ImageListUser
        Me.TabControl5.Location = New System.Drawing.Point(6, 6)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(1845, 788)
        Me.TabControl5.TabIndex = 365
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.DataGridViewMapSol)
        Me.TabPage6.Controls.Add(Me.DataGridViewMap)
        Me.TabPage6.ImageIndex = 6
        Me.TabPage6.Location = New System.Drawing.Point(4, 47)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Map"
        '
        'DataGridViewMapSol
        '
        Me.DataGridViewMapSol.AllowUserToAddRows = False
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMapSol.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewMapSol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMapSol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewMapSol.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMapSol.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewMapSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMapSol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52})
        Me.DataGridViewMapSol.GridColor = System.Drawing.Color.Black
        Me.DataGridViewMapSol.Location = New System.Drawing.Point(6, 593)
        Me.DataGridViewMapSol.MultiSelect = False
        Me.DataGridViewMapSol.Name = "DataGridViewMapSol"
        Me.DataGridViewMapSol.RowHeadersWidth = 4
        Me.DataGridViewMapSol.Size = New System.Drawing.Size(1825, 138)
        Me.DataGridViewMapSol.TabIndex = 363
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn49.HeaderText = "Cellule"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 74
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.HeaderText = "Id Objet"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn51.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn52.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewMap
        '
        Me.DataGridViewMap.AllowUserToAddRows = False
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewMap.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.Column7, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridViewMap.GridColor = System.Drawing.Color.Black
        Me.DataGridViewMap.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewMap.MultiSelect = False
        Me.DataGridViewMap.Name = "DataGridViewMap"
        Me.DataGridViewMap.RowHeadersWidth = 4
        Me.DataGridViewMap.Size = New System.Drawing.Size(1825, 581)
        Me.DataGridViewMap.TabIndex = 362
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cellule"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 74
        '
        'Column7
        '
        Me.Column7.HeaderText = "Id Unique"
        Me.Column7.Name = "Column7"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.DataGridViewDivers)
        Me.TabPage5.ImageIndex = 7
        Me.TabPage5.Location = New System.Drawing.Point(4, 47)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Divers"
        '
        'DataGridViewDivers
        '
        Me.DataGridViewDivers.AllowUserToAddRows = False
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDivers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewDivers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDivers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDivers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDivers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewDivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDivers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn4})
        Me.DataGridViewDivers.GridColor = System.Drawing.Color.Black
        Me.DataGridViewDivers.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewDivers.MultiSelect = False
        Me.DataGridViewDivers.Name = "DataGridViewDivers"
        Me.DataGridViewDivers.RowHeadersWidth = 4
        Me.DataGridViewDivers.Size = New System.Drawing.Size(1825, 725)
        Me.DataGridViewDivers.TabIndex = 362
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID Sprite"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cellule"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Etat"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage7.ImageIndex = 2
        Me.TabPage7.Location = New System.Drawing.Point(4, 47)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1837, 737)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Option"
        '
        'TabPageMetier
        '
        Me.TabPageMetier.AutoScroll = True
        Me.TabPageMetier.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageMetier.Controls.Add(Me.FlowLayoutPanelMetier)
        Me.TabPageMetier.ImageIndex = 8
        Me.TabPageMetier.Location = New System.Drawing.Point(4, 47)
        Me.TabPageMetier.Name = "TabPageMetier"
        Me.TabPageMetier.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMetier.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageMetier.TabIndex = 6
        Me.TabPageMetier.Text = "Métier"
        '
        'FlowLayoutPanelMetier
        '
        Me.FlowLayoutPanelMetier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelMetier.AutoScroll = True
        Me.FlowLayoutPanelMetier.Location = New System.Drawing.Point(6, 6)
        Me.FlowLayoutPanelMetier.Name = "FlowLayoutPanelMetier"
        Me.FlowLayoutPanelMetier.Size = New System.Drawing.Size(1845, 788)
        Me.FlowLayoutPanelMetier.TabIndex = 0
        '
        'TabPageDragodinde
        '
        Me.TabPageDragodinde.AutoScroll = True
        Me.TabPageDragodinde.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageDragodinde.Controls.Add(Me.DataGridViewDragodindeEquipé)
        Me.TabPageDragodinde.Controls.Add(Me.DataGridViewDragodindeEtable)
        Me.TabPageDragodinde.Controls.Add(Me.DataGridViewDragodindeEnclo)
        Me.TabPageDragodinde.ImageIndex = 42
        Me.TabPageDragodinde.Location = New System.Drawing.Point(4, 47)
        Me.TabPageDragodinde.Name = "TabPageDragodinde"
        Me.TabPageDragodinde.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDragodinde.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageDragodinde.TabIndex = 7
        Me.TabPageDragodinde.Text = "Dragodinde"
        '
        'DataGridViewDragodindeEquipé
        '
        Me.DataGridViewDragodindeEquipé.AllowUserToAddRows = False
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEquipé.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewDragodindeEquipé.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDragodindeEquipé.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDragodindeEquipé.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEquipé.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewDragodindeEquipé.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDragodindeEquipé.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.Column27, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48})
        Me.DataGridViewDragodindeEquipé.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewDragodindeEquipé.GridColor = System.Drawing.Color.Black
        Me.DataGridViewDragodindeEquipé.Location = New System.Drawing.Point(6, 673)
        Me.DataGridViewDragodindeEquipé.MultiSelect = False
        Me.DataGridViewDragodindeEquipé.Name = "DataGridViewDragodindeEquipé"
        Me.DataGridViewDragodindeEquipé.RowHeadersWidth = 4
        Me.DataGridViewDragodindeEquipé.Size = New System.Drawing.Size(1845, 121)
        Me.DataGridViewDragodindeEquipé.TabIndex = 365
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn32.HeaderText = "Id Unique (Equipé)"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'Column27
        '
        Me.Column27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column27.HeaderText = "Nom Dragodinde"
        Me.Column27.Name = "Column27"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.HeaderText = "Arbre Généalogique"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn34.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn35.HeaderText = "Sexe"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn36.HeaderText = "Niveau"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn37.HeaderText = "Xp"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn38.HeaderText = "Montable"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn39.HeaderText = "Endurance"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn40.HeaderText = "Maturité"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn41.HeaderText = "Amour"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.HeaderText = "Etat"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn43.HeaderText = "Energie"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.HeaderText = "Fatigue"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn45.HeaderText = "Capacité"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn46.HeaderText = "Caractéristique"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.HeaderText = "Fécondation"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn48.HeaderText = "Reproduction"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewDragodindeEtable
        '
        Me.DataGridViewDragodindeEtable.AllowUserToAddRows = False
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEtable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewDragodindeEtable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDragodindeEtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDragodindeEtable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEtable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewDragodindeEtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDragodindeEtable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.Column26, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.DataGridViewDragodindeEtable.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewDragodindeEtable.GridColor = System.Drawing.Color.Black
        Me.DataGridViewDragodindeEtable.Location = New System.Drawing.Point(7, 340)
        Me.DataGridViewDragodindeEtable.MultiSelect = False
        Me.DataGridViewDragodindeEtable.Name = "DataGridViewDragodindeEtable"
        Me.DataGridViewDragodindeEtable.RowHeadersWidth = 4
        Me.DataGridViewDragodindeEtable.Size = New System.Drawing.Size(1845, 327)
        Me.DataGridViewDragodindeEtable.TabIndex = 364
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = "Id Unique (Etable)"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Column26
        '
        Me.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column26.HeaderText = "Nom Dragodinde"
        Me.Column26.Name = "Column26"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.HeaderText = "Arbre Généalogique"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.HeaderText = "Sexe"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.HeaderText = "Niveau"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.HeaderText = "Xp"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.HeaderText = "Montable"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn22.HeaderText = "Endurance"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn23.HeaderText = "Maturité"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn24.HeaderText = "Amour"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn25.HeaderText = "Etat"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn26.HeaderText = "Energie"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.HeaderText = "Fatigue"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.HeaderText = "Capacité"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn29.HeaderText = "Caractéristique"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Fécondation"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn31.HeaderText = "Reproduction"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewDragodindeEnclo
        '
        Me.DataGridViewDragodindeEnclo.AllowUserToAddRows = False
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEnclo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewDragodindeEnclo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDragodindeEnclo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDragodindeEnclo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDragodindeEnclo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewDragodindeEnclo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDragodindeEnclo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column25, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column24, Me.Column23})
        Me.DataGridViewDragodindeEnclo.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewDragodindeEnclo.GridColor = System.Drawing.Color.Black
        Me.DataGridViewDragodindeEnclo.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewDragodindeEnclo.MultiSelect = False
        Me.DataGridViewDragodindeEnclo.Name = "DataGridViewDragodindeEnclo"
        Me.DataGridViewDragodindeEnclo.RowHeadersWidth = 4
        Me.DataGridViewDragodindeEnclo.Size = New System.Drawing.Size(1845, 327)
        Me.DataGridViewDragodindeEnclo.TabIndex = 363
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Id Unique (Enclos)"
        Me.Column8.Name = "Column8"
        '
        'Column25
        '
        Me.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column25.HeaderText = "Nom Dragodinde"
        Me.Column25.Name = "Column25"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Arbre Généalogique"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Nom"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Sexe"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Niveau"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "Xp"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column14.HeaderText = "Montable"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column15.HeaderText = "Endurance"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column16.HeaderText = "Maturité"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column17.HeaderText = "Amour"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column18.HeaderText = "Etat"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column19.HeaderText = "Energie"
        Me.Column19.Name = "Column19"
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column20.HeaderText = "Fatigue"
        Me.Column20.Name = "Column20"
        '
        'Column21
        '
        Me.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column21.HeaderText = "Capacité"
        Me.Column21.Name = "Column21"
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column22.HeaderText = "Caractéristique"
        Me.Column22.Name = "Column22"
        '
        'Column24
        '
        Me.Column24.HeaderText = "Fécondation"
        Me.Column24.Name = "Column24"
        '
        'Column23
        '
        Me.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column23.HeaderText = "Reproduction"
        Me.Column23.Name = "Column23"
        '
        'TabPageCraft
        '
        Me.TabPageCraft.AutoScroll = True
        Me.TabPageCraft.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPageCraft.Controls.Add(Me.ListView_Forgemagie)
        Me.TabPageCraft.Controls.Add(Me.DataGridViewMoi)
        Me.TabPageCraft.Controls.Add(Me.DataGridViewLui)
        Me.TabPageCraft.ImageIndex = 43
        Me.TabPageCraft.Location = New System.Drawing.Point(4, 47)
        Me.TabPageCraft.Name = "TabPageCraft"
        Me.TabPageCraft.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCraft.Size = New System.Drawing.Size(1857, 800)
        Me.TabPageCraft.TabIndex = 8
        Me.TabPageCraft.Text = "Craft"
        '
        'ListView_Forgemagie
        '
        Me.ListView_Forgemagie.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ListView_Forgemagie.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader194, Me.ColumnHeader195, Me.ColumnHeader196, Me.ColumnHeader197, Me.ColumnHeader198, Me.ColumnHeader1})
        Me.ListView_Forgemagie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_Forgemagie.ForeColor = System.Drawing.Color.White
        Me.ListView_Forgemagie.FullRowSelect = True
        Me.ListView_Forgemagie.GridLines = True
        Me.ListView_Forgemagie.HideSelection = False
        Me.ListView_Forgemagie.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem45, ListViewItem46, ListViewItem47, ListViewItem48, ListViewItem49, ListViewItem50, ListViewItem51, ListViewItem52, ListViewItem53, ListViewItem54, ListViewItem55, ListViewItem56, ListViewItem57, ListViewItem58, ListViewItem59, ListViewItem60, ListViewItem61, ListViewItem62, ListViewItem63, ListViewItem64, ListViewItem65, ListViewItem66, ListViewItem67, ListViewItem68, ListViewItem69, ListViewItem70, ListViewItem71, ListViewItem72, ListViewItem73, ListViewItem74})
        Me.ListView_Forgemagie.Location = New System.Drawing.Point(732, 6)
        Me.ListView_Forgemagie.Name = "ListView_Forgemagie"
        Me.ListView_Forgemagie.Size = New System.Drawing.Size(393, 788)
        Me.ListView_Forgemagie.SmallImageList = Me.ImageList1
        Me.ListView_Forgemagie.TabIndex = 392
        Me.ListView_Forgemagie.UseCompatibleStateImageBehavior = False
        Me.ListView_Forgemagie.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader194
        '
        Me.ColumnHeader194.Text = "Caractéristiques"
        Me.ColumnHeader194.Width = 161
        '
        'ColumnHeader195
        '
        Me.ColumnHeader195.Text = "Min"
        Me.ColumnHeader195.Width = 41
        '
        'ColumnHeader196
        '
        Me.ColumnHeader196.Text = "Actuel"
        Me.ColumnHeader196.Width = 57
        '
        'ColumnHeader197
        '
        Me.ColumnHeader197.Text = "Max"
        Me.ColumnHeader197.Width = 41
        '
        'ColumnHeader198
        '
        Me.ColumnHeader198.Text = "%"
        Me.ColumnHeader198.Width = 37
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rune"
        Me.ColumnHeader1.Width = 51
        '
        'DataGridViewMoi
        '
        Me.DataGridViewMoi.AllowUserToAddRows = False
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMoi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewMoi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMoi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewMoi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMoi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMoi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.DataGridViewMoi.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewMoi.GridColor = System.Drawing.Color.Black
        Me.DataGridViewMoi.Location = New System.Drawing.Point(1131, 6)
        Me.DataGridViewMoi.MultiSelect = False
        Me.DataGridViewMoi.Name = "DataGridViewMoi"
        Me.DataGridViewMoi.RowHeadersWidth = 4
        Me.DataGridViewMoi.Size = New System.Drawing.Size(720, 788)
        Me.DataGridViewMoi.TabIndex = 364
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn58.HeaderText = "ID Objet"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 86
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn59.HeaderText = "ID Unique"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.Width = 96
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn60.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn61.HeaderText = "Quantité"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.Width = 88
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn62.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewLui
        '
        Me.DataGridViewLui.AllowUserToAddRows = False
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLui.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewLui.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewLui.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewLui.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLui.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewLui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLui.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57})
        Me.DataGridViewLui.ContextMenuStrip = Me.ContextMenuStripInventaire
        Me.DataGridViewLui.GridColor = System.Drawing.Color.Black
        Me.DataGridViewLui.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewLui.MultiSelect = False
        Me.DataGridViewLui.Name = "DataGridViewLui"
        Me.DataGridViewLui.RowHeadersWidth = 4
        Me.DataGridViewLui.Size = New System.Drawing.Size(720, 788)
        Me.DataGridViewLui.TabIndex = 363
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn53.HeaderText = "ID Objet"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 86
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn54.HeaderText = "ID Unique"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 96
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn55.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn56.HeaderText = "Quantité"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 88
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn57.HeaderText = "Information"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'TabPage8
        '
        Me.TabPage8.AutoScroll = True
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TabPage8.Controls.Add(Me.Button1)
        Me.TabPage8.Location = New System.Drawing.Point(4, 47)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1857, 800)
        Me.TabPage8.TabIndex = 9
        Me.TabPage8.Text = "TabPage8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1
        Me.ToolTip1.AutoPopDelay = 60000
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 0
        '
        'TimerRegeneration
        '
        Me.TimerRegeneration.Enabled = True
        Me.TimerRegeneration.Interval = 2000
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1657, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 371
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserControlPersonnage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UserControlPersonnage"
        Me.Size = New System.Drawing.Size(1871, 857)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageTchat.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage_Tchat.ResumeLayout(False)
        Me.TabPage_Tchat.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCaractéristique.ResumeLayout(False)
        Me.TabPageCaractéristique.PerformLayout()
        CType(Me.DataGridView_BonusPanoplie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageInventaire.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewInventaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripInventaire.ResumeLayout(False)
        Me.TabPageSort.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMap.ResumeLayout(False)
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridViewMapSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridViewDivers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMetier.ResumeLayout(False)
        Me.TabPageDragodinde.ResumeLayout(False)
        CType(Me.DataGridViewDragodindeEquipé, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDragodindeEtable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDragodindeEnclo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCraft.ResumeLayout(False)
        CType(Me.DataGridViewMoi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerStatut As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageTchat As TabPage
    Friend WithEvents TabPageSocket As TabPage
    Friend WithEvents ImageListUser As ImageList
    Friend WithEvents RichTextBoxTchat As RichTextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage_Tchat As TabPage
    Friend WithEvents CheckBox_Canal_Communs_1 As CheckBox
    Friend WithEvents CheckBox_Canal_Commerce_6 As CheckBox
    Friend WithEvents CheckBox_Canal_Recrutement_5 As CheckBox
    Friend WithEvents CheckBox_Canal_Alignement_4 As CheckBox
    Friend WithEvents CheckBox_Canal_Guilde_3 As CheckBox
    Friend WithEvents CheckBox_Canal_Groupe_2 As CheckBox
    Friend WithEvents CheckBox_Canal_Information_0 As CheckBox
    Friend WithEvents ComboBoxTchat As ComboBox
    Friend WithEvents Button_Tchat_Envoyer As Button
    Friend WithEvents TextBoxTchat As TextBox
    Friend WithEvents TabPage_TchatOption As TabPage
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelStatut As Label
    Friend WithEvents ButtonConnexion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelAbonnement As Label
    Friend WithEvents TabPageCaractéristique As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelNiveau As Label
    Friend WithEvents TabPageInventaire As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridViewInventaire As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LabelKamas As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ProgressBarVitalite As ProgressBar
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ProgressBarExperience As ProgressBar
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents LabelCaracteristiqueCapital As Label
    Friend WithEvents TabPageSort As TabPage
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LabelSortCapital As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ProgressBarEnergie As ProgressBar
    Friend WithEvents ListViewCaractéristique As ListView
    Friend WithEvents Caractéristique_Caractéristique As ColumnHeader
    Friend WithEvents Caractéristique_Base As ColumnHeader
    Friend WithEvents Caractéristique_Equipement As ColumnHeader
    Friend WithEvents Caractéristique_Dons As ColumnHeader
    Friend WithEvents Caractéristique_Boost As ColumnHeader
    Friend WithEvents Caractéristique_Total As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents RichTextBoxSocket As RichTextBox
    Friend WithEvents TimerRegeneration As Timer
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents ProgressBarPods As ProgressBar
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridViewSort As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents TabPageMap As TabPage
    Friend WithEvents TabControl5 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DataGridViewMap As DataGridView
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents LabelMap As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDivers As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStripInventaire As ContextMenuStrip
    Friend WithEvents MettreLitemDansLeTchatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxTchatJoueur As TextBox
    Friend WithEvents DataGridView_BonusPanoplie As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents TabPageMetier As TabPage
    Friend WithEvents FlowLayoutPanelMetier As FlowLayoutPanel
    Friend WithEvents TabPageDragodinde As TabPage
    Friend WithEvents DataGridViewDragodindeEquipé As DataGridView
    Friend WithEvents DataGridViewDragodindeEtable As DataGridView
    Friend WithEvents DataGridViewDragodindeEnclo As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewMapSol As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents TabPageCraft As TabPage
    Friend WithEvents DataGridViewMoi As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewLui As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents ListView_Forgemagie As ListView
    Friend WithEvents ColumnHeader194 As ColumnHeader
    Friend WithEvents ColumnHeader195 As ColumnHeader
    Friend WithEvents ColumnHeader196 As ColumnHeader
    Friend WithEvents ColumnHeader197 As ColumnHeader
    Friend WithEvents ColumnHeader198 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DéséquiperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtiliserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
