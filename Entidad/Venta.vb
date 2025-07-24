Public Class Venta

    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As DateTime
    Private _total As Decimal
    Private _estado As Boolean = True

    Public Sub New()
    End Sub

    Public Sub New(idCliente As Integer, fecha As Date, total As Decimal)
        ValidarIdCliente(idCliente)
        Dim fechaformateada As DateTime = ValidarFechaVentaYFormatearla(fecha)
        ValidarTotalVenta(total)

        Me._idCliente = idCliente
        Me._fecha = fechaformateada
        Me._total = total
    End Sub

    Public Sub New(idCliente As Integer, fecha As Date, total As Decimal, estado As Boolean)
        Me.New(idCliente, fecha, total)
        Me._estado = estado
    End Sub


    Private Sub ValidarIdCliente(idCliente As Integer)
        If idCliente <= 0 Then
            Throw New ArgumentException("El ID del cliente debe ser un número positivo")
        End If
    End Sub

    Private Function ValidarFechaVentaYFormatearla(fecha As DateTime) As DateTime
        Dim fechaFormateada As String = fecha.ToString("yyyy-MM-dd HH:mm:ss")
        If fecha > Date.Now Then
            Throw New ArgumentException("La fecha de la venta no puede ser futura")
        End If
        Return fechaFormateada

    End Function

    Private Sub ValidarTotalVenta(total As Decimal)
        If total < 0 Then
            Throw New ArgumentException("El total de la venta no puede ser negativo")
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

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            ValidarIdCliente(value)
            _idCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            Dim fechaformateada As DateTime = ValidarFechaVentaYFormatearla(value)
            _fecha = fechaformateada
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            ValidarTotalVenta(value)
            _total = value
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


