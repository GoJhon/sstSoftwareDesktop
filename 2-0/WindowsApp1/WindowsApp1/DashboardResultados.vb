Imports MySql.Data.MySqlClient

Public Class DashboardResultados
    Dim conexion As MySqlConnection

    Private Sub DashboardResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection("Server=bp80oeapywtl9wk7ydqb-mysql.services.clever-cloud.com;Database=bp80oeapywtl9wk7ydqb;User=uw9i7sr6sfzkeodr;Password=MsoV7P5r4CxkEFVRBZGq;Port=3306;")

        Try
            conexion.Open()
            llenar_grid()
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub llenar_grid()
        Dim consulta As String = "select * from puntajes"
        Dim adaptador As New MySqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
