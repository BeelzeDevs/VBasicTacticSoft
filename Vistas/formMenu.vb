Public Class formMenu
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click

        Dim clientesForm As New clientesForm
        Dim titulo As New Label
        titulo = lblTitulo
        lblTitulo.Text = "Menú Clientes"

        clientesForm.MainPanelContent = panelMainContent
        clientesForm.Titulo = titulo
        cargarFormEnPanelContenidoPrincipal(clientesForm)


    End Sub
    Public Sub cargarFormEnPanelContenidoPrincipal(formulario As Form)
        panelMainContent.Controls.Clear()
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        panelMainContent.Controls.Add(formulario)
        formulario.BringToFront()
        formulario.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim productosForm As New productosForm
        Dim titulo As New Label
        titulo = lblTitulo

        productosForm.MainPanelContent = panelMainContent
        productosForm.Titulo = titulo
        cargarFormEnPanelContenidoPrincipal(productosForm)
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("¿Seguro que deseas salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim ventasForm As New ventasForm
        Dim titulo As New Label
        titulo = lblTitulo

        ventasForm.MainPanelContent = panelMainContent
        ventasForm.Titulo = titulo
        cargarFormEnPanelContenidoPrincipal(ventasForm)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim formReportes As New frmReporteVentas
        Dim titutlo As New Label
        titutlo = lblTitulo


        cargarFormEnPanelContenidoPrincipal(formReportes)

    End Sub

End Class
