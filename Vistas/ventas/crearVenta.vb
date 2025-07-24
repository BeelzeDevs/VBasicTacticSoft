Imports System.Text.RegularExpressions
Imports Entidad
Imports Negocio
Imports System.Globalization
Public Class crearVenta
    Private pl As New PedidoLogico()
    Private culturaArgentina As New CultureInfo("es-AR")
    Private culturaEstadosU As New CultureInfo("en-US")
    Private itemVendido As New Entidad.VentaItem
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Threading.Thread.CurrentThread.CurrentCulture = culturaArgentina
        Threading.Thread.CurrentThread.CurrentUICulture = culturaArgentina

        cargarCombobox()

    End Sub
    Private Sub cargarCombobox()
        cbProductos.DataSource = pl.obtenerIDYNombreProductosUNICOS()
        cbProductos.DisplayMember = "Nombre"
        cbProductos.ValueMember = "ID"

    End Sub
    Private Function validarForm() As Boolean

        Dim errores As New List(Of String)

        Dim idVenta As Integer
        If String.IsNullOrEmpty(txtIDVenta.Text) OrElse Not Integer.TryParse(txtIDVenta.Text, idVenta) Then
            errores.Add("* El ID Venta es obligatorio y debe ser un número entero válido")
        End If

        Dim cantidad As Integer
        If String.IsNullOrEmpty(txtCantidad.Text) OrElse Not Integer.TryParse(txtCantidad.Text, cantidad) Then
            errores.Add("* La cantidad es obligatoria y debe ser un número entero válido")
        End If
        itemVendido.Cantidad = cantidad

        Dim precioUnitario As Decimal
        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        Dim precioTexto As String = txtPrecioUnitario.Text.Replace(",", ".")
        If String.IsNullOrEmpty(precioTexto) OrElse Not Decimal.TryParse(precioTexto, precioUnitario) Then
            errores.Add("* El Precio Unitario es obligatorio y debe ser un número decimal válido")
        Else
            itemVendido.PU = precioUnitario
        End If


        Dim venta As New Entidad.Venta
        venta.ID = idVenta
        If Not pl.existeVenta(venta) Then
            errores.Add("* El ID Venta no existe")
        End If
        itemVendido.IdVenta = idVenta

        If errores.Any() Then

            lblErrorMensajes.ForeColor = Color.White
            lblErrorHead.Text = "Error"
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            Return False
        End If

        lblPrecioTotalAutomatico.Text = String.Format("{0:C}", cantidad * precioUnitario)
        tablaErrores.Visible = False
        Return True

    End Function

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim estado As Boolean = validarForm()
        If estado Then

            Integer.TryParse(cbProductos.SelectedValue.ToString, itemVendido.IdProducto)
            Dim Exito As Integer = pl.agregarVentaItem(itemVendido)
            If Exito Then
                limpiarControles()
                MessageBox.Show("Agregado con éxito")
            End If

        End If

    End Sub

    Private Sub limpiarControles()
        txtCantidad.Text = ""
        txtIDVenta.Text = ""
        txtPrecioUnitario.Text = ""
        cbProductos.SelectedIndex = 0
        lblPrecioTotalAutomatico.Text = ""
    End Sub
End Class