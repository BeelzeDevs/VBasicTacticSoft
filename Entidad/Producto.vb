Public Class Producto

    Private _id As Integer
    Private _nombre As String
    Private _precio As Decimal
    Private _categoria As String
    Private _estado As Boolean = True

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, precio As Decimal, categoria As String)
        ValidarLongitudMaxima(nombre, "nombre del producto", 255)
        ValidarPrecioPositivo(precio)
        ValidarLongitudMaxima(categoria, "categoría del producto", 255)

        Me._nombre = nombre
        Me._precio = precio
        Me._categoria = categoria
    End Sub

    Public Sub New(nombre As String, precio As Decimal, categoria As String, estado As Boolean)
        Me.New(nombre, precio, categoria)
        Me._estado = estado
    End Sub

    Private Sub ValidarLongitudMaxima(valor As String, nombreCampo As String, longitudMaxima As Integer)
        If String.IsNullOrWhiteSpace(valor) Then
            Throw New ArgumentNullException(nombreCampo, $"El campo {nombreCampo} no puede estar vacío")
        End If
        If valor.Length > longitudMaxima Then
            Throw New ArgumentException($"El campo {nombreCampo} no puede tener más de {longitudMaxima} caracteres")
        End If
    End Sub

    Private Sub ValidarPrecioPositivo(precio As Decimal)
        If precio < 0 Then
            Throw New ArgumentException("El precio del producto debe ser un número positivo")
        End If
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            ValidarLongitudMaxima(value, "nombre del producto", 255)
            _nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            ValidarPrecioPositivo(value)
            _precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            ValidarLongitudMaxima(value, "categoría del producto", 255)
            _categoria = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

End Class

