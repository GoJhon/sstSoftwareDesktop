Public Class Ejercicio2
    Dim contador As Integer
    Dim puntajeEtapa2 As Double = 0
    Private Sub Ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombre
        lblFicha.Text = ficha
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblC1.Click
        lblC1.BackColor = Color.Green
        puntajeEtapa2 += 8.333333
        contador += 1
        VerificarClick()
    End Sub

    Public Sub VerificarClick()
        If contador >= 3 Then
            gBoxContenedor.Enabled = False
        Else
            gBoxContenedor.Enabled = True
        End If
    End Sub

    Private Sub lblC2_Click(sender As Object, e As EventArgs) Handles lblC2.Click
        lblC2.BackColor = Color.Green
        puntajeEtapa2 += 8.333333
        contador += 1
        VerificarClick()
    End Sub

    Private Sub lblPrueba_Click(sender As Object, e As EventArgs)
        MsgBox("Hola :D")

    End Sub

    Private Sub lblC4_Click(sender As Object, e As EventArgs) Handles lblC4.Click
        lblC4.BackColor = Color.Green
        puntajeEtapa2 += 8.333333
        contador += 1
        VerificarClick()
    End Sub

    Private Sub lblC3_Click(sender As Object, e As EventArgs) Handles lblC3.Click
        lblC3.BackColor = Color.Green
        contador += 1
        puntajeEtapa2 += 8.333333
        VerificarClick()
    End Sub

    Private Sub lblI1_Click(sender As Object, e As EventArgs) Handles lblI1.Click
        lblI1.BackColor = Color.Green
        contador += 1
        VerificarClick()
    End Sub

    Private Sub lblI4_Click(sender As Object, e As EventArgs) Handles lblI4.Click
        lblI4.BackColor = Color.Green
        contador += 1
        VerificarClick()
    End Sub

    Private Sub lblI2_Click(sender As Object, e As EventArgs) Handles lblI2.Click
        lblI2.BackColor = Color.Green
        contador += 1
        VerificarClick()
    End Sub

    Private Sub lblI3_Click(sender As Object, e As EventArgs) Handles lblI3.Click
        lblI3.BackColor = Color.Green
        contador += 1
        VerificarClick()
    End Sub

    Private Sub gBoxContenedor_Enter(sender As Object, e As EventArgs) Handles gBoxContenedor.Enter

    End Sub

    Private Sub lblIrLimpiar_Click(sender As Object, e As EventArgs) Handles lblIrLimpiar.Click
        puntajeEtapa2 = 0
        lblI1.BackColor = Color.Transparent
        lblI2.BackColor = Color.Transparent
        lblI3.BackColor = Color.Transparent
        lblI4.BackColor = Color.Transparent
        lblC1.BackColor = Color.Transparent
        lblC2.BackColor = Color.Transparent
        lblC3.BackColor = Color.Transparent
        lblC4.BackColor = Color.Transparent
        contador = 0

        VerificarClick()

    End Sub

    Private Sub lblToEjercicio3_Click(sender As Object, e As EventArgs) Handles lblToEjercicio3.Click
        MsgBox("El puntaje actual es de: " & Math.Round(puntajeEtapa2, 2).ToString)
        Dim preguntaConfirmar As DialogResult = MessageBox.Show("Una vez que avance esta etapa del examen, las respuestas no podrán ser modificadas", "Confirmar progreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If preguntaConfirmar = vbYes Then
            Module1.puntajeEje2 = Math.Round(puntajeEtapa2, 2)
            Me.Hide()
            Ejercicio3.Show()
        End If
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub
End Class