Public Class Ejercicio3
    Dim puntajeEtapa3 As Double
    Private Sub Ejercicio3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombre
        lblFicha.Text = ficha
    End Sub

    Private Sub lblToEjercicio4_Click(sender As Object, e As EventArgs) Handles lblToEjercicio4.Click



        Dim preguntaConfirmar As DialogResult = MessageBox.Show("Una vez que avance esta etapa del examen, las respuestas no podrán ser modificadas", "Confirmar progreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If preguntaConfirmar = vbYes Then
            If radOpcion3.Checked Then
                puntajeEtapa3 += 12.5
            End If
            If radOpcion4.Checked Then
                puntajeEtapa3 += 12.5
            End If
            MsgBox("El puntaje actual es de: " & puntajeEtapa3.ToString)
            Module1.puntajeEje3 = puntajeEtapa3
            Me.Hide()
            Ejercicio4.Show()
        End If
    End Sub
End Class