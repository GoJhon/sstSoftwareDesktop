Imports MySql.Data.MySqlClient

Public Class actividad
    Dim nombre As String = Module1.nombre
    Dim ficha As String = Module1.ficha
    Dim documento As String = Module1.documento

    Private conexion As New MySqlConnection("Server=bp80oeapywtl9wk7ydqb-mysql.services.clever-cloud.com;Database=bp80oeapywtl9wk7ydqb;User=uw9i7sr6sfzkeodr;Password=MsoV7P5r4CxkEFVRBZGq;Port=3306;")

    Private Sub actividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = nombre
        lblFicha.Text = ficha
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles radOpcion12.CheckedChanged

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles radOpcion14.CheckedChanged

    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles radOpcion27.CheckedChanged

    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles radOpcion30.CheckedChanged

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim ac As Integer = 0

        If radOpcion1.Checked Then
            ac += 10
        End If

        If radOpcion6.Checked Then
            ac += 10
        End If

        If radOpcion9.Checked Then
            ac += 10
        End If

        If radOpcion12.Checked Then
            ac += 10
        End If

        If radOpcion15.Checked Then
            ac += 10
        End If

        If radOpcion18.Checked Then
            ac += 10
        End If

        If radOpcion19.Checked Then
            ac += 10
        End If

        If radOpcion22.Checked Then
            ac += 10
        End If

        If radOpcion25.Checked Then
            ac += 10
        End If

        If radOpcion28.Checked Then
            ac += 10
        End If


        Try
            conexion.Open()

            Dim query As String = "INSERT INTO puntajes (nombre, documento, ficha, puntaje) VALUES (@nombre, @documento, @ficha, @puntaje)"
            Dim cmd As New MySqlCommand(query, conexion)

            ' Define los parámetros con los valores que deseas insertar
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@documento", documento)
            cmd.Parameters.AddWithValue("@ficha", ficha)
            cmd.Parameters.AddWithValue("@puntaje", ac)

            ' Ejecuta la inserción
            cmd.ExecuteNonQuery()


            conexion.Close()
            MessageBox.Show("Se envio evidencia. Su nota fue de " & ac, "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Form1.Show()
        Catch ex As Exception
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Console.WriteLine("Cerró la conexión")
            End If

            MessageBox.Show("Error de conexion, verifique internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Console.WriteLine("Cerró la conexión")
            End If
        End Try
    End Sub

    Private Sub lblFicha_Click(sender As Object, e As EventArgs) Handles lblFicha.Click

    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub
End Class