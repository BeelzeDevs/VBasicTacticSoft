Imports Negocio
Imports Entidad
Imports System.Globalization

Public Class listarVentas

    Private pl As New PedidoLogico()
    Private conRegistrosInactivos As Boolean = True

    Public Sub New()
        ' llamada es exigida por el diseñador.
        InitializeComponent()
        Dim culturaArgentina As New CultureInfo("es-AR")
        Threading.Thread.CurrentThread.CurrentCulture = culturaArgentina
        Threading.Thread.CurrentThread.CurrentUICulture = culturaArgentina

        ' Cargar los datos al inicializar el formulario.
        cargarFecha()
        cargarGridVentas()
        panelDetalleVentas.Visible = False

    End Sub

    Private Sub cargarFecha()
        fechaSeleccionada.Format = DateTimePickerFormat.Custom
        fechaSeleccionada.CustomFormat = "dd/MM/yyyy"
        fechaSeleccionada.MinDate = New DateTime(2000, 1, 1)
        fechaSeleccionada.MaxDate = DateTime.Now
        fechaSeleccionada.Value = DateTime.Now
    End Sub

    Private Sub configurarColumnasDataGridViewVenta()


        Dim columnaBtnSeleccionar As New DataGridViewButtonColumn()
        columnaBtnSeleccionar.Text = "Seleccionar"
        columnaBtnSeleccionar.Name = "btnSeleccionarVenta"
        columnaBtnSeleccionar.HeaderText = " "
        columnaBtnSeleccionar.UseColumnTextForButtonValue = True
        columnaBtnSeleccionar.Width = 90
        gvVentas.Columns.Add(columnaBtnSeleccionar)



        Dim columnaID As New DataGridViewTextBoxColumn()
        columnaID.HeaderText = "ID Venta"
        columnaID.DataPropertyName = "ID"
        columnaID.Name = "ID Venta"
        columnaID.ReadOnly = True
        gvVentas.Columns.Add(columnaID)

        Dim columnaIDCliente As New DataGridViewTextBoxColumn()
        columnaIDCliente.HeaderText = "ID Cliente"
        columnaIDCliente.DataPropertyName = "IDCliente"
        columnaIDCliente.Name = "ID Cliente"
        columnaID.ReadOnly = True
        gvVentas.Columns.Add(columnaIDCliente)

        Dim columnaNombreCliente As New DataGridViewTextBoxColumn()
        columnaNombreCliente.HeaderText = "Nombre Cliente"
        columnaNombreCliente.DataPropertyName = "Cliente"
        columnaNombreCliente.Name = "Nombre Cliente"
        columnaNombreCliente.Width = 150
        columnaID.ReadOnly = True
        gvVentas.Columns.Add(columnaNombreCliente)

        Dim columnaFecha As New DataGridViewTextBoxColumn()
        columnaFecha.HeaderText = "Fecha"
        columnaFecha.DataPropertyName = "Fecha"
        columnaFecha.Name = "Fecha"
        gvVentas.Columns.Add(columnaFecha)

        Dim columnaTotal As New DataGridViewTextBoxColumn()
        columnaTotal.HeaderText = "Total"
        columnaTotal.DataPropertyName = "Total"
        columnaTotal.Name = "Total"
        columnaTotal.DefaultCellStyle.Format = "C2"
        gvVentas.Columns.Add(columnaTotal)

        Dim columnaEstado As New DataGridViewCheckBoxColumn
        columnaEstado.HeaderText = "Estado"
        columnaEstado.DataPropertyName = "Estado"
        columnaEstado.Name = "Estado"
        gvVentas.Columns.Add(columnaEstado)

    End Sub

    Private Sub cargarGridVentas()
        gvVentas.DataSource = Nothing
        gvVentas.Columns.Clear()
        Try
            Dim tablaVentas As DataTable = pl.obtenerTablaVentasCompleta()
            If tablaVentas IsNot Nothing Then
                configurarColumnasDataGridViewVenta()
                cargarAparienciaGridView(gvVentas)
                gvVentas.DataSource = tablaVentas
            Else
                MessageBox.Show("No se encontraron ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
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


        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



    End Sub
    Private Sub configurarColumnasGridDetalleVenta()

        Dim colIDDetalle As New DataGridViewTextBoxColumn()
        colIDDetalle.HeaderText = "ID Detalle"
        colIDDetalle.DataPropertyName = "ID"
        colIDDetalle.Name = "ID Detalle"
        colIDDetalle.ReadOnly = True
        gvDetalleVenta.Columns.Add(colIDDetalle)

        Dim colIDProducto As New DataGridViewTextBoxColumn()
        colIDProducto.HeaderText = "ID Producto"
        colIDProducto.DataPropertyName = "IDProducto"
        colIDProducto.Name = "ID Producto"
        colIDProducto.ReadOnly = True
        gvDetalleVenta.Columns.Add(colIDProducto)


        Dim colNombreProd As New DataGridViewTextBoxColumn()
        colNombreProd.HeaderText = "Nombre"
        colNombreProd.DataPropertyName = "Nombre"
        colNombreProd.ReadOnly = True
        gvDetalleVenta.Columns.Add(colNombreProd)


        Dim colPU As New DataGridViewTextBoxColumn()
        colPU.HeaderText = "PU"
        colPU.DataPropertyName = "PrecioUnitario"
        colPU.DefaultCellStyle.Format = "C"
        gvDetalleVenta.Columns.Add(colPU)

        Dim colCant As New DataGridViewTextBoxColumn()
        colCant.HeaderText = "Cantidad"
        colCant.DataPropertyName = "Cantidad"
        gvDetalleVenta.Columns.Add(colCant)

        Dim colDetalleTotal As New DataGridViewTextBoxColumn()
        colDetalleTotal.HeaderText = "Precio Total"
        colDetalleTotal.DataPropertyName = "PrecioTotal"
        colDetalleTotal.DefaultCellStyle.Format = "C"
        colDetalleTotal.ReadOnly = True
        gvDetalleVenta.Columns.Add(colDetalleTotal)
    End Sub



    Private Sub cargarGridItemsdeVenta(venta As Entidad.Venta)

        Try
            If pl.existeVenta(venta) Then
                Dim tablaDetalleVentas As DataTable = pl.obtenerTablaDetalleVentasCompleta(venta)
                If tablaDetalleVentas IsNot Nothing AndAlso tablaDetalleVentas.Rows.Count > 0 Then
                    configurarColumnasGridDetalleVenta()
                    cargarAparienciaGridView(gvDetalleVenta)
                    gvDetalleVenta.DataSource = tablaDetalleVentas
                Else
                    panelDetalleVentas.Visible = False
                End If

            Else
                panelDetalleVentas.Visible = False
                MessageBox.Show("No se encontraron ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            panelDetalleVentas.Visible = False
            MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        gvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub

    Private Sub gvVentas_CellSelectClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvVentas.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvVentas.Columns("btnSeleccionarVenta").Index Then

            gvDetalleVenta.DataSource = Nothing
            panelDetalleVentas.Visible = True
            Dim venta As New Entidad.Venta
            venta.ID = gvVentas.Rows(e.RowIndex).Cells("ID Venta").Value
            cargarGridItemsdeVenta(venta)

        End If

    End Sub
    Private Sub filtrarDatosxEstado()
        Dim dt As DataTable = TryCast(gvVentas.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[Estado] = " & conRegistrosInactivos

        End If


        gvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub filtrarDatosxFecha()
        Dim fecha As Date = fechaSeleccionada.Value

        Dim venta As Entidad.Venta = New Entidad.Venta()
        venta.Fecha = fecha

        gvVentas.DataSource = Nothing
        gvVentas.Columns.Clear()
        Try
            Dim tablaVentas As DataTable = pl.obtenerTablaVentasFiltroFecha(venta)
            If tablaVentas IsNot Nothing Then
                configurarColumnasDataGridViewVenta()
                cargarAparienciaGridView(gvVentas)
                gvVentas.DataSource = tablaVentas
            Else
                MessageBox.Show("No se encontraron ventas para mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders


    End Sub

    Private Sub chkboxSoloActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxSoloActivos.CheckedChanged
        panelDetalleVentas.Visible = False
        conRegistrosInactivos = chkboxSoloActivos.CheckState
        filtrarDatosxEstado()

    End Sub

    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        panelDetalleVentas.Visible = False
        chkboxSoloActivos.Checked = True
        conRegistrosInactivos = chkboxSoloActivos.CheckState

        filtrarDatosxFecha()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkboxSoloActivos.Checked = True
        panelDetalleVentas.Visible = False
        cargarGridVentas()
    End Sub
End Class
