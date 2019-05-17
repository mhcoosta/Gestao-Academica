Public Class FormProfessor

    Private Sub PROFESSORBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROFESSORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROFESSORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Escola2k19DataSet)

    End Sub

    Private Sub FormProfessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Escola2k19DataSet.PROFESSOR' table. You can move, or remove it, as needed.
        Me.PROFESSORTableAdapter.Fill(Me.Escola2k19DataSet.PROFESSOR)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If

    End Sub
End Class