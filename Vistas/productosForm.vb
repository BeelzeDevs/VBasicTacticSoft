Imports Negocio
Public Class productosForm

    Public Property MainPanelContent As Panel
    Public Property Titulo As Label

    Private pl As New PedidoLogico()

    Private Sub productosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Titulo.Text = "Menú Productos"

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

    Private Sub btnCrearProducto_Click(sender As Object, e As EventArgs) Handles btnCrearProducto.Click
        Titulo.Text = "Crear Producto"
        cargarFormEnPanelContenidoPrincipal(crearProducto)
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnBajaModProducto.Click
        Titulo.Text = "Baja - Modificación Productos"
        cargarFormEnPanelContenidoPrincipal(BM_Productos)
    End Sub

    Private Sub btnListarProducto_Click(sender As Object, e As EventArgs) Handles btnListarProducto.Click
        Titulo.Text = "Buscador de Productos"
        cargarFormEnPanelContenidoPrincipal(listarProductos)
    End Sub
End Class