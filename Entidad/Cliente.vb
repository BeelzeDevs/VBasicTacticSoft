Public Class Cliente

    Private _id As Integer
    Private _nombreCliente As String
    Private _telefono As String
    Private _correo As String
    Private _estado As Boolean = True

    Public Sub New()
    End Sub

    Public Sub New(nombreCliente As String, telefono As String, correo As String)
        ValidarLongitudMaxima(nombreCliente, "nombre del cliente", 255)
        ValidarLongitudMaxima(telefono, "teléfono", 255)
        ValidarLongitudMaxima(correo, "correo", 255)
        ValidarCorreo(correo)
        Me._nombreCliente = nombreCliente
        Me._telefono = telefono
        Me._correo = correo
    End Sub

    Public Sub New(cliente As String, telefono As String, correo As String, estado As Boolean)
        Me.New(cliente, telefono, correo)
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

    Private Sub ValidarCorreo(correo As String)
        If Not correo.Contains("@") OrElse Not correo.Contains(".") Then
            Throw New ArgumentException("El correo electrónico debe tener un formato valido")
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

    Public Property NombreCliente As String
        Get
            Return _nombreCliente
        End Get
        Set(value As String)
            ValidarLongitudMaxima(value, "nombre del cliente", 255)
            _nombreCliente = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            ValidarLongitudMaxima(value, "teléfono", 255)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            ValidarLongitudMaxima(value, "correo", 255)
            ValidarCorreo(value)
            _correo = value
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
