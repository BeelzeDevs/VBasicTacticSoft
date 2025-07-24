Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporteVentas
    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Ruta del archivo de reporte (.rpt)
            Dim rutaReporte As String = IO.Path.Combine(Application.StartupPath, "..\..\..\reportes\reporteVentas.rpt")





            Dim reporte As New ReportDocument()
            reporte.Load(rutaReporte)

            ' Conexión a la base de datos (solo si es necesaria)
            'reporte.SetDatabaseLogon("sa", "sasa", "LOCALHOST\SQLEXPRESS", "pruebademo")


            CrystalReportViewer1.ReportSource = reporte
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el reporte: " & ex.Message)
        End Try
    End Sub
End Class
