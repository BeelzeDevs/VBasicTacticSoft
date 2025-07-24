Public Class clientesForm
    Public Property MainPanelContent As Panel
    Public Property Titulo As Label

    Private Sub clientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With layoutContainerBtns
            .FlowDirection = FlowDirection.TopDown
            .WrapContents = False
            .AutoScroll = True
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        End With

        AddHandler layoutContainerBtns.Resize, Sub(senderResize, eResize)
                                                   centrarContenido()
                                               End Sub
        centrarContenido()
        Titulo.Text = "Menú Clientes"
    End Sub

    Private Sub centrarContenido()
        layoutContainerBtns.SuspendLayout()
        Try
            If layoutContainerBtns.Controls.Count = 0 Then
                layoutContainerBtns.Padding = New Padding(0)
                Return
            End If

            Dim anchoTotalBtn As Integer = layoutContainerBtns.Controls(0).Width
            Dim correccionEjeX As Integer = (layoutContainerBtns.ClientSize.Width - anchoTotalBtn) / 2

            Dim altoTotalBtn As Integer = layoutContainerBtns.Controls(0).Width
            Dim correccionEjeY As Integer = (layoutContainerBtns.ClientSize.Width - altoTotalBtn) / 2
            Dim correcionTop As Integer = (Me.Height - layoutContainerBtns.ClientSize.Height)
            layoutContainerBtns.Padding = New Padding(Math.Max(correccionEjeX, 0), 150, 0, 0)

        Finally
            layoutContainerBtns.ResumeLayout()
        End Try
    End Sub

    Public Sub cargarFormEnPanelContenidoPrincipal(formulario As Form)
        MainPanelContent.Controls.Clear()
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        MainPanelContent.Controls.Add(formulario)
        formulario.BringToFront()
        formulario.Show()
    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click
        Titulo.Text = "Crear Cliente"
        cargarFormEnPanelContenidoPrincipal(crearCliente)
    End Sub

    Private Sub btnModificarUsuarios_Click(sender As Object, e As EventArgs) Handles btnBuscadorClientes.Click
        Titulo.Text = "Buscador de Clientes"
        cargarFormEnPanelContenidoPrincipal(listarClientes)
    End Sub

    Private Sub btnBajaModClientes_Click(sender As Object, e As EventArgs) Handles btnBajaModClientes.Click
        Titulo.Text = "Baja - Modificación Clientes"
        cargarFormEnPanelContenidoPrincipal(BM_Clientes)
    End Sub
End Class