<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAluno
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
        Dim MATRICULALabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim SOBRENOMELabel As System.Windows.Forms.Label
        Dim TELEFONELabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Dim CRLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAluno))
        Me.Escola2k19DataSet = New GestãoAcadêmica.escola2k19DataSet
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUNOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
        Me.TableAdapterManager = New GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
        Me.ALUNOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ALUNOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MATRICULATextBox = New System.Windows.Forms.TextBox
        Me.NOMETextBox = New System.Windows.Forms.TextBox
        Me.SOBRENOMETextBox = New System.Windows.Forms.TextBox
        Me.TELEFONEMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.EMAILTextBox = New System.Windows.Forms.TextBox
        Me.OBSTextBox = New System.Windows.Forms.TextBox
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox
        Me.CRTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        MATRICULALabel = New System.Windows.Forms.Label
        NOMELabel = New System.Windows.Forms.Label
        SOBRENOMELabel = New System.Windows.Forms.Label
        TELEFONELabel = New System.Windows.Forms.Label
        EMAILLabel = New System.Windows.Forms.Label
        OBSLabel = New System.Windows.Forms.Label
        FOTOLabel = New System.Windows.Forms.Label
        CRLabel = New System.Windows.Forms.Label
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUNOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUNOBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MATRICULALabel
        '
        MATRICULALabel.AutoSize = True
        MATRICULALabel.Location = New System.Drawing.Point(19, 72)
        MATRICULALabel.Name = "MATRICULALabel"
        MATRICULALabel.Size = New System.Drawing.Size(72, 13)
        MATRICULALabel.TabIndex = 1
        MATRICULALabel.Text = "MATRICULA:"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(19, 98)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'SOBRENOMELabel
        '
        SOBRENOMELabel.AutoSize = True
        SOBRENOMELabel.Location = New System.Drawing.Point(19, 124)
        SOBRENOMELabel.Name = "SOBRENOMELabel"
        SOBRENOMELabel.Size = New System.Drawing.Size(79, 13)
        SOBRENOMELabel.TabIndex = 5
        SOBRENOMELabel.Text = "SOBRENOME:"
        '
        'TELEFONELabel
        '
        TELEFONELabel.AutoSize = True
        TELEFONELabel.Location = New System.Drawing.Point(19, 150)
        TELEFONELabel.Name = "TELEFONELabel"
        TELEFONELabel.Size = New System.Drawing.Size(66, 13)
        TELEFONELabel.TabIndex = 7
        TELEFONELabel.Text = "TELEFONE:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Location = New System.Drawing.Point(19, 176)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(42, 13)
        EMAILLabel.TabIndex = 9
        EMAILLabel.Text = "EMAIL:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(19, 202)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 11
        OBSLabel.Text = "OBS:"
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(22, 243)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 13
        FOTOLabel.Text = "FOTO:"
        '
        'CRLabel
        '
        CRLabel.AutoSize = True
        CRLabel.Location = New System.Drawing.Point(19, 379)
        CRLabel.Name = "CRLabel"
        CRLabel.Size = New System.Drawing.Size(25, 13)
        CRLabel.TabIndex = 15
        CRLabel.Text = "CR:"
        '
        'Escola2k19DataSet
        '
        Me.Escola2k19DataSet.DataSetName = "escola2k19DataSet"
        Me.Escola2k19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Nothing
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ALUNOBindingNavigator
        '
        Me.ALUNOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUNOBindingNavigator.BindingSource = Me.ALUNOBindingSource
        Me.ALUNOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUNOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUNOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUNOBindingNavigatorSaveItem})
        Me.ALUNOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUNOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUNOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUNOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUNOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUNOBindingNavigator.Name = "ALUNOBindingNavigator"
        Me.ALUNOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUNOBindingNavigator.Size = New System.Drawing.Size(308, 25)
        Me.ALUNOBindingNavigator.TabIndex = 0
        Me.ALUNOBindingNavigator.Text = "BindingNavigator1"
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
        'ALUNOBindingNavigatorSaveItem
        '
        Me.ALUNOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUNOBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUNOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUNOBindingNavigatorSaveItem.Name = "ALUNOBindingNavigatorSaveItem"
        Me.ALUNOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ALUNOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MATRICULATextBox
        '
        Me.MATRICULATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "MATRICULA", True))
        Me.MATRICULATextBox.Location = New System.Drawing.Point(104, 69)
        Me.MATRICULATextBox.Name = "MATRICULATextBox"
        Me.MATRICULATextBox.Size = New System.Drawing.Size(130, 20)
        Me.MATRICULATextBox.TabIndex = 2
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(104, 95)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(130, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'SOBRENOMETextBox
        '
        Me.SOBRENOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "SOBRENOME", True))
        Me.SOBRENOMETextBox.Location = New System.Drawing.Point(104, 121)
        Me.SOBRENOMETextBox.Name = "SOBRENOMETextBox"
        Me.SOBRENOMETextBox.Size = New System.Drawing.Size(130, 20)
        Me.SOBRENOMETextBox.TabIndex = 6
        '
        'TELEFONEMaskedTextBox
        '
        Me.TELEFONEMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "TELEFONE", True))
        Me.TELEFONEMaskedTextBox.Location = New System.Drawing.Point(104, 147)
        Me.TELEFONEMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TELEFONEMaskedTextBox.Name = "TELEFONEMaskedTextBox"
        Me.TELEFONEMaskedTextBox.Size = New System.Drawing.Size(130, 20)
        Me.TELEFONEMaskedTextBox.TabIndex = 8
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Location = New System.Drawing.Point(104, 173)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(130, 20)
        Me.EMAILTextBox.TabIndex = 10
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(104, 199)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(130, 38)
        Me.OBSTextBox.TabIndex = 12
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ALUNOBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(104, 243)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(90, 109)
        Me.FOTOPictureBox.TabIndex = 14
        Me.FOTOPictureBox.TabStop = False
        '
        'CRTextBox
        '
        Me.CRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "CR", True))
        Me.CRTextBox.Enabled = False
        Me.CRTextBox.Location = New System.Drawing.Point(230, 372)
        Me.CRTextBox.Name = "CRTextBox"
        Me.CRTextBox.Size = New System.Drawing.Size(66, 20)
        Me.CRTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Inserir Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 408)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MATRICULALabel)
        Me.Controls.Add(Me.MATRICULATextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(SOBRENOMELabel)
        Me.Controls.Add(Me.SOBRENOMETextBox)
        Me.Controls.Add(TELEFONELabel)
        Me.Controls.Add(Me.TELEFONEMaskedTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(CRLabel)
        Me.Controls.Add(Me.CRTextBox)
        Me.Controls.Add(Me.ALUNOBindingNavigator)
        Me.Name = "FormAluno"
        Me.Text = "Cadastro de Alunos"
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUNOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUNOBindingNavigator.ResumeLayout(False)
        Me.ALUNOBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Escola2k19DataSet As GestãoAcadêmica.escola2k19DataSet
    Friend WithEvents ALUNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALUNOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents TableAdapterManager As GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ALUNOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ALUNOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MATRICULATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SOBRENOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TELEFONEMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EMAILTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FOTOPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
