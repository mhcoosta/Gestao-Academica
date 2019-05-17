Public Class FormAluno

    Private Sub ALUNOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALUNOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUNOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2k19DataSet)

    End Sub

    Private Sub FormAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Escola2k19DataSet.ALUNO' table. You can move, or remove it, as needed.
        Me.ALUNOTableAdapter.Fill(Me.Escola2k19DataSet.ALUNO)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class