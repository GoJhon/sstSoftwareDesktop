Imports MySql.Data.MySqlClient

Public Class Form1

    Private conexion As New MySqlConnection("Server=bp80oeapywtl9wk7ydqb-mysql.services.clever-cloud.com;Database=bp80oeapywtl9wk7ydqb;User=uw9i7sr6sfzkeodr;Password=MsoV7P5r4CxkEFVRBZGq;Port=3306;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion.Open()
            MsgBox("Se hizo la conexión exitosamente")

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Console.WriteLine("Cerró la conexión")
            End If
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            Module1.nombre = txtNombre.Text
            Module1.documento = txtDocumento.Text
            Module1.ficha = txtFicha.Text
            If txtFicha.Text = "" Or txtNombre.Text = "" Or txtDocumento.Text = "" Then
                MessageBox.Show("Llenar todos los campos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim f2 As New actividad()
                f2.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show("Llenar todos los campos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class
