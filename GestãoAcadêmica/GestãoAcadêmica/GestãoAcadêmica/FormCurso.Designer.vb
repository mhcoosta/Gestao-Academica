<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCurso))
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim DESCRICAOLabel As System.Windows.Forms.Label
        Dim CARGAHORARIALabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Me.Escola2k19DataSet = New GestãoAcadêmica.escola2k19DataSet
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
        Me.TableAdapterManager = New GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
        Me.CURSOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.CURSOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox
        Me.NOMETextBox = New System.Windows.Forms.TextBox
        Me.DESCRICAOTextBox = New System.Windows.Forms.TextBox
        Me.CARGAHORARIATextBox = New System.Windows.Forms.TextBox
        Me.OBSTextBox = New System.Windows.Forms.TextBox
        CODIGOLabel = New System.Windows.Forms.Label
        NOMELabel = New System.Windows.Forms.Label
        DESCRICAOLabel = New System.Windows.Forms.Label
        CARGAHORARIALabel = New System.Windows.Forms.Label
        OBSLabel = New System.Windows.Forms.Label
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CURSOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Escola2k19DataSet
        '
        Me.Escola2k19DataSet.DataSetName = "escola2k19DataSet"
        Me.Escola2k19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CURSOBindingSource
        '
        Me.CURSOBindingSource.DataMember = "CURSO"
        Me.CURSOBindingSource.DataSource = Me.Escola2k19DataSet
        '
        'CURSOTableAdapter
        '
        Me.CURSOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CURSOBindingNavigator
        '
        Me.CURSOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CURSOBindingNavigator.BindingSource = Me.CURSOBindingSource
        Me.CURSOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CURSOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CURSOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CURSOBindingNavigatorSaveItem})
        Me.CURSOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CURSOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CURSOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CURSOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CURSOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CURSOBindingNavigator.Name = "CURSOBindingNavigator"
        Me.CURSOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CURSOBindingNavigator.Size = New System.Drawing.Size(279, 25)
        Me.CURSOBindingNavigator.TabIndex = 0
        Me.CURSOBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CURSOBindingNavigatorSaveItem
        '
        Me.CURSOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CURSOBindingNavigatorSaveItem.Image = CType(resources.GetObject("CURSOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CURSOBindingNavigatorSaveItem.Name = "CURSOBindingNavigatorSaveItem"
        Me.CURSOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CURSOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(13, 71)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Location = New System.Drawing.Point(126, 68)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(115, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(13, 97)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(126, 94)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(115, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'DESCRICAOLabel
        '
        DESCRICAOLabel.AutoSize = True
        DESCRICAOLabel.Location = New System.Drawing.Point(13, 123)
        DESCRICAOLabel.Name = "DESCRICAOLabel"
        DESCRICAOLabel.Size = New System.Drawing.Size(72, 13)
        DESCRICAOLabel.TabIndex = 5
        DESCRICAOLabel.Text = "DESCRICAO:"
        '
        'DESCRICAOTextBox
        '
        Me.DESCRICAOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "DESCRICAO", True))
        Me.DESCRICAOTextBox.Location = New System.Drawing.Point(126, 120)
        Me.DESCRICAOTextBox.Name = "DESCRICAOTextBox"
        Me.DESCRICAOTextBox.Size = New System.Drawing.Size(115, 20)
        Me.DESCRICAOTextBox.TabIndex = 6
        '
        'CARGAHORARIALabel
        '
        CARGAHORARIALabel.AutoSize = True
        CARGAHORARIALabel.Location = New System.Drawing.Point(13, 149)
        CARGAHORARIALabel.Name = "CARGAHORARIALabel"
        CARGAHORARIALabel.Size = New System.Drawing.Size(96, 13)
        CARGAHORARIALabel.TabIndex = 7
        CARGAHORARIALabel.Text = "CARGAHORARIA:"
        '
        'CARGAHORARIATextBox
        '
        Me.CARGAHORARIATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "CARGAHORARIA", True))
        Me.CARGAHORARIATextBox.Location = New System.Drawing.Point(126, 146)
        Me.CARGAHORARIATextBox.Name = "CARGAHORARIATextBox"
        Me.CARGAHORARIATextBox.Size = New System.Drawing.Size(115, 20)
        Me.CARGAHORARIATextBox.TabIndex = 8
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(13, 175)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 9
        OBSLabel.Text = "OBS:"
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CURSOBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(126, 172)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(115, 51)
        Me.OBSTextBox.TabIndex = 10
        '
        'FormCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 259)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(DESCRICAOLabel)
        Me.Controls.Add(Me.DESCRICAOTextBox)
        Me.Controls.Add(CARGAHORARIALabel)
        Me.Controls.Add(Me.CARGAHORARIATextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.CURSOBindingNavigator)
        Me.Name = "FormCurso"
        Me.Text = "Cadastro de Cursos"
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CURSOBindingNavigator.ResumeLayout(False)
        Me.CURSOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Escola2k19DataSet As GestãoAcadêmica.escola2k19DataSet
    Friend WithEvents CURSOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CURSOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents TableAdapterManager As GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CURSOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CURSOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CODIGOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NOMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DESCRICAOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CARGAHORARIATextBox As System.Windows.Forms.TextBox
    Friend WithEvents OBSTextBox As System.Windows.Forms.TextBox
End Class
