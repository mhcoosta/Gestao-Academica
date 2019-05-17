<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBoletim
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
        Dim CRLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBoletim))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ALUNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Escola2k19DataSet = New GestãoAcadêmica.escola2k19DataSet
        Me.Button1 = New System.Windows.Forms.Button
        Me.ALUNOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
        Me.TableAdapterManager = New GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
        Me.CRTextBox = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.CONSULTARBOLETIMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTARBOLETIMTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.CONSULTARBOLETIMTableAdapter
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.ALUNOToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.ALUNOToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.CONSULTARBOLETIMDataGridView = New System.Windows.Forms.DataGridView
        Me.CURSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CURSOTableAdapter = New GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CRLabel = New System.Windows.Forms.Label
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARBOLETIMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.CONSULTARBOLETIMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRLabel
        '
        CRLabel.AutoSize = True
        CRLabel.Location = New System.Drawing.Point(129, 339)
        CRLabel.Name = "CRLabel"
        CRLabel.Size = New System.Drawing.Size(25, 13)
        CRLabel.TabIndex = 3
        CRLabel.Text = "CR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecione o Aluno:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ALUNOBindingSource
        Me.ComboBox1.DisplayMember = "NOME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "NOME"
        '
        'ALUNOBindingSource
        '
        Me.ALUNOBindingSource.DataMember = "ALUNO"
        Me.ALUNOBindingSource.DataSource = Me.Escola2k19DataSet
        '
        'Escola2k19DataSet
        '
        Me.Escola2k19DataSet.DataSetName = "escola2k19DataSet"
        Me.Escola2k19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Localizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ALUNOTableAdapter
        '
        Me.ALUNOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUNOTableAdapter = Me.ALUNOTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CURSOTableAdapter = Me.CURSOTableAdapter
        Me.TableAdapterManager.MATRICULATableAdapter = Nothing
        Me.TableAdapterManager.PROFESSORTableAdapter = Nothing
        Me.TableAdapterManager.TURMATableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRTextBox
        '
        Me.CRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUNOBindingSource, "CR", True))
        Me.CRTextBox.Enabled = False
        Me.CRTextBox.Location = New System.Drawing.Point(160, 336)
        Me.CRTextBox.Name = "CRTextBox"
        Me.CRTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CRTextBox.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CONSULTARBOLETIMBindingSource
        '
        Me.CONSULTARBOLETIMBindingSource.DataMember = "CONSULTARBOLETIM"
        Me.CONSULTARBOLETIMBindingSource.DataSource = Me.Escola2k19DataSet
        '
        'CONSULTARBOLETIMTableAdapter
        '
        Me.CONSULTARBOLETIMTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALUNOToolStripLabel, Me.ALUNOToolStripTextBox, Me.FillToolStripButton, Me.ToolStripButton1})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(378, 25)
        Me.FillToolStrip.TabIndex = 6
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'ALUNOToolStripLabel
        '
        Me.ALUNOToolStripLabel.Name = "ALUNOToolStripLabel"
        Me.ALUNOToolStripLabel.Size = New System.Drawing.Size(50, 22)
        Me.ALUNOToolStripLabel.Text = "ALUNO:"
        '
        'ALUNOToolStripTextBox
        '
        Me.ALUNOToolStripTextBox.Name = "ALUNOToolStripTextBox"
        Me.ALUNOToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'CONSULTARBOLETIMDataGridView
        '
        Me.CONSULTARBOLETIMDataGridView.AutoGenerateColumns = False
        Me.CONSULTARBOLETIMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONSULTARBOLETIMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CONSULTARBOLETIMDataGridView.DataSource = Me.CONSULTARBOLETIMBindingSource
        Me.CONSULTARBOLETIMDataGridView.Location = New System.Drawing.Point(13, 76)
        Me.CONSULTARBOLETIMDataGridView.Name = "CONSULTARBOLETIMDataGridView"
        Me.CONSULTARBOLETIMDataGridView.Size = New System.Drawing.Size(342, 220)
        Me.CONSULTARBOLETIMDataGridView.TabIndex = 7
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ALUNO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ALUNO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CURSO"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.CURSOBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "NOME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CURSO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "NOME"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOTA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOTA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FormBoletim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 379)
        Me.Controls.Add(Me.CONSULTARBOLETIMDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(CRLabel)
        Me.Controls.Add(Me.CRTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBoletim"
        Me.Text = "Emissão de Boletim"
        CType(Me.ALUNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Escola2k19DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARBOLETIMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.CONSULTARBOLETIMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Escola2k19DataSet As GestãoAcadêmica.escola2k19DataSet
    Friend WithEvents ALUNOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALUNOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.ALUNOTableAdapter
    Friend WithEvents TableAdapterManager As GestãoAcadêmica.escola2k19DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CONSULTARBOLETIMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONSULTARBOLETIMTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.CONSULTARBOLETIMTableAdapter
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ALUNOToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ALUNOToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CONSULTARBOLETIMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CURSOTableAdapter As GestãoAcadêmica.escola2k19DataSetTableAdapters.CURSOTableAdapter
    Friend WithEvents CURSOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
