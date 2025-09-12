Imports System.Data.OleDb

Public Class Form1
    Dim rutaExcel As String = "C:\Users\wholl\Desktop\Lista.xls"
    Dim conexion As OleDbConnection
    Dim dtDatos As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        txtDescripcion.ReadOnly = True
        txtPrecio.ReadOnly = True
        txtStock.ReadOnly = True
        Me.Text = "Epe1 Juan Pablo Hernandes - Walter Hollub Rojas"
    End Sub
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim cadenaConexion As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaExcel & ";Extended Properties='Excel 12.0 Xml;HDR=YES';"

            conexion = New OleDbConnection(cadenaConexion)
            conexion.Open()


            Dim consulta As String = "SELECT * FROM [Listado de Productos$]"
            Dim adaptador As New OleDbDataAdapter(consulta, conexion)
            Dim ds As New DataSet()
            adaptador.Fill(ds, "Datos")
            dtDatos = ds.Tables("Datos")

            cmbProductos.Items.Clear()

            For Each fila As DataRow In dtDatos.Rows
                cmbProductos.Items.Add(fila("idProducto").ToString())
            Next

            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub


    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        Try
            Dim codigoSeleccionado As String = cmbProductos.SelectedItem.ToString()
            Dim filas() As DataRow = dtDatos.Select("idProducto= '" & codigoSeleccionado & "'")

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)
                txtDescripcion.Text = fila("NombreProducto").ToString()
                txtPrecio.Text = fila("PrecioUnidad").ToString()
                txtStock.Text = fila("UnidadesEnExistencia").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al mostrar datos: " & ex.Message)
        End Try
    End Sub
End Class
