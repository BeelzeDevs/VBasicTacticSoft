Imports System.Configuration

Public Class ConfiguracionBD

    Public Shared Function obtenerCadenaConexion() As String
        Return ConfigurationManager.ConnectionStrings("CadenaConexion").ConnectionString
    End Function
End Class

