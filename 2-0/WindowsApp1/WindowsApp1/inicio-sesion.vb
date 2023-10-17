Public Class inicio_sesion
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Hiciste clic en el Label.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub inicio_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblIrTest_Click(sender As Object, e As EventArgs) Handles lblIrTest.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class