Imports Negocio
Imports Entidad
Imports System.Globalization
Imports System.Text.RegularExpressions


Public Class listarClientes
    Private pl As New PedidoLogico()
    Private conRegistrosInactivos As Boolean = True
    Private filtroID As Integer = 0
    Private filtroNombre As String = ""
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        cargarGridClientes()

    End Sub

    Private Sub cargarGridClientes()
        gvClientes.DataSource = Nothing
        gvClientes.Columns.Clear()
        Try
            Dim tablaClientes As DataTable = pl.obtenerTablaClientesCompleta()
            If tablaClientes IsNot Nothing Then
                configurarColumnasDataGridViewCliente()
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
    End Sub
    Private Sub configurarColumnasDataGridViewCliente()

        Dim columnaID As New DataGridViewTextBoxColumn()
        columnaID.HeaderText = "ID Cliente"
        columnaID.DataPropertyName = "ID"
        columnaID.Name = "ID Cliente"
        columnaID.ReadOnly = True
        gvClientes.Columns.Add(columnaID)

        Dim columnaNombreCliente As New DataGridViewTextBoxColumn()
        columnaNombreCliente.HeaderText = "Nombre"
        columnaNombreCliente.DataPropertyName = "Cliente"
        columnaNombreCliente.Name = "Nombre Cliente"
        columnaNombreCliente.ReadOnly = True
        gvClientes.Columns.Add(columnaNombreCliente)

        Dim columnaTelefono As New DataGridViewTextBoxColumn()
        columnaTelefono.HeaderText = "Teléfono"
        columnaTelefono.DataPropertyName = "Telefono"
        columnaTelefono.Name = "Telefono"
        columnaTelefono.ReadOnly = True
        gvClientes.Columns.Add(columnaTelefono)

        Dim columnaMail As New DataGridViewTextBoxColumn()
        columnaMail.HeaderText = "E-Mail"
        columnaMail.DataPropertyName = "Correo"
        columnaMail.Name = "Correo"
        columnaMail.ReadOnly = True
        gvClientes.Columns.Add(columnaMail)

        Dim columnaEstado As New DataGridViewCheckBoxColumn
        columnaEstado.HeaderText = "Estado"
        columnaEstado.DataPropertyName = "Estado"
        columnaEstado.Name = "Estado"
        columnaEstado.ReadOnly = True
        gvClientes.Columns.Add(columnaEstado)

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
        Dim dt As DataTable = TryCast(gvClientes.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[Estado] = " & chkboxSoloActivos.Checked

        End If


        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub chkboxSoloActivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxSoloActivos.CheckedChanged
        conRegistrosInactivos = chkboxSoloActivos.CheckState
        filtrarDatosxEstado()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        limpiarControles()
        cargarGridClientes()
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

        chkboxSoloActivos.Enabled = False

        Dim dt As DataTable = TryCast(gvClientes.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[ID] = " & filtroID

        End If

        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
    End Sub

    Private Sub filtrarPorNombre()

        chkboxSoloActivos.Enabled = False

        Dim dt As DataTable = TryCast(gvClientes.DataSource, DataTable)

        If dt IsNot Nothing Then

            Dim view As DataView = dt.DefaultView

            view.RowFilter = "[Cliente] = '" & filtroNombre & "'"

        End If

        gvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

    End Sub

    Private Sub limpiarControles()
        chkboxSoloActivos.Checked = True
        chkboxSoloActivos.Enabled = True
        txtID.Text = ""
        txtNombre.Text = ""
        filtroID = 0
        filtroNombre = ""
    End Sub
End Class