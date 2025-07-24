Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class crearProducto
    Private pl As New Negocio.PedidoLogico()
    Private productoAagregar As New Entidad.Producto()
    Private estadoOtraCategoria As Boolean = False
    Private culturaEstadosU As New CultureInfo("en-US")

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU

        cargarCategorias()

    End Sub

    Private Function esNombreValido(nombre As String) As Boolean
        Dim regExpNombreProducto As New Regex("^[a-zA-Z]{4,35}$")
        Return regExpNombreProducto.IsMatch(nombre)
    End Function

    Private Function esCategoriaValido(cat As String) As Boolean
        Dim regExpNombreProducto As New Regex("^[a-zA-Z\s]+$")
        Return regExpNombreProducto.IsMatch(cat)
    End Function

    Private Function validarForm() As Boolean

        Dim errores As New List(Of String)

        If String.IsNullOrEmpty(txtNombre.Text) Then
            errores.Add("* El nombre es obligatorio, más de 4 letras y menor o igual a 35 caracteres")
            txtNombre.ForeColor = Color.Red
        End If
        If String.IsNullOrEmpty(txtPrecio.Text) Then
            errores.Add("* El precio es obligatorio")
            txtPrecio.ForeColor = Color.Red
        End If

        Dim precioProducto As Decimal
        Threading.Thread.CurrentThread.CurrentCulture = culturaEstadosU
        Threading.Thread.CurrentThread.CurrentUICulture = culturaEstadosU
        Dim precioTexto As String = txtPrecio.Text.Replace(",", ".")
        If String.IsNullOrEmpty(precioTexto) OrElse Not Decimal.TryParse(precioTexto, precioProducto) Then
            errores.Add("* El Precio Unitario es obligatorio y debe ser un número decimal válido")
        End If

        If Not esNombreValido(txtNombre.Text) Then
            errores.Add("* El nombre debe contener: minimo 4 caracteres, máximo 35 caracteres inclusive")
            txtNombre.ForeColor = Color.Red
        End If

        If String.IsNullOrWhiteSpace(txtOtraCateg.Text) Then
            estadoOtraCategoria = False
        ElseIf Not esCategoriaValido(txtOtraCateg.Text) Then
            estadoOtraCategoria = False
            errores.Add("* La Categoría personalizada solo admite letras y espacio intercalados.")
        Else
            estadoOtraCategoria = True
        End If

        If errores.Any() Then
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            Return False
        End If

        productoAagregar.NombreProducto = txtNombre.Text
        productoAagregar.Precio = precioProducto
        If estadoOtraCategoria Then
            productoAagregar.Categoria = txtOtraCateg.Text
        Else
            productoAagregar.Categoria = cbCategoria.Text
        End If
        tablaErrores.Visible = False
        Return True

    End Function

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Dim estado As Boolean = validarForm()
        If estado Then
            Dim exito As Integer = pl.agregarProducto(productoAagregar)
            If exito Then
                limpiarControles()
                MessageBox.Show("Agregado con éxito")
                cargarCategorias()
            End If
        End If
    End Sub


    Private Sub limpiarControles()
        txtNombre.Text = ""
        txtOtraCateg.Text = ""
        txtPrecio.Text = ""
        cbCategoria.SelectedIndex = 0
    End Sub

    Private Sub cargarCategorias()
        Dim data As DataTable = pl.obtenerCategoriaProductosUNICAS()
        If data Is Nothing Then
            MessageBox.Show("Error al cargar Categoria Unicas de productos")
        Else
            cbCategoria.DataSource = data
            cbCategoria.DisplayMember = "Categoria"
        End If


    End Sub

End Class