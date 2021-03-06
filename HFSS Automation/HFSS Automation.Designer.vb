<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HFSSAutomation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HFSSAutomation))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.cboDesigns = New System.Windows.Forms.ComboBox()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddToChangeList = New System.Windows.Forms.Button()
        Me.btnScanVariables = New System.Windows.Forms.Button()
        Me.ScanedVariableGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnChangeVariableValues = New System.Windows.Forms.Button()
        Me.VariableGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnLoadTableFromFile = New System.Windows.Forms.Button()
        Me.btnSaveTableToFile = New System.Windows.Forms.Button()
        Me.cboOrientation = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkCreateVariables = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCavType = New System.Windows.Forms.ComboBox()
        Me.txtCavR = New System.Windows.Forms.TextBox()
        Me.txtCavH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboResType = New System.Windows.Forms.ComboBox()
        Me.txbResH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkDrawPort = New System.Windows.Forms.CheckBox()
        Me.chkDrawCavity = New System.Windows.Forms.CheckBox()
        Me.chkDrawResonator = New System.Windows.Forms.CheckBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDrawHFSS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCreateResonatorList = New System.Windows.Forms.Button()
        Me.txbNode2 = New System.Windows.Forms.TextBox()
        Me.txbNode1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResonatorGrid = New System.Windows.Forms.DataGridView()
        Me.PortA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PortB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EleA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EleB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SyncFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvOptionStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyncWithHFSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ScanedVariableGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariableGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ResonatorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(468, 40)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(186, 45)
        Me.btnLoadFile.TabIndex = 72
        Me.btnLoadFile.Text = "Load HFSS File"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'cboDesigns
        '
        Me.cboDesigns.FormattingEnabled = True
        Me.cboDesigns.Location = New System.Drawing.Point(87, 64)
        Me.cboDesigns.Name = "cboDesigns"
        Me.cboDesigns.Size = New System.Drawing.Size(370, 21)
        Me.cboDesigns.TabIndex = 71
        '
        'txtFilename
        '
        Me.txtFilename.Enabled = False
        Me.txtFilename.Location = New System.Drawing.Point(87, 40)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(370, 20)
        Me.txtFilename.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Design Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "File Name:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 620)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(847, 22)
        Me.StatusStrip1.TabIndex = 73
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(847, 529)
        Me.TabControl1.TabIndex = 78
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.btnChangeVariableValues)
        Me.TabPage2.Controls.Add(Me.VariableGrid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(839, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Change Variables"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAddToChangeList)
        Me.Panel1.Controls.Add(Me.btnScanVariables)
        Me.Panel1.Controls.Add(Me.ScanedVariableGrid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(486, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 497)
        Me.Panel1.TabIndex = 62
        '
        'btnAddToChangeList
        '
        Me.btnAddToChangeList.Location = New System.Drawing.Point(176, 6)
        Me.btnAddToChangeList.Name = "btnAddToChangeList"
        Me.btnAddToChangeList.Size = New System.Drawing.Size(169, 35)
        Me.btnAddToChangeList.TabIndex = 60
        Me.btnAddToChangeList.Text = "Add selected to Change Table"
        Me.btnAddToChangeList.UseVisualStyleBackColor = True
        '
        'btnScanVariables
        '
        Me.btnScanVariables.Location = New System.Drawing.Point(3, 6)
        Me.btnScanVariables.Name = "btnScanVariables"
        Me.btnScanVariables.Size = New System.Drawing.Size(161, 35)
        Me.btnScanVariables.TabIndex = 59
        Me.btnScanVariables.Text = "Scan Design Variables"
        Me.btnScanVariables.UseVisualStyleBackColor = True
        '
        'ScanedVariableGrid
        '
        Me.ScanedVariableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScanedVariableGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ScanedVariableGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ScanedVariableGrid.Location = New System.Drawing.Point(0, 77)
        Me.ScanedVariableGrid.Name = "ScanedVariableGrid"
        Me.ScanedVariableGrid.Size = New System.Drawing.Size(350, 420)
        Me.ScanedVariableGrid.TabIndex = 58
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Variable Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Current Value"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'btnChangeVariableValues
        '
        Me.btnChangeVariableValues.BackColor = System.Drawing.Color.Aquamarine
        Me.btnChangeVariableValues.Location = New System.Drawing.Point(94, 9)
        Me.btnChangeVariableValues.Name = "btnChangeVariableValues"
        Me.btnChangeVariableValues.Size = New System.Drawing.Size(265, 32)
        Me.btnChangeVariableValues.TabIndex = 58
        Me.btnChangeVariableValues.Text = "Start Change HFSS Variable Values"
        Me.btnChangeVariableValues.UseVisualStyleBackColor = False
        '
        'VariableGrid
        '
        Me.VariableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VariableGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.CurrentValue})
        Me.VariableGrid.Location = New System.Drawing.Point(3, 47)
        Me.VariableGrid.Name = "VariableGrid"
        Me.VariableGrid.Size = New System.Drawing.Size(450, 420)
        Me.VariableGrid.TabIndex = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Variable Name for Change"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Target Value (mm)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'CurrentValue
        '
        Me.CurrentValue.HeaderText = "Current Value"
        Me.CurrentValue.Name = "CurrentValue"
        Me.CurrentValue.Width = 120
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLoadTableFromFile)
        Me.TabPage1.Controls.Add(Me.btnSaveTableToFile)
        Me.TabPage1.Controls.Add(Me.cboOrientation)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.chkCreateVariables)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.chkDrawPort)
        Me.TabPage1.Controls.Add(Me.chkDrawCavity)
        Me.TabPage1.Controls.Add(Me.chkDrawResonator)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnDrawHFSS)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ResonatorGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(839, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create HFS Model"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLoadTableFromFile
        '
        Me.btnLoadTableFromFile.Location = New System.Drawing.Point(408, 156)
        Me.btnLoadTableFromFile.Name = "btnLoadTableFromFile"
        Me.btnLoadTableFromFile.Size = New System.Drawing.Size(185, 25)
        Me.btnLoadTableFromFile.TabIndex = 102
        Me.btnLoadTableFromFile.Text = "Load Table From File"
        Me.btnLoadTableFromFile.UseVisualStyleBackColor = True
        '
        'btnSaveTableToFile
        '
        Me.btnSaveTableToFile.Location = New System.Drawing.Point(207, 156)
        Me.btnSaveTableToFile.Name = "btnSaveTableToFile"
        Me.btnSaveTableToFile.Size = New System.Drawing.Size(185, 25)
        Me.btnSaveTableToFile.TabIndex = 101
        Me.btnSaveTableToFile.Text = "Save Table To File"
        Me.btnSaveTableToFile.UseVisualStyleBackColor = True
        '
        'cboOrientation
        '
        Me.cboOrientation.FormattingEnabled = True
        Me.cboOrientation.Items.AddRange(New Object() {"X", "Y"})
        Me.cboOrientation.Location = New System.Drawing.Point(408, 131)
        Me.cboOrientation.Name = "cboOrientation"
        Me.cboOrientation.Size = New System.Drawing.Size(35, 21)
        Me.cboOrientation.TabIndex = 100
        Me.cboOrientation.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Hex Orientation"
        '
        'chkCreateVariables
        '
        Me.chkCreateVariables.AutoSize = True
        Me.chkCreateVariables.Checked = True
        Me.chkCreateVariables.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCreateVariables.Location = New System.Drawing.Point(643, 16)
        Me.chkCreateVariables.Name = "chkCreateVariables"
        Me.chkCreateVariables.Size = New System.Drawing.Size(103, 17)
        Me.chkCreateVariables.TabIndex = 98
        Me.chkCreateVariables.Text = "Create Variables"
        Me.chkCreateVariables.UseVisualStyleBackColor = True
        Me.chkCreateVariables.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cboCavType)
        Me.GroupBox3.Controls.Add(Me.txtCavR)
        Me.GroupBox3.Controls.Add(Me.txtCavH)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(155, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 99)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cavity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Cav Type"
        '
        'cboCavType
        '
        Me.cboCavType.FormattingEnabled = True
        Me.cboCavType.Items.AddRange(New Object() {"Cylinder", "Hex"})
        Me.cboCavType.Location = New System.Drawing.Point(65, 66)
        Me.cboCavType.Name = "cboCavType"
        Me.cboCavType.Size = New System.Drawing.Size(61, 21)
        Me.cboCavType.TabIndex = 91
        Me.cboCavType.Text = "Cylinder"
        '
        'txtCavR
        '
        Me.txtCavR.Location = New System.Drawing.Point(65, 41)
        Me.txtCavR.Name = "txtCavR"
        Me.txtCavR.Size = New System.Drawing.Size(61, 20)
        Me.txtCavR.TabIndex = 85
        Me.txtCavR.Text = "18"
        '
        'txtCavH
        '
        Me.txtCavH.Location = New System.Drawing.Point(65, 15)
        Me.txtCavH.Name = "txtCavH"
        Me.txtCavH.Size = New System.Drawing.Size(61, 20)
        Me.txtCavH.TabIndex = 84
        Me.txtCavH.Text = "35"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "CavR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "CavH"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboResType)
        Me.GroupBox2.Controls.Add(Me.txbResH)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtResR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 100)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resonator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Res Type"
        '
        'cboResType
        '
        Me.cboResType.FormattingEnabled = True
        Me.cboResType.Items.AddRange(New Object() {"Cylinder", "Hex"})
        Me.cboResType.Location = New System.Drawing.Point(59, 68)
        Me.cboResType.Name = "cboResType"
        Me.cboResType.Size = New System.Drawing.Size(61, 21)
        Me.cboResType.TabIndex = 89
        Me.cboResType.Text = "Cylinder"
        '
        'txbResH
        '
        Me.txbResH.Location = New System.Drawing.Point(59, 42)
        Me.txbResH.Name = "txbResH"
        Me.txbResH.Size = New System.Drawing.Size(61, 20)
        Me.txbResH.TabIndex = 88
        Me.txbResH.Text = "30"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "ResH"
        '
        'txtResR
        '
        Me.txtResR.Location = New System.Drawing.Point(59, 19)
        Me.txtResR.Name = "txtResR"
        Me.txtResR.Size = New System.Drawing.Size(61, 20)
        Me.txtResR.TabIndex = 86
        Me.txtResR.Text = "6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "ResR"
        '
        'chkDrawPort
        '
        Me.chkDrawPort.AutoSize = True
        Me.chkDrawPort.Checked = True
        Me.chkDrawPort.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawPort.Location = New System.Drawing.Point(315, 108)
        Me.chkDrawPort.Name = "chkDrawPort"
        Me.chkDrawPort.Size = New System.Drawing.Size(114, 17)
        Me.chkDrawPort.TabIndex = 95
        Me.chkDrawPort.Text = "Draw Lumped Port"
        Me.chkDrawPort.UseVisualStyleBackColor = True
        '
        'chkDrawCavity
        '
        Me.chkDrawCavity.AutoSize = True
        Me.chkDrawCavity.Checked = True
        Me.chkDrawCavity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawCavity.Location = New System.Drawing.Point(315, 90)
        Me.chkDrawCavity.Name = "chkDrawCavity"
        Me.chkDrawCavity.Size = New System.Drawing.Size(128, 17)
        Me.chkDrawCavity.TabIndex = 94
        Me.chkDrawCavity.Text = "Draw Cavity and IRIS"
        Me.chkDrawCavity.UseVisualStyleBackColor = True
        '
        'chkDrawResonator
        '
        Me.chkDrawResonator.AutoSize = True
        Me.chkDrawResonator.Checked = True
        Me.chkDrawResonator.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawResonator.Location = New System.Drawing.Point(315, 67)
        Me.chkDrawResonator.Name = "chkDrawResonator"
        Me.chkDrawResonator.Size = New System.Drawing.Size(103, 17)
        Me.chkDrawResonator.TabIndex = 93
        Me.chkDrawResonator.Text = "Draw Resonator"
        Me.chkDrawResonator.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(61, 20)
        Me.txtName.TabIndex = 83
        Me.txtName.Text = "TX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "CH Name"
        '
        'btnDrawHFSS
        '
        Me.btnDrawHFSS.Location = New System.Drawing.Point(8, 156)
        Me.btnDrawHFSS.Name = "btnDrawHFSS"
        Me.btnDrawHFSS.Size = New System.Drawing.Size(189, 25)
        Me.btnDrawHFSS.TabIndex = 78
        Me.btnDrawHFSS.Text = "Create HFSS Solids"
        Me.btnDrawHFSS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCreateResonatorList)
        Me.GroupBox1.Controls.Add(Me.txbNode2)
        Me.GroupBox1.Controls.Add(Me.txbNode1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(452, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 135)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assistant"
        '
        'BtnCreateResonatorList
        '
        Me.BtnCreateResonatorList.Location = New System.Drawing.Point(31, 84)
        Me.BtnCreateResonatorList.Name = "BtnCreateResonatorList"
        Me.BtnCreateResonatorList.Size = New System.Drawing.Size(84, 45)
        Me.BtnCreateResonatorList.TabIndex = 67
        Me.BtnCreateResonatorList.Text = "Create Resonator List"
        Me.BtnCreateResonatorList.UseVisualStyleBackColor = True
        '
        'txbNode2
        '
        Me.txbNode2.Location = New System.Drawing.Point(92, 55)
        Me.txbNode2.Name = "txbNode2"
        Me.txbNode2.Size = New System.Drawing.Size(23, 20)
        Me.txbNode2.TabIndex = 66
        Me.txbNode2.Text = "6"
        '
        'txbNode1
        '
        Me.txbNode1.Location = New System.Drawing.Point(92, 26)
        Me.txbNode1.Name = "txbNode1"
        Me.txbNode1.Size = New System.Drawing.Size(23, 20)
        Me.txbNode1.TabIndex = 65
        Me.txbNode1.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Stop Node"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Start Node"
        '
        'ResonatorGrid
        '
        Me.ResonatorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResonatorGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PortA, Me.PortB, Me.EleA, Me.EleB, Me.SyncFreq})
        Me.ResonatorGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ResonatorGrid.Location = New System.Drawing.Point(3, 220)
        Me.ResonatorGrid.Name = "ResonatorGrid"
        Me.ResonatorGrid.Size = New System.Drawing.Size(833, 280)
        Me.ResonatorGrid.TabIndex = 56
        '
        'PortA
        '
        Me.PortA.HeaderText = "Number #"
        Me.PortA.Name = "PortA"
        '
        'PortB
        '
        Me.PortB.HeaderText = "X"
        Me.PortB.Name = "PortB"
        '
        'EleA
        '
        Me.EleA.HeaderText = "Y"
        Me.EleA.Name = "EleA"
        '
        'EleB
        '
        Me.EleB.HeaderText = "Z"
        Me.EleB.Name = "EleB"
        '
        'SyncFreq
        '
        Me.SyncFreq.HeaderText = "Res H"
        Me.SyncFreq.Name = "SyncFreq"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(689, 27)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(146, 28)
        Me.btnOpenFile.TabIndex = 79
        Me.btnOpenFile.Text = "Open HFSS File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        Me.btnOpenFile.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 24)
        Me.MenuStrip1.TabIndex = 80
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SavAsToolStripMenuItem, Me.ToolStripSeparator1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SavAsToolStripMenuItem
        '
        Me.SavAsToolStripMenuItem.Name = "SavAsToolStripMenuItem"
        Me.SavAsToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SavAsToolStripMenuItem.Text = "SavAs"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(102, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnvOptionStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionsToolStripMenuItem.Text = "OPTIONS"
        '
        'EnvOptionStripMenuItem
        '
        Me.EnvOptionStripMenuItem.Name = "EnvOptionStripMenuItem"
        Me.EnvOptionStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EnvOptionStripMenuItem.Text = "Environment Options"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyncWithHFSSToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ToolsToolStripMenuItem.Text = "TOOLS"
        '
        'SyncWithHFSSToolStripMenuItem
        '
        Me.SyncWithHFSSToolStripMenuItem.Name = "SyncWithHFSSToolStripMenuItem"
        Me.SyncWithHFSSToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SyncWithHFSSToolStripMenuItem.Text = "Sync HFSS Project"
        '
        'HFSSAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 642)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.cboDesigns)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HFSSAutomation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HFSS Automation"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ScanedVariableGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariableGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ResonatorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnLoadFile As System.Windows.Forms.Button
    Friend WithEvents cboDesigns As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkDrawCavity As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrawResonator As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCavType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCavR As System.Windows.Forms.TextBox
    Friend WithEvents txtCavH As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDrawHFSS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCreateResonatorList As System.Windows.Forms.Button
    Friend WithEvents txbNode2 As System.Windows.Forms.TextBox
    Friend WithEvents txbNode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResonatorGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PortA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PortB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EleA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EleB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SyncFreq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents VariableGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnChangeVariableValues As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboResType As System.Windows.Forms.ComboBox
    Friend WithEvents txbResH As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtResR As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkDrawPort As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreateVariables As System.Windows.Forms.CheckBox
    Friend WithEvents cboOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnScanVariables As System.Windows.Forms.Button
    Friend WithEvents ScanedVariableGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddToChangeList As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnvOptionStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SyncWithHFSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLoadTableFromFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveTableToFile As System.Windows.Forms.Button

End Class
