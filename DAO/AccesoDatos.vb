Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data
Imports Entidad

Public Class AccesoDatos

    Private _rutaBD As String

    Public Sub New(cadenaConexion As String)
        Me._rutaBD = cadenaConexion
    End Sub

    Private Function AbrirConexion() As SqlConnection
        Dim conexion As New SqlConnection(_rutaBD)
        Try
            conexion.Open()
            Return conexion
        Catch ex As SqlException
            Throw New Exception($"Error al abrir la conexión a la base de datos: {ex.Message}")
        End Try
    End Function

    Public Function ObtenerAdaptador(ByVal consulta As String) As SqlDataAdapter
        Dim da As SqlDataAdapter
        Try
            Dim conexion As SqlConnection = AbrirConexion()
            da = New SqlDataAdapter(consulta, conexion)
            Return da
        Catch ex As SqlException
            Throw New Exception($"Error al obtener el adaptador: {ex.Message}")
        End Try
    End Function

    Public Function AbrirTabla(ByVal Nombretabla As String, ByVal consulta As String) As DataTable
        Dim datosTabla As New DataSet()
        Dim conexion As SqlConnection = AbrirConexion()

        If conexion IsNot Nothing Then
            Try
                Dim adaptador As New SqlDataAdapter(consulta, conexion)
                adaptador.Fill(datosTabla, Nombretabla)
            Catch ex As SqlException
                Throw New Exception($"Error al ejecutar abrirTabla : {ex.Message}")
            Finally
                conexion.Close()
            End Try
        Else
            Throw New Exception("No se pudo abrir la conexión a la base de datos")
        End If

        Return datosTabla.Tables(Nombretabla)
    End Function

    Public Function EjecutarConsulta(ByVal consulta As String) As Integer
        Dim filasCambiadas As Integer
        Dim conexion As SqlConnection = AbrirConexion()

        If conexion IsNot Nothing Then
            Try
                Dim cmd As New SqlCommand(consulta, conexion)
                filasCambiadas = cmd.ExecuteNonQuery()
            Catch ex As SqlException
                Throw New Exception($"Error al ejecutar la consulta EjecutarComando: {ex.Message}")
            Finally
                conexion.Close()
            End Try
        Else
            Throw New Exception("No se pudo abrir la conexión a la base de datos.")
        End If

        Return filasCambiadas
    End Function

    Public Function EjecutarConsultaValorDecimal(ByVal consulta As String) As Decimal
        Dim resultado As Decimal = 0
        Dim conexion As SqlConnection = AbrirConexion()

        If conexion IsNot Nothing Then
            Try
                Dim cmd As New SqlCommand(consulta, conexion)
                Dim valor = cmd.ExecuteScalar()

                If valor IsNot Nothing AndAlso IsNumeric(valor) Then
                    resultado = Convert.ToDecimal(valor)
                End If
            Catch ex As SqlException
                Throw New Exception($"Error al ejecutar la consulta EjecutarConsultaValorDecimal: {ex.Message}")
            Finally
                conexion.Close()
            End Try
        Else
            Throw New Exception("No se pudo abrir la conexión a la base de datos")
        End If

        Return resultado
    End Function


    Public Function EjecutarComando(ByVal cmd As SqlCommand) As Integer
        Dim filasCambiadas As Integer
        Dim conexion As SqlConnection = AbrirConexion()

        If conexion IsNot Nothing Then
            Try
                cmd.Connection = conexion
                filasCambiadas = cmd.ExecuteNonQuery()
            Catch ex As SqlException
                Throw New Exception($"Error al ejecutar la consulta: {ex.Message}")
            Finally
                conexion.Close()
            End Try
        Else
            Throw New Exception("No se pudo abrir la conexión a la base de datos.")
        End If

        Return filasCambiadas
    End Function


    Public Function Existe(ByVal consulta As String) As Boolean
        Dim estado As Boolean = False
        Dim conexion As SqlConnection = Nothing
        Try
            conexion = AbrirConexion()

            If conexion IsNot Nothing Then
                Dim cmd As New SqlCommand(consulta, conexion)
                Dim datareader As SqlDataReader = cmd.ExecuteReader()
                If datareader.Read() Then
                    estado = True
                End If
            Else
                Throw New Exception("No se pudo abrir la conexión a la base de datos.")
            End If
        Catch ex As SqlException
            Throw New Exception($"Error al ejecutar Existe: {ex.Message}")
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try

        Return estado
    End Function
End Class

