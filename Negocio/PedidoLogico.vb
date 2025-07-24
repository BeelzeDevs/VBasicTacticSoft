Imports System.Collections.Generic
Imports System.Data
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Entidad
Imports DAO

Public Class PedidoLogico
    Private accesoDatos As DAO.AccesoDatos
    Public Sub New()
        iniciar()
    End Sub
    Public Sub iniciar()
        Dim cadenaConexion As String = ConfiguracionBD.obtenerCadenaConexion()
        accesoDatos = New DAO.AccesoDatos(cadenaConexion)
    End Sub

    Public Function obtener10RegistrosTablaClientes() As DataTable
        Dim nombreTabla As String = "Clientes"
        Dim consulta As String = "SELECT TOP 10 * From clientes"
        Dim tablaClientes As DataTable = Nothing
        Try
            tablaClientes = accesoDatos.AbrirTabla(nombreTabla, consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error obtener10RegistrosTablaClientes, no se pudo abrir tabla. Detalles: {ex.Message}")
        End Try
        If tablaClientes Is Nothing OrElse tablaClientes.Rows.Count = 0 Then
            Throw New ArgumentException($"Error obtener10RegistrosTablaClientes: tabla 'Clientes' está vacía o sin registros")
        End If

        Return tablaClientes

    End Function

    Public Function agregarCliente(cliente As Entidad.Cliente) As Integer

        If cliente Is Nothing Then
            Throw New ArgumentException("El pedido no puede ser nulo.")
        End If

        Dim consulta As String = $"INSERT INTO clientes(Cliente,Telefono,Correo) VALUES (@NombreCliente,@Telefono,@Correo)"
        Dim exito As Integer = 0

        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)


                exito = accesoDatos.EjecutarComando(cmd)
            End Using

        Catch ex As Exception
            Throw New ArgumentException($"Error al agregar cliente: {ex.Message}")
        End Try
        Return exito
    End Function

    Public Function agregarProducto(producto As Entidad.Producto) As Integer
        Dim consulta As String = $"INSERT INTO productos(Nombre,Precio,Categoria) VALUES (@NombreProducto, @Precio,@Categoria)"
        Dim exito As Integer = 0

        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
                cmd.Parameters.AddWithValue("@Precio", producto.Precio)
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)

                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al agregar producto: {ex.Message}")
        End Try

        Return exito
    End Function

    Public Function agregarVenta(venta As Entidad.Venta) As Integer
        Dim consulta As String = $"INSERT INTO ventas(IDCliente,Total,Fecha) VALUES (@IdCliente, @Total, @Fecha)"
        Dim exito As Integer = 0

        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)

                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al agregar venta: {ex.Message}")
        End Try

        Return exito
    End Function

    Public Function agregarVentaItem(ventaItem As Entidad.VentaItem) As Integer
        Dim consulta As String = $"INSERT INTO ventasitems(IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal) VALUES(@IdVenta,@IdProducto,@Pu,@Cantidad,@Total)"
        Dim exito As Integer = 0

        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@IdVenta", ventaItem.IdVenta)
                cmd.Parameters.AddWithValue("@IdProducto", ventaItem.IdProducto)
                cmd.Parameters.AddWithValue("@Pu", ventaItem.PU)
                cmd.Parameters.AddWithValue("@Cantidad", ventaItem.Cantidad)
                cmd.Parameters.AddWithValue("@Total", ventaItem.Total)

                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al agregar VentaItem: {ex.Message}")
        End Try


        Return exito
    End Function

    Public Function obtenerTablaVentasCompleta()
        Dim consulta As String = $"Select ventas.ID, IDCliente, clientes.Cliente, Fecha,Total,ventas.Estado from ventas Inner join clientes ON clientes.ID = ventas.IDCliente"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("ventas", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaVentasCompleta: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos

    End Function

    Public Function obtenerTablaClientesCompleta()
        Dim consulta As String = $"Select clientes.ID,clientes.Cliente,clientes.Telefono,clientes.Correo,clientes.Estado from clientes"
        Dim datos As DataTable = Nothing
        Try
            datos = accesoDatos.AbrirTabla("clientes", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaClientesCompleta: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function
    Public Function obtenerTablaProductosCompletaV2()
        Dim consulta As String = $"Select productos.ID,productos.Nombre,productos.Precio,productos.Categoria,productos.Estado from productos"
        Dim datos As DataTable = Nothing
        Try
            datos = accesoDatos.AbrirTabla("productos", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaProductosCompletaV2: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function

    Public Function obtenerTablaProductosCompleta()
        Dim consulta As String = $"Select ventas.ID, IDCliente, clientes.Cliente, Fecha, Total, ventas.Estado from ventas Inner join clientes on clientes.ID = ventas.IDCliente"
        Dim datos As DataTable = Nothing
        Try
            datos = accesoDatos.AbrirTabla("productos", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaProductosCompleta: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function
    Public Function obtenerTablaVentasFiltroFecha(venta As Entidad.Venta)
        Dim fechaInicio = venta.Fecha
        Dim fechaFin = venta.Fecha.AddDays(1)
        Dim consulta As String = $"SELECT ventas.ID, IDCliente, clientes.Cliente, Fecha, Total, ventas.Estado FROM ventas INNER JOIN clientes ON clientes.ID = ventas.IDCliente WHERE CAST(ventas.Fecha AS date) BETWEEN '{fechaInicio}' AND '{fechaFin}' ORDER BY ventas.Fecha ASC"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("ventasFiltroFecha", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaVentasFiltroFecha: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos

    End Function

    Public Function obtenerTablaDetalleVenta(venta As Entidad.VentaItem)
        Dim consulta As String = $"SELECT ventasItems.ID, ventasitems.IDVenta, ventasitems.IDProducto,ventasitems.PrecioUnitario, ventasitems.Cantidad, ventasitems.PrecioTotal FROM ventasitems WHERE ventasitems.IDVenta = {venta.IdVenta}"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("detalleVenta", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTabla DetalleVenta: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function

    Public Function obtenerTablaDetalleVentasCompleta(venta As Entidad.Venta)
        Dim consulta As String = $"Select ventasitems.ID,IDProducto, productos.Nombre, PrecioUnitario, Cantidad, PrecioTotal from ventasitems INNER JOIN productos ON productos.ID = ventasitems.IDProducto WHERE ventasitems.IDVenta = {venta.ID}"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("ventasItems", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al abrir obtenerTablaVentasCompleta: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos

    End Function

    Public Function eliminarItemVenta(productoAeliminar As Entidad.VentaItem) As Integer
        Dim consulta As String = $"Delete FROM ventasitems WHERE ventasitems.ID = {productoAeliminar.ID}"
        Dim estado As Integer = Nothing
        Try
            estado = accesoDatos.EjecutarConsulta(consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al eliminar itemVenta: {ex.Message}")
        End Try
        Return estado


    End Function
    Public Function bajaLogicaCliente(cliente As Entidad.Cliente) As Integer
        Dim consulta As String = $"UPDATE clientes set Estado = 'false' WHERE clientes.ID  = {cliente.ID}"
        Dim estado As Integer = Nothing
        Try
            estado = accesoDatos.EjecutarConsulta(consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al hacer baja logica de cliente: {ex.Message}")
        End Try
        Return estado
    End Function

    Public Function bajaLogicaProducto(prod As Entidad.Producto) As Integer
        Dim consulta As String = $"UPDATE productos set Estado = 'false' WHERE productos.ID  = {prod.ID}"
        Dim estado As Integer = Nothing
        Try
            estado = accesoDatos.EjecutarConsulta(consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al hacer baja logica de Producto: {ex.Message}")
        End Try
        Return estado
    End Function

    Public Function sumarTodasLasVentasSegunIDVENTA(venta As Entidad.Venta) As Decimal
        Dim consulta As String = $"Select SUM(PrecioTotal) From ventasitems WHERE ventasitems.IDVenta = {venta.ID}"
        Dim total As Decimal = Nothing
        Try
            total = Decimal.Parse(accesoDatos.EjecutarConsultaValorDecimal(consulta))
        Catch ex As Exception
            Throw New ArgumentException($"Error al sumar todas las ventas según IDVenta: {ex.Message}")
        End Try
        Return total

    End Function

    Public Function actualizarTotalVentaPorID(venta As Entidad.Venta) As Integer

        Dim consulta As String = $"UPDATE ventas Set Total = @total Where ventas.ID = @ID"
        Dim exito As Integer = 0

        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@total", venta.Total)
                cmd.Parameters.AddWithValue("@ID", venta.ID)

                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al actualizar el total de la tabla ventas: {ex.Message}")
        End Try


        Return exito

    End Function

    Public Function actualizarVentaItem(ventaitem As Entidad.VentaItem) As Integer
        Dim consulta As String = $"UPDATE ventasitems set IDVenta = @IDVenta, IDProducto = @IDProducto, PrecioUnitario = @PU, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE ventasitems.ID  = {ventaitem.ID} "
        Dim exito As Integer = 0
        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@IDventa", ventaitem.IdVenta)
                cmd.Parameters.AddWithValue("@IDProducto", ventaitem.IdProducto)
                cmd.Parameters.AddWithValue("@PU", ventaitem.PU)
                cmd.Parameters.AddWithValue("@Cantidad", ventaitem.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", ventaitem.Total)


                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al actualizar el item de venta de la tabla ventasitems: {ex.Message}")
        End Try


        Return exito
    End Function
    Public Function actualizarCliente(cliente As Entidad.Cliente) As Integer
        Dim consulta As String = $"UPDATE clientes set Cliente = @Cliente,Telefono = @Telefono, Correo = @Correo  WHERE clientes.ID  = {cliente.ID}"
        Dim exito As Integer = 0
        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@Cliente", cliente.NombreCliente)
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo)


                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al actualizar el cliente en funcion actualizarCliente: {ex.Message}")
        End Try


        Return exito
    End Function
    Public Function actualizarProducto(prod As Entidad.Producto) As Integer
        Dim consulta As String = $"UPDATE productos set Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria  WHERE productos.ID  = {prod.ID}"
        Dim exito As Integer = 0
        Try
            Using cmd As New SqlCommand(consulta)
                cmd.Parameters.AddWithValue("@Nombre", prod.NombreProducto)
                cmd.Parameters.AddWithValue("@Precio", prod.Precio)
                cmd.Parameters.AddWithValue("@Categoria", prod.Categoria)


                exito = accesoDatos.EjecutarComando(cmd)
            End Using


        Catch ex As Exception
            Throw New ArgumentException($"Error al actualizar el Producto en funcion actualizarProducto: {ex.Message}")
        End Try


        Return exito
    End Function

    Public Function existeVenta(venta As Entidad.Venta) As Boolean
        Dim consulta As String = $"Select * from ventas where ventas.ID = {venta.ID}"
        Return accesoDatos.Existe(consulta)

    End Function

    Public Function existeVenta(ventaItem As Entidad.VentaItem) As Boolean
        Dim consulta As String = $"Select * from ventas where ventas.ID = {ventaItem.IdVenta}"
        Return accesoDatos.Existe(consulta)
    End Function
    Public Function existeProducto(prod As Entidad.Producto) As Boolean
        Dim consulta As String = $"Select * from productos Where productos.ID = {prod.ID}"
        Return accesoDatos.Existe(consulta)
    End Function
    Public Function existeCorreo(correo As String) As Boolean
        Dim consulta As String = $"Select * from clientes Where clientes.Correo = '{correo}'"
        Return accesoDatos.Existe(consulta)
    End Function
    Public Function existeCliente(cli As Entidad.Cliente) As Boolean
        Dim consulta As String = $"Select * from clientes Where clientes.ID = {cli.ID}"
        Return accesoDatos.Existe(consulta)
    End Function

    Public Function obtenerIDYNombreProductosUNICOS()
        Dim consulta As String = $"SELECT DISTINCT(ID),Nombre from productos"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("productos", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al obtenerIDYNombreProductosUNICOS: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function

    Public Function obtenerCategoriaProductosUNICAS() As DataTable
        Dim consulta As String = $"SELECT DISTINCT(Categoria) from productos"
        Dim datos As DataTable = Nothing

        Try
            datos = accesoDatos.AbrirTabla("productos", consulta)
        Catch ex As Exception
            Throw New ArgumentException($"Error al obtenerCategoriaProductosUNICAS: {ex.Message}")
        End Try
        If datos Is Nothing Then
            Return datos
        End If
        Return datos
    End Function

End Class

