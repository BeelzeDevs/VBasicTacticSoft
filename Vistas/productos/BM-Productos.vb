Imports Negocio
Imports Entidad
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Diagnostics.Stopwatch

Public Class BM_Productos
    Private pl As New PedidoLogico()
    Private productoAModificar As New Entidad.Producto()
    Private culturaArgentina As New CultureInfo("es-AR")
    Private culturaEstadosU As New CultureInfo("en-US")
    Private WithEvents gvProductos As CustomDataGridView
    Private lastClickTime As DateTime = DateTime.MinValue

    Public Sub New()
        ' llamada es exigida por el diseñador.
        InitializeComponent()


        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        flayoutProductos.Controls.Add(gvProductos)
        flayoutProductos.Visible = True


        AddHandler gvProductos.CellContentClick, AddressOf gvProductos_CellContentClick
        AddHandler gvProductos.CellEndEdit, AddressOf gvProductos_CellEndEdit
        AddHandler gvProductos.CellBeginEdit, AddressOf gvProductos_CellBeginEdit
        AddHandler gvProductos.CellClick, AddressOf gvProductos_CellClick
        AddHandler gvProductos.CellMouseClick, AddressOf gvProductos_CellMouseClick

        cargarGridProductos()

    End Sub

    Private Sub cargarGridProductos()

        gvProductos.DataSource = Nothing
        gvProductos.Columns.Clear()
        Try
            Dim tablaProductos As DataTable = pl.obtenerTablaProductosCompletaV2()
            If tablaProductos IsNot Nothing Then
                configurarColumnasGridProductos()
                cargarAparienciaGridView(gvProductos)

                gvProductos.DataSource = tablaProductos
            Else
                MessageBox.Show("No se encontraron productos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders


    End Sub
    Private Sub configurarColumnasGridProductos()

        Dim columnaBtnEliminar As New DataGridViewButtonColumn()
        columnaBtnEliminar.Text = "Eliminar"
        columnaBtnEliminar.Name = "btnEliminar"
        columnaBtnEliminar.HeaderText = " "
        columnaBtnEliminar.UseColumnTextForButtonValue = True
        columnaBtnEliminar.Width = 90
        gvProductos.Columns.Add(columnaBtnEliminar)

        Dim colBtnModificar As New DataGridViewButtonColumn()
        colBtnModificar.Text = "Modificar"
        colBtnModificar.Name = "btnModificar"
        colBtnModificar.HeaderText = " "
        colBtnModificar.UseColumnTextForButtonValue = True
        colBtnModificar.Width = 90
        gvProductos.Columns.Add(colBtnModificar)


        Dim colIDProducto As New DataGridViewTextBoxColumn()
        colIDProducto.HeaderText = "ID"
        colIDProducto.DataPropertyName = "ID"
        colIDProducto.Name = "ID Producto"
        colIDProducto.ReadOnly = True
        colIDProducto.Visible = False
        gvProductos.Columns.Add(colIDProducto)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.HeaderText = "Nombre"
        colNombre.DataPropertyName = "Nombre"
        colNombre.Name = "Nombre"
        colNombre.ReadOnly = True
        gvProductos.Columns.Add(colNombre)

        Dim colPrecio As New DataGridViewTextBoxColumn()
        colPrecio.HeaderText = "Precio"
        colPrecio.DataPropertyName = "Precio"
        colPrecio.Name = "Precio"
        colPrecio.DefaultCellStyle.Format = "C"
        gvProductos.Columns.Add(colPrecio)


        Dim colCategoria As New DataGridViewTextBoxColumn()
        colCategoria.HeaderText = "Categoria"
        colCategoria.DataPropertyName = "Categoria"
        colCategoria.Name = "Categoria"
        gvProductos.Columns.Add(colCategoria)


        Dim colEstado As New DataGridViewTextBoxColumn()
        colEstado.HeaderText = "Estado"
        colEstado.DataPropertyName = "Estado"
        colEstado.Name = "Estado"
        gvProductos.Columns.Add(colEstado)



        gvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(71, 71, 135)


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

    Private Function esIDProductoValido(id As String) As Boolean
        Dim regExprIDCliente As New Regex("^\d+$")
        Return regExprIDCliente.IsMatch(id)
    End Function

    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        tablaErrores.Visible = False
        Dim producto As New Entidad.Producto()

        If esIDProductoValido(txtIdProducto.Text) Then
            producto.ID = Integer.Parse(txtIdProducto.Text)
        End If
        If pl.existeProducto(producto) = False Then
            Return
        End If
        filtrarPorIDProducto(producto)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tablaErrores.Visible = False
        cargarGridProductos()
    End Sub

    Private Sub flayoutProductos_SizeChanged(sender As Object, e As EventArgs) Handles flayoutProductos.SizeChanged
        gvProductos.Size = flayoutProductos.Size
    End Sub
    Private Sub gvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvProductos.CellContentClick

        ' Se puede borrar o / modificar solo cada 4 segundos, esto debido a que sino puede ingresara 2 veces a la misma función. Se puede optimizar el tiempo para más fluidez
        Dim currentTime As DateTime = DateTime.Now
        If (currentTime - lastClickTime).TotalMilliseconds < 4000 Then Exit Sub
        lastClickTime = currentTime

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvProductos.Columns("btnModificar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvProductos.Rows(e.RowIndex)

            For Each columna As DataGridViewCell In filaSeleccionada.Cells
                columna.ReadOnly = False ' Hace Celda Editable aunque ya este configurado en la columnas en la función : configurarColumnasGridDetalleVenta() 
            Next

            gvProductos.CurrentCell = filaSeleccionada.Cells("Nombre")
            gvProductos.BeginEdit(True)
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvProductos.Columns("btnEliminar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvProductos.Rows(e.RowIndex)
            Dim productoAEliminar As New Entidad.Producto
            productoAEliminar.ID = Integer.Parse(filaSeleccionada.Cells("ID Producto").Value)

            eliminarProducto(productoAEliminar)
        End If

    End Sub

    Private Sub gvProductos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gvProductos.CellEndEdit
        Dim filaSeleccionada As DataGridViewRow = gvProductos.Rows(e.RowIndex)

        ' Difiere toda la lógica al final del evento para evitar errores de reentrancy
        gvProductos.BeginInvoke(New Action(Sub()

                                               ' Validar y guardar datos
                                               Dim guardadoExitoso As Boolean = validarDatosYGuardarlos(filaSeleccionada)

                                               If Not guardadoExitoso Then
                                                   ' Si hay errores, quedarse en la celda actual y seguir en modo edición
                                                   gvProductos.CurrentCell = gvProductos.Rows(e.RowIndex).Cells(e.ColumnIndex)
                                                   gvProductos.BeginEdit(True)
                                                   Exit Sub
                                               End If

                                               ' Si la columna editada no es el botón Modificar, avanzar a la siguiente celda
                                               If e.ColumnIndex <> gvProductos.Columns("btnModificar").Index Then
                                                   Select Case e.ColumnIndex
                                                       Case gvProductos.Columns("Nombre").Index
                                                           gvProductos.CurrentCell = filaSeleccionada.Cells("Precio")
                                                       Case gvProductos.Columns("Precio").Index
                                                           gvProductos.CurrentCell = filaSeleccionada.Cells("Categoria")
                                                       Case gvProductos.Columns("Categoria").Index
                                                           gvProductos.CurrentCell = filaSeleccionada.Cells("btnModificar")
                                                   End Select

                                                   gvProductos.BeginEdit(True)

                                               Else
                                                   ' Si es la columna del botón, refrescar el grid
                                                   gvProductos.CurrentCell = Nothing
                                                   gvProductos.EndEdit()
                                                   cargarGridProductos() ' Asegurate de tener esta función
                                               End If

                                           End Sub))
    End Sub

    Private Sub gvProductos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles gvProductos.CellBeginEdit

    End Sub

    Private Function esNombreValido(nombre As String) As Boolean
        If nombre.Length < 4 OrElse nombre.Length > 35 Then
            Return False
        End If

        Dim regExpNombreProducto As New Regex("^[a-zA-Z0-9]+(?: [a-zA-Z0-9]+)*$", RegexOptions.Compiled)
        Return regExpNombreProducto.IsMatch(nombre)
    End Function

    Private Function esCategoriaValida(categ As String) As Boolean
        Dim regExpCategoria As New Regex("^[\p{L}0-9]+(\s[\p{L}0-9]+)*$")
        Return regExpCategoria.IsMatch(categ)
    End Function
    Private Function validarDatosYGuardarlos(filaSeleccionada As DataGridViewRow) As Boolean

        ' No es necesario guardar el total, ya que la clase lo calcula automáticamente
        ' pero se lo guarda por si en el futuro se quiere modificar la clase para agregar precios erroneo por algún motivo desconocido

        Dim ID As String = filaSeleccionada.Cells("ID Producto").Value.ToString()
        Dim nombre As String = filaSeleccionada.Cells("Nombre").Value.ToString()
        Dim preciotexto As String = filaSeleccionada.Cells("Precio").Value.ToString()
        Dim categoria As String = filaSeleccionada.Cells("Categoria").Value.ToString()
        Dim estado As String = filaSeleccionada.Cells("Estado").Value.ToString()

        Dim errores As New List(Of String)

        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        preciotexto = preciotexto.Replace(",", ".")
        Dim precioDecimal As Decimal
        If String.IsNullOrEmpty(preciotexto) OrElse Not Decimal.TryParse(preciotexto, precioDecimal) Then
            errores.Add("* El Precio del producto es obligatorio y debe ser un número decimal válido")
        End If

        If String.IsNullOrEmpty(nombre) OrElse Not esNombreValido(nombre) Then
            errores.Add("* El nombre es obligatorio y debe contener: minimo 4 caracteres, máximo 35 caracteres alfanuméricos. No admite tildes")
        End If

        If String.IsNullOrEmpty(categoria) OrElse Not esCategoriaValida(categoria) Then
            errores.Add("* La categoria es obligatoria y debe contener letras, números, tildes y espacios intercalados")
        End If

        If errores.Any() Then
            lblErrorMensajes.ForeColor = Color.White
            lblErrorHead.Text = "Error"
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            Return False
        End If

        productoAModificar.NombreProducto = nombre
        productoAModificar.Categoria = categoria
        productoAModificar.Precio = precioDecimal
        productoAModificar.ID = Integer.Parse(ID)

        tablaErrores.Visible = False
        Dim exito As Integer = pl.actualizarProducto(productoAModificar)

        Return True



    End Function

    Private Sub eliminarProducto(productoAeliminar As Entidad.Producto)

        Dim estado As Integer = 0
        Dim exito As Integer = 0
        estado = pl.bajaLogicaProducto(productoAeliminar)

        If estado = 1 Then
            cargarGridProductos()
        End If
    End Sub

    Private Sub gvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvProductos.CellClick

    End Sub

    Private Sub gvProductos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvProductos.CellMouseClick

    End Sub

    Private Sub filtrarPorIDProducto(producto As Entidad.Producto)
        Dim dt As DataTable = TryCast(gvProductos.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[ID] = " & producto.ID

        End If

        gvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

    End Sub


End Class