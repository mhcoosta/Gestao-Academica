<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicial
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cadastro de Professores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(145, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(218, 74)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cadastro de Alunos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(145, 336)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(218, 74)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Gerenciamento de Matrículas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(145, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(218, 74)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Cadastro de Cursos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(145, 442)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(218, 74)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Emissão de Boletim"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FormInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 559)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormInicial"
        Me.Text = "Gestão Acadêmica"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
