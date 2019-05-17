<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatricula
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
        Me.components = New System.ComponentModel.Container
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim PROFESSORLabel As System.Windows.Forms.Label
        Dim CURSOLabel As System.Windows.Forms.Label
        Dim CAPACIDADELabel As System.Windows.Forms.Label
        Dim DATAINICIOLabel As System.Windows.Forms.Label
        Dim DATAFIMLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim MEDIALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMatricula))
        Me.Escola2k19DataSet = New GestãoAcadêmica.escola2k19DataSet
        Me.TURMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TURMATableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.TURMATableAdapter
        Me.TableAdapterManager = New GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
        Me.CURSOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
        Me.MATRICULATableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.MATRICULATableAdapter
        Me.PROFESSORTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.PROFESSORTableAdapter
        Me.TURMABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TURMABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox
        Me.PROFESSORComboBox = New System.Windows.Forms.ComboBox
        Me.PROFESSORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOComboBox = New System.Windows.Forms.ComboBox
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escola2k19DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAPACIDADETextBox = New System.Windows.Forms.TextBox
        Me.DATAINICIODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DATAFIMDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.OBSTextBox = New System.Windows.Forms.TextBox
        Me.MATRICULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATRICULADataGridView = New System.Windows.Forms.DataGridView
        Me.MEDIATextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CODIGOLabel = New System.Windows.Forms.Label
        PROFESSORLabel = New System.Windows.Forms.Label
        CURSOLabel = New System.Windows.Forms.Label
        CAPACIDADELabel = New System.Windows.Forms.Label
        DATAINICIOLabel = New System.Windows.Forms.Label
        DATAFIMLabel = New System.Windows.Forms.Label
        OBSLabel = New System.Windows.Forms.Label
        MEDIALabel = New System.Windows.Forms.Label
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TURMABindingNavigator.SuspendLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escola2k19DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATRICULADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(310, 34)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'PROFESSORLabel
        '
        PROFESSORLabel.AutoSize = True
        PROFESSORLabel.Location = New System.Drawing.Point(310, 60)
        PROFESSORLabel.Name = "PROFESSORLabel"
        PROFESSORLabel.Size = New System.Drawing.Size(76, 13)
        PROFESSORLabel.TabIndex = 3
        PROFESSORLabel.Text = "PROFESSOR:"
        '
        'CURSOLabel
        '
        CURSOLabel.AutoSize = True
        CURSOLabel.Location = New System.Drawing.Point(310, 87)
        CURSOLabel.Name = "CURSOLabel"
        CURSOLabel.Size = New System.Drawing.Size(48, 13)
        CURSOLabel.TabIndex = 5
        CURSOLabel.Text = "CURSO:"
        '
        'CAPACIDADELabel
        '
        CAPACIDADELabel.AutoSize = True
        CAPACIDADELabel.Location = New System.Drawing.Point(310, 114)
        CAPACIDADELabel.Name = "CAPACIDADELabel"
        CAPACIDADELabel.Size = New System.Drawing.Size(78, 13)
        CAPACIDADELabel.TabIndex = 7
        CAPACIDADELabel.Text = "CAPACIDADE:"
        '
        'DATAINICIOLabel
        '
        DATAINICIOLabel.AutoSize = True
        DATAINICIOLabel.Location = New System.Drawing.Point(310, 141)
        DATAINICIOLabel.Name = "DATAINICIOLabel"
        DATAINICIOLabel.Size = New System.Drawing.Size(71, 13)
        DATAINICIOLabel.TabIndex = 9
        DATAINICIOLabel.Text = "DATAINICIO:"
        '
        'DATAFIMLabel
        '
        DATAFIMLabel.AutoSize = True
        DATAFIMLabel.Location = New System.Drawing.Point(310, 167)
        DATAFIMLabel.Name = "DATAFIMLabel"
        DATAFIMLabel.Size = New System.Drawing.Size(57, 13)
        DATAFIMLabel.TabIndex = 11
        DATAFIMLabel.Text = "DATAFIM:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(310, 192)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 13
        OBSLabel.Text = "OBS:"
        '
        'MEDIALabel
        '
        MEDIALabel.AutoSize = True
        MEDIALabel.Location = New System.Drawing.Point(324, 416)
        MEDIALabel.Name = "MEDIALabel"
        MEDIALabel.Size = New System.Drawing.Size(44, 13)
        MEDIALabel.TabIndex = 16
        MEDIALabel.Text = "MEDIA:"
        '
        'Escola2k19DataSet
        '
        Me.Escola2k19DataSet.DataSetName = "escola2k19DataSet"
        Me.Escola2k19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TURMABindingSource
        '
        Me.TURMABindingSource.DataMember = "TURMA"
        Me.TURMABindingSource.DataSource = Me.Escola2k19DataSet
        '
        'TURMATableAdapter
        '
        Me.TURMATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Me.MATRICULATableAdapter
        Me.TableAdapterManager.PROFESSORTableAdapter = Me.PROFESSORTableAdapter
        Me.TableAdapterManager.TURMATableAdapter = Me.TURMATableAdapter
        Me.TableAdapterManager.UpdateOrder = GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CURSOTableAdapter
        '
        Me.CURSOTableAdapter.ClearBeforeFill = True
        '
        'MATRICULATableAdapter
        '
        Me.MATRICULATableAdapter.ClearBeforeFill = True
        '
        'PROFESSORTableAdapter
        '
        Me.PROFESSORTableAdapter.ClearBeforeFill = True
        '
        'TURMABindingNavigator
        '
        Me.TURMABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TURMABindingNavigator.BindingSource = Me.TURMABindingSource
        Me.TURMABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TURMABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TURMABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TURMABindingNavigatorSaveItem})
        Me.TURMABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TURMABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TURMABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TURMABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TURMABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TURMABindingNavigator.Name = "TURMABindingNavigator"
        Me.TURMABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TURMABindingNavigator.Size = New System.Drawing.Size(614, 25)
        Me.TURMABindingNavigator.TabIndex = 0
        Me.TURMABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TURMABindingNavigatorSaveItem
        '
        Me.TURMABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TURMABindingNavigatorSaveItem.Image = CType(resources.GetObject("TURMABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TURMABindingNavigatorSaveItem.Name = "TURMABindingNavigatorSaveItem"
        Me.TURMABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TURMABindingNavigatorSaveItem.Text = "Save Data"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(394, 31)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'PROFESSORComboBox
        '
        Me.PROFESSORComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "PROFESSOR", True))
        Me.PROFESSORComboBox.DataSource = Me.PROFESSORBindingSource
        Me.PROFESSORComboBox.DisplayMember = "NOME"
        Me.PROFESSORComboBox.FormattingEnabled = True
        Me.PROFESSORComboBox.Location = New System.Drawing.Point(394, 57)
        Me.PROFESSORComboBox.Name = "PROFESSORComboBox"
        Me.PROFESSORComboBox.Size = New System.Drawing.Size(200, 21)
        Me.PROFESSORComboBox.TabIndex = 4
        Me.PROFESSORComboBox.ValueMember = "NOME"
        '
        'PROFESSORBindingSource
        '
        Me.PROFESSORBindingSource.DataMember = "PROFESSOR"
        Me.PROFESSORBindingSource.DataSource = Me.Escola2k19DataSet
        '
        'CURSOComboBox
        '
        Me.CURSOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CURSO", True))
        Me.CURSOComboBox.DataSource = Me.CURSOBindingSource
        Me.CURSOComboBox.DisplayMember = "NOME"
        Me.CURSOComboBox.FormattingEnabled = True
        Me.CURSOComboBox.Location = New System.Drawing.Point(394, 84)
        Me.CURSOComboBox.Name = "CURSOComboBox"
        Me.CURSOComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CURSOComboBox.TabIndex = 6
        Me.CURSOComboBox.ValueMember = "NOME"
        '
        'CURSOBindingSource
        '
        Me.CURSOBindingSource.DataMember = "CURSO"
        Me.CURSOBindingSource.DataSource = Me.Escola2k19DataSetBindingSource
        '
        'Escola2k19DataSetBindingSource
        '
        Me.Escola2k19DataSetBindingSource.DataSource = Me.Escola2k19DataSet
        Me.Escola2k19DataSetBindingSource.Position = 0
        '
        'CAPACIDADETextBox
        '
        Me.CAPACIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "CAPACIDADE", True))
        Me.CAPACIDADETextBox.Location = New System.Drawing.Point(394, 111)
        Me.CAPACIDADETextBox.Name = "CAPACIDADETextBox"
        Me.CAPACIDADETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CAPACIDADETextBox.TabIndex = 8
        '
        'DATAINICIODateTimePicker
        '
        Me.DATAINICIODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DATAINICIO", True))
        Me.DATAINICIODateTimePicker.Location = New System.Drawing.Point(394, 137)
        Me.DATAINICIODateTimePicker.Name = "DATAINICIODateTimePicker"
        Me.DATAINICIODateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATAINICIODateTimePicker.TabIndex = 10
        '
        'DATAFIMDateTimePicker
        '
        Me.DATAFIMDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TURMABindingSource, "DATAFIM", True))
        Me.DATAFIMDateTimePicker.Location = New System.Drawing.Point(394, 163)
        Me.DATAFIMDateTimePicker.Name = "DATAFIMDateTimePicker"
        Me.DATAFIMDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATAFIMDateTimePicker.TabIndex = 12
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(394, 189)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(200, 55)
        Me.OBSTextBox.TabIndex = 14
        '
        'MATRICULABindingSource
        '
        Me.MATRICULABindingSource.DataMember = "TURMA_MATRICULA"
        Me.MATRICULABindingSource.DataSource = Me.TURMABindingSource
        '
        'MATRICULADataGridView
        '
        Me.MATRICULADataGridView.AutoGenerateColumns = False
        Me.MATRICULADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MATRICULADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MATRICULADataGridView.DataSource = Me.MATRICULABindingSource
        Me.MATRICULADataGridView.Location = New System.Drawing.Point(12, 241)
        Me.MATRICULADataGridView.Name = "MATRICULADataGridView"
        Me.MATRICULADataGridView.Size = New System.Drawing.Size(300, 220)
        Me.MATRICULADataGridView.TabIndex = 15
        '
        'MEDIATextBox
        '
        Me.MEDIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TURMABindingSource, "MEDIA", True))
        Me.MEDIATextBox.Enabled = False
        Me.MEDIATextBox.Location = New System.Drawing.Point(374, 413)
        Me.MEDIATextBox.Name = "MEDIATextBox"
        Me.MEDIATextBox.Size = New System.Drawing.Size(100, 20)
        Me.MEDIATextBox.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ALUNOBindingSource
        '
        Me.ALUNOBindingSource.DataMember = "ALUNO"
        Me.ALUNOBindingSource.DataSource = Me.Escola2k19DataSet
        '
        'ALUNOTableAdapter
        '
        Me.ALUNOTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TURMA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TURMA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ALUNO"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ALUNOBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "NOME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ALUNO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "NOME"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FormMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 481)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MEDIALabel)
        Me.Controls.Add(Me.MEDIATextBox)
        Me.Controls.Add(Me.MATRICULADataGridView)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(PROFESSORLabel)
        Me.Controls.Add(Me.PROFESSORComboBox)
        Me.Controls.Add(CURSOLabel)
        Me.Controls.Add(Me.CURSOComboBox)
        Me.Controls.Add(CAPACIDADELabel)
        Me.Controls.Add(Me.CAPACIDADETextBox)
        Me.Controls.Add(DATAINICIOLabel)
        Me.Controls.Add(Me.DATAINICIODateTimePicker)
        Me.Controls.Add(DATAFIMLabel)
        Me.Controls.Add(Me.DATAFIMDateTimePicker)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.TURMABindingNavigator)
        Me.Name = "FormMatricula"
        Me.Text = "Gerenciamento de Matrículas"
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TURMABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TURMABindingNavigator.ResumeLayout(False)
        Me.TURMABindingNavigator.PerformLayout()
        CType(Me.PROFESSORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escola2k19DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATRICULADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Escola2k19DataSet As GestãoAcadêmica.escola2k19DataSet
    Friend WithEvents TURMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TURMATableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.TURMATableAdapter
    Friend WithEvents TableAdapterManager As GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TURMABindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TURMABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CODIGOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROFESSORComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CURSOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CAPACIDADETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATAINICIODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DATAFIMDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PROFESSORTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.PROFESSORTableAdapter
    Friend WithEvents PROFESSORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CURSOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents Escola2k19DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CURSOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MATRICULATableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.MATRICULATableAdapter
    Friend WithEvents MATRICULABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MATRICULADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MEDIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ALUNOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents ALUNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
