Public Class Ejercicio4
    Dim puntajeEtapa4 As Double
    Private Sub Ejercicio4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombre
        lblFicha.Text = ficha
    End Sub

    Private Sub lblFinalizar_Click(sender As Object, e As EventArgs) Handles lblFinalizar.Click

        MsgBox("El puntaje actual es de: " & puntajeEtapa4.ToString)
        Dim preguntaConfirmar As DialogResult = MessageBox.Show("Una vez que avance esta etapa del examen, las respuestas no podrán ser modificadas", "Confirmar progreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If preguntaConfirmar = vbYes Then
            If radOpcion3.Checked Then
                puntajeEtapa4 += 12.5
            End If
            If radOpcion4.Checked Then
                puntajeEtapa4 += 12.5
            End If

            Module1.puntajeEje4 = puntajeEtapa4
            Dim total As Double = Module1.puntajeEje1 + Module1.puntajeEje2 + Module1.puntajeEje3 + Module1.puntajeEje4
            MsgBox("El puntaje total fue: " & Math.Round(total, 2).ToString())


            Me.Close()

        End If
    End Sub
End Class