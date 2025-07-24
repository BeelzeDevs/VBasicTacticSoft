Public Class VentaItem

    Private _id As Integer
    Private _idVenta As Integer
    Private _idProducto As Integer
    Private _pu As Decimal
    Private _cant As Integer
    Private _total As Decimal
    Private _estado As Boolean = True

    ' Constructores
    Public Sub New()
    End Sub

    Public Sub New(idVenta As Integer, idProducto As Integer, pu As Decimal, cant As Integer)
        ValidarIdVenta(idVenta)
        ValidarIdProducto(idProducto)
        ValidarPrecioUnitario(pu)
        ValidarCantidad(cant)

        Me._idVenta = idVenta
        Me._idProducto = idProducto
        Me._pu = Decimal.Parse(pu)
        Me._cant = cant
        CalcularTotal()
    End Sub

    Public Sub New(idVenta As Integer, idProducto As Integer, pu As Decimal, cant As Integer, estado As Boolean)
        Me.New(idVenta, idProducto, pu, cant)
        Me._estado = estado
    End Sub


    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New ArgumentException("El ID de VentaItem no debe ser negativo")
            End If
            _id = value
        End Set
    End Property

    Public Property IdVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            ValidarIdVenta(value)
            _idVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            ValidarIdProducto(value)
            _idProducto = value
        End Set
    End Property

    Public Property PU As Decimal
        Get
            Return _pu
        End Get
        Set(value As Decimal)
            ValidarPrecioUnitario(value)
            _pu = Decimal.Parse(value)
            CalcularTotal()
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cant
        End Get
        Set(value As Integer)
            ValidarCantidad(value)
            _cant = value
            CalcularTotal()
        End Set
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return _total
        End Get
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property


    Private Sub ValidarIdVenta(idVenta As Integer)
        If idVenta < 0 Then
            Throw New ArgumentException("El IdVenta no debe ser negativo")
        End If
    End Sub

    Private Sub ValidarIdProducto(idProducto As Integer)
        If idProducto < 0 Then
            Throw New ArgumentException("El IdProducto no debe ser negativo")
        End If
    End Sub

    Private Sub ValidarPrecioUnitario(pu As Decimal)
        If pu < 0 Then
            Throw New ArgumentException("El precio unitario no debe ser negativo")
        End If
        Dim precioConvertido As Decimal
        If Not Decimal.TryParse(pu, precioConvertido) Then
            Throw New ArgumentException("El Precio Unitario debe ser un número decimal válido")
        End If
    End Sub

    Private Sub ValidarCantidad(cant As Integer)
        If cant < 0 Then
            Throw New ArgumentException("La cantidad no debe ser negativa")
        End If
    End Sub


    Private Sub CalcularTotal()
        _total = Decimal.Parse(_cant * _pu)
    End Sub

End Class

