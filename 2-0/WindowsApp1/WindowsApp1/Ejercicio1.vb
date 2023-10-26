Public Class Ejercicio1
    Dim puntajeEtapa1 As Double
    Dim confirmar As String
    Private Sub Ejercicio1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombre
        lblFicha.Text = ficha


    End Sub

    Private Sub lblToEjercicio2_Click(sender As Object, e As EventArgs) Handles lblToEjercicio2.Click



        Dim preguntaConfirmar As DialogResult = MessageBox.Show("Una vez que avance esta etapa del examen, las respuestas no podrán ser modificadas", "Confirmar progreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If preguntaConfirmar = vbYes Then
            If radOpcion1.Checked Then
                puntajeEtapa1 += 12.5
            End If
            If radOpcion6.Checked Then
                puntajeEtapa1 += 12.5
            End If
            Module1.puntajeEje1 = puntajeEtapa1
            MsgBox("El puntaje actual es de: " & puntajeEtapa1.ToString)
            Me.Hide()
            Ejercicio2.Show()
        End If
    End Sub
End Class