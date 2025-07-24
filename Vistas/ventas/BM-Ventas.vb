
Imports Negocio
Imports Entidad
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Diagnostics.Stopwatch


Public Class BM_Ventas
    Private pl As New PedidoLogico()
    Private itemABuscar As New Entidad.VentaItem()
    Private itemAModificar As New Entidad.VentaItem()
    Private culturaArgentina As New CultureInfo("es-AR")
    Private culturaEstadosU As New CultureInfo("en-US")
    Private WithEvents gvDetalleVentas As CustomDataGridView
    Private lastClickTime As DateTime = DateTime.MinValue




    Public Sub New()
        InitializeComponent()

        itemABuscar.IdVenta = 1

        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        flayoutDetalleVentas.Controls.Add(gvDetalleVentas)
        flayoutDetalleVentas.Visible = True
        gvDetalleVentas.Visible = True

        AddHandler gvDetalleVentas.CellContentClick, AddressOf gvDetalleVentas_CellContentClick
        AddHandler gvDetalleVentas.CellEndEdit, AddressOf gvDetalleVentas_CellEndEdit
        AddHandler gvDetalleVentas.CellBeginEdit, AddressOf gvDetalleVentas_CellBeginEdit
        AddHandler gvDetalleVentas.CellClick, AddressOf gvDetalleVentas_CellClick
        AddHandler gvDetalleVentas.CellMouseClick, AddressOf gvDetalleVentas_CellMouseClick

        configurarGridTOTALDetalleVenta()
        cargarGridDetalleVentas()
    End Sub

    Private Sub cargarGridDetalleVentas()
        If Not pl.existeVenta(itemABuscar) Then Return

        gvDetalleVentas.DataSource = Nothing
        gvDetalleVentas.Columns.Clear()
        gvDetalleVentas.AutoGenerateColumns = False



        Try
            Dim tablaVentaItems As DataTable = pl.obtenerTablaDetalleVenta(itemABuscar)

            If tablaVentaItems IsNot Nothing Then
                ' Estética
                cargarAparienciaGridView(gvDetalleVentas)
                '  columnas 
                configurarColumnasGridDetalleVenta()
                '  DataSource
                gvDetalleVentas.DataSource = tablaVentaItems


                ' Total
                Dim total As Decimal = calcularTotal(tablaVentaItems)
                CrearFilaTotalEnGridTotal(total)
            Else
                MessageBox.Show("No se encontraron ventas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvDetalleVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvDetalleVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

        gvTotalVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvTotalVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
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

        grd.BackgroundColor = Color.FromArgb(87, 96, 111)
        grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



    End Sub

    Private Sub configurarColumnasGridDetalleVenta()

        Dim columnaBtnEliminar As New DataGridViewButtonColumn()
        columnaBtnEliminar.Text = "Eliminar"
        columnaBtnEliminar.Name = "btnEliminar"
        columnaBtnEliminar.HeaderText = " "
        columnaBtnEliminar.UseColumnTextForButtonValue = True
        columnaBtnEliminar.Width = 90
        gvDetalleVentas.Columns.Add(columnaBtnEliminar)

        Dim colBtnModificar As New DataGridViewButtonColumn()
        colBtnModificar.Text = "Modificar"
        colBtnModificar.Name = "btnModificar"
        colBtnModificar.HeaderText = " "
        colBtnModificar.UseColumnTextForButtonValue = True
        colBtnModificar.Width = 90
        gvDetalleVentas.Columns.Add(colBtnModificar)


        Dim colIDDetalle As New DataGridViewTextBoxColumn()
        colIDDetalle.HeaderText = "ID"
        colIDDetalle.DataPropertyName = "ID"
        colIDDetalle.Name = "ID Detalle"
        colIDDetalle.ReadOnly = True
        colIDDetalle.Visible = False
        gvDetalleVentas.Columns.Add(colIDDetalle)

        Dim colIDVenta As New DataGridViewTextBoxColumn()
        colIDVenta.HeaderText = "ID Venta"
        colIDVenta.DataPropertyName = "IDVenta"
        colIDVenta.Name = "ID Venta"
        colIDVenta.ReadOnly = True
        gvDetalleVentas.Columns.Add(colIDVenta)

        Dim colIDProducto As New DataGridViewTextBoxColumn()
        colIDProducto.HeaderText = "ID Producto"
        colIDProducto.DataPropertyName = "IDProducto"
        colIDProducto.Name = "ID Producto"
        gvDetalleVentas.Columns.Add(colIDProducto)


        Dim colPu As New DataGridViewTextBoxColumn()
        colPu.HeaderText = "PU"
        colPu.DataPropertyName = "PrecioUnitario"
        colPu.Name = "PrecioUnitario"
        colPu.DefaultCellStyle.Format = "C"
        gvDetalleVentas.Columns.Add(colPu)


        Dim colCantidad As New DataGridViewTextBoxColumn()
        colCantidad.HeaderText = "Cantidad"
        colCantidad.DataPropertyName = "Cantidad"
        colCantidad.Name = "Cantidad"
        gvDetalleVentas.Columns.Add(colCantidad)

        Dim colTotal As New DataGridViewTextBoxColumn()
        colTotal.HeaderText = "Total"
        colTotal.DataPropertyName = "PrecioTotal"
        colTotal.DefaultCellStyle.Format = "C"
        colTotal.Name = "PrecioTotal"
        gvDetalleVentas.Columns.Add(colTotal)



        gvDetalleVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(71, 71, 135)


    End Sub

    ' El total es un grid aparte del flowlayout con grid DetalleVenta para que quede siempre por debajo de la tabla
    Private Sub configurarGridTOTALDetalleVenta()



        gvTotalVenta.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 96, 111)
        gvTotalVenta.DefaultCellStyle.SelectionForeColor = Color.White

        Dim columnaBtnSeleccionar As New DataGridViewTextBoxColumn()
        columnaBtnSeleccionar.HeaderText = "Eliminar"
        columnaBtnSeleccionar.Name = "btnEliminar"
        gvTotalVenta.Columns.Add(columnaBtnSeleccionar)

        Dim colBtnModificar As New DataGridViewTextBoxColumn()
        colBtnModificar.Name = "btnModificar"
        colBtnModificar.HeaderText = "Modificar"
        gvTotalVenta.Columns.Add(colBtnModificar)


        Dim colIDDetalle As New DataGridViewTextBoxColumn()
        colIDDetalle.HeaderText = "ID"
        colIDDetalle.Name = "ID Detalle"
        colIDDetalle.DataPropertyName = "ID Detalle"
        colIDDetalle.ReadOnly = True
        gvTotalVenta.Columns.Add(colIDDetalle)

        Dim colIDVenta As New DataGridViewTextBoxColumn()
        colIDVenta.HeaderText = "ID Venta"
        colIDVenta.Name = "ID Venta"
        gvTotalVenta.Columns.Add(colIDVenta)

        Dim colIDProducto As New DataGridViewTextBoxColumn()
        colIDProducto.HeaderText = "ID Producto"
        colIDProducto.Name = "ID Producto"
        gvTotalVenta.Columns.Add(colIDProducto)


        Dim colPu As New DataGridViewTextBoxColumn()
        colPu.HeaderText = "PU"
        colPu.Name = "PrecioUnitario"
        colPu.DataPropertyName = "PrecioUnitario"
        gvTotalVenta.Columns.Add(colPu)


        Dim colCantidad As New DataGridViewTextBoxColumn()
        colCantidad.HeaderText = "Cantidad"
        colCantidad.Name = "Cantidad"
        gvTotalVenta.Columns.Add(colCantidad)

        Dim colTotal As New DataGridViewTextBoxColumn()
        colTotal.HeaderText = "Total"
        colTotal.DefaultCellStyle.Format = "C"
        colTotal.Name = "PrecioTotal"
        colTotal.DefaultCellStyle.ForeColor = Color.ForestGreen
        gvTotalVenta.Columns.Add(colTotal)

        gvTotalVenta.ColumnHeadersVisible = False
        gvTotalVenta.RowHeadersVisible = False
        gvTotalVenta.BorderStyle = BorderStyle.None
        gvTotalVenta.CellBorderStyle = DataGridViewCellBorderStyle.None

        gvTotalVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        gvTotalVenta.AllowUserToResizeColumns = False
        gvTotalVenta.AllowUserToResizeRows = False



        gvTotalVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gvTotalVenta.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub
    Private Sub CrearFilaTotalEnGridTotal(total As Decimal)
        gvTotalVenta.Rows.Clear()
        ' Datos Del Row Total en gvTotalVenta
        Dim datosFila() As Object = {"", "", "", "", "", "", "", total}

        gvTotalVenta.Rows.Add(datosFila)

        Dim ultimaFila As DataGridViewRow = gvTotalVenta.Rows(gvTotalVenta.Rows.Count - 1)
        ultimaFila.DefaultCellStyle.Font = New Font(gvDetalleVentas.DefaultCellStyle.Font, FontStyle.Bold)
        ultimaFila.DefaultCellStyle.BackColor = Color.FromArgb(87, 96, 111)
        ultimaFila.DefaultCellStyle.ForeColor = Color.White
        ultimaFila.Cells("Cantidad").Value = "Total"
        ultimaFila.ReadOnly = True
    End Sub

    Private Function calcularTotal(tabla As DataTable) As Decimal
        Dim total As Decimal = 0D
        For Each fila As DataRow In tabla.Rows
            If Not IsDBNull(fila("PrecioTotal")) Then
                total += Convert.ToDecimal(fila("PrecioTotal"))
            End If
        Next
        Return total
    End Function

    Private Function esIDVentaValido(id As String) As Boolean
        Dim regExprIDVenta As New Regex("^\d+$")
        Return regExprIDVenta.IsMatch(id)
    End Function
    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        If esIDVentaValido(txtIdVenta.Text) Then
            itemABuscar.IdVenta = Integer.Parse(txtIdVenta.Text)
            cargarGridDetalleVentas()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        itemABuscar.IdVenta = 1
        cargarGridDetalleVentas()
    End Sub

    Private Sub flayoutDetalleVentas_SizeChanged(sender As Object, e As EventArgs) Handles flayoutDetalleVentas.SizeChanged
        gvDetalleVentas.Size = flayoutDetalleVentas.Size
    End Sub
    Private Sub panelTotalDetalle_SizeChanged(sender As Object, e As EventArgs) Handles panelTotalDetalle.SizeChanged
        gvTotalVenta.Size = panelTotalDetalle.Size
    End Sub


    Private Sub gvDetalleVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDetalleVentas.CellContentClick

        ' Se puede borrar o / modificar solo cada 4 segundos, esto debido a que sino puede ingresara 2 veces a la misma función. Se puede optimizar el tiempo para más fluidez
        Dim currentTime As DateTime = DateTime.Now
        If (currentTime - lastClickTime).TotalMilliseconds < 4000 Then Exit Sub
        lastClickTime = currentTime

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvDetalleVentas.Columns("btnModificar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvDetalleVentas.Rows(e.RowIndex)

            For Each columna As DataGridViewCell In filaSeleccionada.Cells
                columna.ReadOnly = False ' Hace Celda Editable aunque ya este configurado en la columnas en la función : configurarColumnasGridDetalleVenta() 
            Next

            gvDetalleVentas.CurrentCell = filaSeleccionada.Cells("ID Producto")
            gvDetalleVentas.BeginEdit(True)
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvDetalleVentas.Columns("btnEliminar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvDetalleVentas.Rows(e.RowIndex)
            Dim productoAeliminar As New Entidad.VentaItem
            productoAeliminar.ID = Integer.Parse(filaSeleccionada.Cells("ID Detalle").Value)
            productoAeliminar.IdVenta = Integer.Parse(filaSeleccionada.Cells("ID Venta").Value)
            eliminarItemVenta(productoAeliminar)
        End If

    End Sub

    Private Sub gvDetalleVentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gvDetalleVentas.CellEndEdit
        Dim filaSeleccionada As DataGridViewRow = gvDetalleVentas.Rows(e.RowIndex)

        ' Usar BeginInvoke para evitar conflictos con eventos internos del DataGridView
        gvDetalleVentas.BeginInvoke(New Action(Sub()
                                                   ' Validar datos
                                                   Dim guardadoExitoso As Boolean = validarDatosYGuardarlos(filaSeleccionada)

                                                   If Not guardadoExitoso Then
                                                       ' Si hay error, volver a la celda original y mantener la edición activa
                                                       Try
                                                           gvDetalleVentas.CurrentCell = filaSeleccionada.Cells(e.ColumnIndex)
                                                           gvDetalleVentas.BeginEdit(True)
                                                       Catch ex As Exception
                                                           MessageBox.Show("Error al volver a editar la celda: " & ex.Message)
                                                       End Try
                                                       Return
                                                   End If

                                                   ' Si se editó una celda común, moverse a la siguiente
                                                   If e.ColumnIndex <> gvDetalleVentas.Columns("btnModificar").Index Then
                                                       Try
                                                           Select Case e.ColumnIndex
                                                               Case gvDetalleVentas.Columns("ID Producto").Index
                                                                   gvDetalleVentas.CurrentCell = filaSeleccionada.Cells("PrecioUnitario")
                                                               Case gvDetalleVentas.Columns("PrecioUnitario").Index
                                                                   gvDetalleVentas.CurrentCell = filaSeleccionada.Cells("Cantidad")
                                                               Case gvDetalleVentas.Columns("Cantidad").Index
                                                                   gvDetalleVentas.CurrentCell = filaSeleccionada.Cells("btnModificar")
                                                           End Select
                                                           gvDetalleVentas.BeginEdit(True)
                                                       Catch ex As Exception
                                                           MessageBox.Show("Error al mover el cursor: " & ex.Message)
                                                       End Try
                                                   Else
                                                       ' Si fue el botón modificar
                                                       gvDetalleVentas.CurrentCell = Nothing
                                                       gvDetalleVentas.EndEdit()
                                                       cargarGridDetalleVentas()
                                                   End If
                                               End Sub))
    End Sub


    Private Sub gvDetalleVentas_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles gvDetalleVentas.CellBeginEdit

    End Sub

    Private Function validarDatosYGuardarlos(filaSeleccionada As DataGridViewRow) As Boolean

        ' No es necesario guardar el total, ya que la clase lo calcula automáticamente
        ' pero se lo guarda por si en el futuro se quiere modificar la clase para agregar precios erroneo por algún motivo desconocido

        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        Dim IDDetalle As String = filaSeleccionada.Cells("ID").Value.ToString()
        Dim IdVenta As String = filaSeleccionada.Cells("ID Venta").Value.ToString()
        Dim IdProducto As String = filaSeleccionada.Cells("ID Producto").Value.ToString()
        Dim pu As String = filaSeleccionada.Cells("PrecioUnitario").Value.ToString().Replace(",", ".")
        Dim cantidad As String = filaSeleccionada.Cells("Cantidad").Value.ToString()
        Dim total As String = filaSeleccionada.Cells("PrecioTotal").Value.ToString().Replace(",", ".")

        Dim errores As New List(Of String)

        If String.IsNullOrEmpty(IDDetalle) OrElse Not Integer.TryParse(IDDetalle, itemAModificar.ID) Then
            errores.Add("* El ID del detalle venta no es un número entero válido")
        End If
        If String.IsNullOrEmpty(IdVenta) OrElse Not Integer.TryParse(IdVenta, itemAModificar.IdVenta) Then
            errores.Add("* El ID venta no es un número entero válido")
        End If
        If String.IsNullOrEmpty(IdProducto) OrElse Not Integer.TryParse(IdProducto, itemAModificar.IdProducto) Then
            errores.Add("* El ID producto no es un número entero válido")
        End If


        If String.IsNullOrEmpty(pu) OrElse Not Decimal.TryParse(pu, itemAModificar.PU) Then
            errores.Add("* El precio unitario no es un número decimal válido")
        End If
        If String.IsNullOrEmpty(cantidad) OrElse Not Integer.TryParse(cantidad, itemAModificar.Cantidad) Then
            errores.Add("* La cantidad del producto no es un número entero válido")
        End If
        If String.IsNullOrEmpty(total) OrElse Not Decimal.TryParse(total, itemAModificar.Total) Then
            errores.Add("* El total no es un número decimal válido")
        End If

        Dim prod As New Entidad.Producto
        prod.ID = itemAModificar.IdProducto
        If Not pl.existeProducto(prod) Then
            errores.Add("* El ID Producto no existe")
        End If

        If errores.Any() Then
            lblErrorMensajes.ForeColor = Color.White
            lblErrorHead.Text = "Error"
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            cargarGridDetalleVentas()
            Return False
        End If
        tablaErrores.Visible = False
        Dim exito As Integer = pl.actualizarVentaItem(itemAModificar)

        cargarGridDetalleVentas()
        Return True



    End Function

    Private Sub actualizarTotalVenta(venta As Entidad.VentaItem)

    End Sub
    Private Sub eliminarItemVenta(productoAeliminar As Entidad.VentaItem)

        Dim estado As Integer = 0
        Dim exito As Integer = 0
        estado = pl.eliminarItemVenta(productoAeliminar)
        If estado = 1 Then
            Dim venta As New Entidad.Venta
            venta.ID = productoAeliminar.IdVenta
            Dim total = pl.sumarTodasLasVentasSegunIDVENTA(venta)
            venta.Total = Decimal.Parse(total)
            exito = pl.actualizarTotalVentaPorID(venta)
        End If
        If exito = 1 AndAlso estado = 1 Then
            cargarGridDetalleVentas()
        End If
    End Sub
    Private Sub gvDetalleVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDetalleVentas.CellClick

    End Sub

    Private Sub gvDetalleVentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvDetalleVentas.CellMouseClick

    End Sub


End Class