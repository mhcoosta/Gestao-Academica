Public Class FormBoletim

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormBoletim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Escola2k19DataSet.CURSO' table. You can move, or remove it, as needed.
        Me.CURSOTableAdapter.Fill(Me.Escola2k19DataSet.CURSO)
        'TODO: This line of code loads data into the 'Escola2k19DataSet.ALUNO' table. You can move, or remove it, as needed.
        Me.ALUNOTableAdapter.Fill(Me.Escola2k19DataSet.ALUNO)

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.CONSULTARBOLETIMTableAdapter.Fill(Me.Escola2k19DataSet.CONSULTARBOLETIM, ComboBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim linha As DataGridViewRow
        Dim media As Double
        Dim cont As Integer
        For Each linha In CONSULTARBOLETIMDataGridView.Rows
            media = media + linha.Cells(2).Value
            cont = cont + 1
        Next
        cont = cont + 1
        media = media / cont
        CRTextBox.Text = media
        Me.Validate()
        Me.ALUNOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2k19DataSet)
    End Sub
End Class