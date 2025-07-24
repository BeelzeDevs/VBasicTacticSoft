
Imports Negocio
Imports Entidad
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Diagnostics.Stopwatch

Public Class BM_Clientes
    Private pl As New PedidoLogico()
    Private clienteAModificar As New Entidad.Cliente()
    Private culturaArgentina As New CultureInfo("es-AR")
    Private culturaEstadosU As New CultureInfo("en-US")
    Private WithEvents gvClientes As CustomDataGridView
    Private lastClickTime As DateTime = DateTime.MinValue
    Public Sub New()
        ' llamada es exigida por el diseñador.
        InitializeComponent()


        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        flayoutClientes.Controls.Add(gvClientes)
        flayoutClientes.Visible = True


        AddHandler gvClientes.CellContentClick, AddressOf gvClientes_CellContentClick
        AddHandler gvClientes.CellEndEdit, AddressOf gvClientes_CellEndEdit
        AddHandler gvClientes.CellBeginEdit, AddressOf gvClientes_CellBeginEdit
        AddHandler gvClientes.CellClick, AddressOf gvClientes_CellClick
        AddHandler gvClientes.CellMouseClick, AddressOf gvClientes_CellMouseClick

        cargarGridClientes()

    End Sub
    Private Sub cargarGridClientes()

        gvClientes.DataSource = Nothing
        gvClientes.Columns.Clear()
        Try
            Dim tablaClientes As DataTable = pl.obtenerTablaClientesCompleta()
            If tablaClientes IsNot Nothing Then
                configurarColumnasGridClientes()
                cargarAparienciaGridView(gvClientes)

                gvClientes.DataSource = tablaClientes
            Else
                MessageBox.Show("No se encontraron clientes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders


    End Sub

    Private Sub configurarColumnasGridClientes()

        Dim columnaBtnEliminar As New DataGridViewButtonColumn()
        columnaBtnEliminar.Text = "Eliminar"
        columnaBtnEliminar.Name = "btnEliminar"
        columnaBtnEliminar.HeaderText = " "
        columnaBtnEliminar.UseColumnTextForButtonValue = True
        columnaBtnEliminar.Width = 90
        gvClientes.Columns.Add(columnaBtnEliminar)

        Dim colBtnModificar As New DataGridViewButtonColumn()
        colBtnModificar.Text = "Modificar"
        colBtnModificar.Name = "btnModificar"
        colBtnModificar.HeaderText = " "
        colBtnModificar.UseColumnTextForButtonValue = True
        colBtnModificar.Width = 90
        gvClientes.Columns.Add(colBtnModificar)


        Dim colIDCliente As New DataGridViewTextBoxColumn()
        colIDCliente.HeaderText = "ID"
        colIDCliente.DataPropertyName = "ID"
        colIDCliente.Name = "ID Cliente"
        colIDCliente.ReadOnly = True
        colIDCliente.Visible = False
        gvClientes.Columns.Add(colIDCliente)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.HeaderText = "Nombre"
        colNombre.DataPropertyName = "Cliente"
        colNombre.Name = "Nombre"
        colNombre.ReadOnly = True
        gvClientes.Columns.Add(colNombre)

        Dim colTelefono As New DataGridViewTextBoxColumn()
        colTelefono.HeaderText = "Telefono"
        colTelefono.DataPropertyName = "Telefono"
        colTelefono.Name = "Telefono"
        gvClientes.Columns.Add(colTelefono)


        Dim colCorreo As New DataGridViewTextBoxColumn()
        colCorreo.HeaderText = "E-Mail"
        colCorreo.DataPropertyName = "Correo"
        colCorreo.Name = "Correo"
        gvClientes.Columns.Add(colCorreo)


        Dim columnaEstado As New DataGridViewTextBoxColumn()
        columnaEstado.HeaderText = "Estado"
        columnaEstado.DataPropertyName = "Estado"
        columnaEstado.Name = "Estado"
        gvClientes.Columns.Add(columnaEstado)



        gvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(71, 71, 135)


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
    Private Function esIDClienteValido(id As String) As Boolean
        Dim regExprIDCliente As New Regex("^\d+$")
        Return regExprIDCliente.IsMatch(id)
    End Function

    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        tablaErrores.Visible = False
        Dim cliente As New Entidad.Cliente()

        If esIDClienteValido(txtIdCliente.Text) Then
            cliente.ID = Integer.Parse(txtIdCliente.Text)
        End If
        If pl.existeCliente(cliente) = False Then
            Return
        End If
        filtrarPorIDCliente(cliente)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tablaErrores.Visible = False
        cargarGridClientes()
    End Sub

    Private Sub flayoutClientes_SizeChanged(sender As Object, e As EventArgs) Handles flayoutClientes.SizeChanged
        gvClientes.Size = flayoutClientes.Size
    End Sub

    Private Sub gvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvClientes.CellContentClick

        ' Se puede borrar o / modificar solo cada 4 segundos, esto debido a que sino puede ingresara 2 veces a la misma función. Se puede optimizar el tiempo para más fluidez
        Dim currentTime As DateTime = DateTime.Now
        If (currentTime - lastClickTime).TotalMilliseconds < 4000 Then Exit Sub
        lastClickTime = currentTime

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvClientes.Columns("btnModificar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvClientes.Rows(e.RowIndex)

            For Each columna As DataGridViewCell In filaSeleccionada.Cells
                columna.ReadOnly = False ' Hace Celda Editable aunque ya este configurado en la columnas en la función : configurarColumnasGridDetalleVenta() 
            Next

            gvClientes.CurrentCell = filaSeleccionada.Cells("Nombre")
            gvClientes.BeginEdit(True)
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = gvClientes.Columns("btnEliminar").Index Then
            Dim filaSeleccionada As DataGridViewRow = gvClientes.Rows(e.RowIndex)
            Dim clienteAEliminar As New Entidad.Cliente
            clienteAEliminar.ID = Integer.Parse(filaSeleccionada.Cells("ID Cliente").Value)

            eliminarCliente(clienteAEliminar)
        End If

    End Sub
    Private Sub gvClientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gvClientes.CellEndEdit
        Dim filaSeleccionada As DataGridViewRow = gvClientes.Rows(e.RowIndex)

        ' Usar BeginInvoke para evitar conflictos con eventos internos del DataGridView
        gvClientes.BeginInvoke(New Action(Sub()
                                              ' Validar datos
                                              Dim guardadoExitoso As Boolean = validarDatosYGuardarlos(filaSeleccionada)

                                              If Not guardadoExitoso Then
                                                  ' Si hay error, volver a la celda original y mantener la edición activa
                                                  Try
                                                      gvClientes.CurrentCell = filaSeleccionada.Cells(e.ColumnIndex)
                                                      gvClientes.BeginEdit(True)
                                                  Catch ex As Exception
                                                      MessageBox.Show("Error al volver a editar la celda: " & ex.Message)
                                                  End Try
                                                  Return
                                              End If

                                              ' Si se editó una celda común, moverse a la siguiente
                                              If e.ColumnIndex <> gvClientes.Columns("btnModificar").Index Then
                                                  Try
                                                      Select Case e.ColumnIndex
                                                          Case gvClientes.Columns("Nombre").Index
                                                              gvClientes.CurrentCell = filaSeleccionada.Cells("Telefono")
                                                          Case gvClientes.Columns("Telefono").Index
                                                              gvClientes.CurrentCell = filaSeleccionada.Cells("Correo")
                                                          Case gvClientes.Columns("Correo").Index
                                                              gvClientes.CurrentCell = filaSeleccionada.Cells("btnModificar")
                                                      End Select
                                                      gvClientes.BeginEdit(True)
                                                  Catch ex As Exception
                                                      MessageBox.Show("Error al mover el cursor: " & ex.Message)
                                                  End Try
                                              Else
                                                  ' Si fue el botón modificar
                                                  gvClientes.CurrentCell = Nothing
                                                  gvClientes.EndEdit()
                                                  cargarGridClientes()
                                              End If
                                          End Sub))
    End Sub

    Private Sub gvClientes_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles gvClientes.CellBeginEdit

    End Sub
    Private Function esEmailValido(mail As String) As Boolean
        Dim regExpreEmail As New Regex("^[\w\.-]+@[\w\-]+\.[\w\.-]+$")
        Return regExpreEmail.IsMatch(mail)
    End Function

    Private Function esTelefonoValido(tel As String) As Boolean
        Dim regExpTel As New Regex("^(11|15)\d{8}$")
        Return regExpTel.IsMatch(tel)
    End Function
    Private Function esNombreValido(nombre As String) As Boolean
        Dim regExpNombre As New Regex("^\p{L}+(\s\p{L}+)*$", RegexOptions.Compiled)
        Return regExpNombre.IsMatch(nombre)
    End Function
    Private Function validarDatosYGuardarlos(filaSeleccionada As DataGridViewRow) As Boolean
        Dim ID As String = filaSeleccionada.Cells("ID Cliente").Value.ToString()
        Dim nombre As String = filaSeleccionada.Cells("Nombre").Value.ToString()
        Dim telefono As String = filaSeleccionada.Cells("Telefono").Value.ToString()
        Dim correo As String = filaSeleccionada.Cells("Correo").Value.ToString()
        Dim estado As String = filaSeleccionada.Cells("Estado").Value.ToString()

        Dim errores As New List(Of String)

        If String.IsNullOrEmpty(ID) OrElse Not Integer.TryParse(ID, clienteAModificar.ID) Then
            errores.Add("* El ID del cliente no es un número entero válido")
        End If
        If String.IsNullOrEmpty(nombre) OrElse Not esNombreValido(nombre) Then
            errores.Add("* El nombre no es válido")
        End If
        If String.IsNullOrEmpty(telefono) OrElse Not esTelefonoValido(telefono) Then
            errores.Add("* El teléfono debe tener 10 caracteres numéricos y comenzar por 11 o 15")
        End If
        If String.IsNullOrEmpty(correo) OrElse Not esEmailValido(correo) Then
            errores.Add("* El correo no es válido")
        End If

        If errores.Any() Then
            lblErrorMensajes.ForeColor = Color.White
            lblErrorHead.Text = "Error"
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            Return False
        End If

        clienteAModificar.NombreCliente = nombre
        clienteAModificar.Telefono = telefono
        clienteAModificar.Correo = correo

        tablaErrores.Visible = False
        Dim exito As Integer = pl.actualizarCliente(clienteAModificar)

        Return True
    End Function
    Private Sub eliminarCliente(clienteAeliminar As Entidad.Cliente)

        Dim estado As Integer = 0
        estado = pl.bajaLogicaCliente(clienteAeliminar)

        If estado = 1 Then
            cargarGridClientes()
        End If
    End Sub

    Private Sub gvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvClientes.CellClick

    End Sub

    Private Sub gvClientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvClientes.CellMouseClick

    End Sub
    Private Sub filtrarPorIDCliente(cliente As Entidad.Cliente)
        Dim dt As DataTable = TryCast(gvClientes.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[ID] = " & cliente.ID

        End If

        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

    End Sub

End Class