Imports Negocio
Imports Entidad
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class listarProductos
    Private pl As New PedidoLogico()
    Private conRegistrosInactivos As Boolean = True
    Private filtroID As Integer = 0
    Private filtroNombre As String = ""
    Private culturaEstadosU As New CultureInfo("en-US")
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        cargarGridProductos()

    End Sub
    Private Sub cargarGridProductos()
        gvProductos.DataSource = Nothing
        gvProductos.Columns.Clear()
        Try
            Dim tablaClientes As DataTable = pl.obtenerTablaProductosCompletaV2()
            If tablaClientes IsNot Nothing Then
                configurarColumnasDataGridViewProducto()
                cargarAparienciaGridView(gvProductos)
                gvProductos.DataSource = tablaClientes
            Else
                MessageBox.Show("No se encontraron productos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub configurarColumnasDataGridViewProducto()
        Dim columnaID As New DataGridViewTextBoxColumn()
        columnaID.HeaderText = "ID Producto"
        columnaID.DataPropertyName = "ID"
        columnaID.Name = "ID Producto"
        columnaID.ReadOnly = True
        gvProductos.Columns.Add(columnaID)

        Dim columnaNombre As New DataGridViewTextBoxColumn()
        columnaNombre.HeaderText = "Nombre Producto"
        columnaNombre.DataPropertyName = "Nombre"
        columnaNombre.Name = "Nombre"
        columnaNombre.ReadOnly = True
        gvProductos.Columns.Add(columnaNombre)


        Dim columnaPrecio As New DataGridViewTextBoxColumn()
        columnaPrecio.HeaderText = "Precio "
        columnaPrecio.DataPropertyName = "Precio"
        columnaPrecio.Name = "Precio"
        columnaPrecio.DefaultCellStyle.Format = "C"
        columnaPrecio.ReadOnly = True
        gvProductos.Columns.Add(columnaPrecio)

        Dim columnaCategoria As New DataGridViewTextBoxColumn()
        columnaCategoria.HeaderText = "Categoria"
        columnaCategoria.DataPropertyName = "Categoria"
        columnaCategoria.Name = "Categoria"
        columnaCategoria.ReadOnly = True
        gvProductos.Columns.Add(columnaCategoria)

        Dim columnaEstado As New DataGridViewCheckBoxColumn
        columnaEstado.HeaderText = "Estado"
        columnaEstado.DataPropertyName = "Estado"
        columnaEstado.Name = "Estado"
        columnaEstado.ReadOnly = True
        gvProductos.Columns.Add(columnaEstado)
    End Sub
    Private Sub cargarAparienciaGridView(grd As DataGridView)

        grd.AllowUserToAddRows = False

        grd.DefaultCellStyle.ForeColor = Color.White
        grd.DefaultCellStyle.Font = New Font("Calibri", 12, FontStyle.Regular)
        grd.DefaultCellStyle.BackColor = Color.Black

        ' Cambia la apariencia de los headers de columna y fila - No funciona
        grd.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        grd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grd.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black
        grd.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White

        grd.RowHeadersDefaultCellStyle.BackColor = Color.Black
        grd.RowHeadersDefaultCellStyle.ForeColor = Color.White
        grd.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Black
        grd.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White

        grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        grd.AllowUserToResizeColumns = False
        grd.AllowUserToResizeRows = False
        grd.ColumnHeadersVisible = True
        grd.RowHeadersVisible = False
        grd.BorderStyle = BorderStyle.None


        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Private Sub filtrarDatosxEstado()
        Dim dt As DataTable = TryCast(gvProductos.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[Estado] = " & chkboxSoloActivos.Checked

        End If


        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub chkboxSoloActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxSoloActivos.CheckedChanged
        conRegistrosInactivos = chkboxSoloActivos.CheckState
        filtrarDatosxEstado()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        limpiarControles()
        cargarGridProductos()
    End Sub
    Private Sub limpiarControles()
        chkboxSoloActivos.Checked = True
        chkboxSoloActivos.Enabled = True
        txtID.Text = ""
        txtNombre.Text = ""
        filtroID = 0
        filtroNombre = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim estado As Boolean = validarIngresoDatos()
        If estado Then
            If filtroID <> 0 Then
                filtrarPorId()
            ElseIf Not String.IsNullOrEmpty(filtroNombre) Then
                filtrarPorNombre()
            End If
        End If
        limpiarControles()
    End Sub
    Private Function validarIngresoDatos() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) And String.IsNullOrEmpty(txtID.Text) Then
            Return False
        End If
        Dim id As Integer
        If Integer.TryParse(txtID.Text, id) Then
            filtroID = id
        Else
            filtroID = 0
        End If
        If esnombreValido(txtNombre.Text) Then
            filtroNombre = txtNombre.Text
        Else
            filtroNombre = ""
        End If

        Return True


    End Function

    Private Function esnombreValido(nombre As String) As Boolean
        Dim regExpreEmail As New Regex("^[A-ZÁÉÍÓÚÑa-záéíóúñ]+( [A-ZÁÉÍÓÚÑa-záéíóúñ]+)*$")
        Return regExpreEmail.IsMatch(nombre)
    End Function

    Private Sub filtrarPorId()

        chkboxSoloActivos.Enabled = True

        Dim dt As DataTable = TryCast(gvProductos.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[ID] = " & filtroID

        End If

        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub filtrarPorNombre()

        chkboxSoloActivos.Enabled = True

        Dim dt As DataTable = TryCast(gvProductos.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[Nombre] = '" & filtroNombre & "'"

        End If

        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

    End Sub
End Class