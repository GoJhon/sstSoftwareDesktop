Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As New SqlConnection("server=DESKTOP-JHU0H9L\SQLEXPRESS;database=;integrated security = true")
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

        'If Double.Parse(cmdTipoDocumento.SelectedItem) = 0 Then
        'Console.WriteLine("cc fue escogido")
        'MsgBox("el escogido fue" & cmdTipoDocumento.SelectedItem.ToString)

        'nd If
        MsgBox("el escogido fue" & cmdTipoDocumento.SelectedItem.ToString)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdTipoDocumento.FlatStyle = FlatStyle.Flat
        cmdTipoDocumento.BackColor = Color.White
        cmdTipoDocumento.ForeColor = Color.Black

        cmdTipoDocumento.SelectedItem = 0

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs)
        Try
            If cmdTipoDocumento.SelectedItem = 0 Then
                Console.WriteLine("cc fue escogido")


            End If
            Module1.nombre = txtNombre.Text
            Module1.apellido = txtApellido.Text
            'Module1.tipoDocumento = txt
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

    Private Sub lblIrLogin_Click(sender As Object, e As EventArgs) Handles lblIrLogin.Click
        Dim sesionprofe As New inicio_sesion()
        sesionprofe.Show()
        Me.Hide()
    End Sub

    Private Sub lblIrTest_Click(sender As Object, e As EventArgs) Handles lblIrTest.Click
        Try
            Module1.nombre = txtNombre.Text
            Module1.documento = txtDocumento.Text
            Module1.ficha = txtFicha.Text
            If txtFicha.Text = "" Or txtNombre.Text = "" Or txtDocumento.Text = "" Then
                MessageBox.Show("Llenar todos los campos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim f2 As New actividad()
                Dim ejercicio1 As New Ejercicio1()
                Me.Hide()
                ejercicio1.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Llenar todos los campos correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdTipoDocumento.SelectedIndexChanged


    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub
End Class
