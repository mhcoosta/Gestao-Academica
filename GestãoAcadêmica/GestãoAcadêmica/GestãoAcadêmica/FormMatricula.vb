Public Class FormMatricula

    Private Sub TURMABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TURMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TURMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2k19DataSet)

    End Sub

    Private Sub FormMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Escola2k19DataSet.ALUNO' table. You can move, or remove it, as needed.
        Me.ALUNOTableAdapter.Fill(Me.Escola2k19DataSet.ALUNO)
        'TODO: This line of code loads data into the 'Escola2k19DataSet.MATRICULA' table. You can move, or remove it, as needed.
        Me.MATRICULATableAdapter.Fill(Me.Escola2k19DataSet.MATRICULA)
        'TODO: This line of code loads data into the 'Escola2k19DataSet.CURSO' table. You can move, or remove it, as needed.
        Me.CURSOTableAdapter.Fill(Me.Escola2k19DataSet.CURSO)
        'TODO: This line of code loads data into the 'Escola2k19DataSet.PROFESSOR' table. You can move, or remove it, as needed.
        Me.PROFESSORTableAdapter.Fill(Me.Escola2k19DataSet.PROFESSOR)
        'TODO: This line of code loads data into the 'Escola2k19DataSet.TURMA' table. You can move, or remove it, as needed.
        Me.TURMATableAdapter.Fill(Me.Escola2k19DataSet.TURMA)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim linha As DataGridViewRow
        Dim media As Double
        Dim cont As Integer
        For Each linha In MATRICULADataGridView.Rows
            media = media + linha.Cells(3).Value
            cont = cont + 1
        Next
        cont = cont + 1
        media = media / cont
        MEDIATextBox.Text = media
    End Sub
End Class