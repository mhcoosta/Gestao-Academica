Public Class FormCurso

    Private Sub CURSOBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CURSOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CURSOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2k19DataSet)

    End Sub

    Private Sub FormCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Escola2k19DataSet.CURSO' table. You can move, or remove it, as needed.
        Me.CURSOTableAdapter.Fill(Me.Escola2k19DataSet.CURSO)

    End Sub
End Class