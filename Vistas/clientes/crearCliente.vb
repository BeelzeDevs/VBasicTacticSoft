Imports System.Text.RegularExpressions

Public Class crearCliente
    Private clienteAAgregar As New Entidad.Cliente()
    Private pl As New Negocio.PedidoLogico()
    Private Function esEmailValido(mail As String) As Boolean
        Dim regExpreEmail As New Regex("^[a-zA-Z0-9_\-]+@[a-zA-Z0-9\-]+\.[a-zA-Z]{2,}$")
        Return regExpreEmail.IsMatch(mail)
    End Function

    Private Function esTelefonoValido(tel As String) As Boolean
        Dim regExpTel As New Regex("^(11|15)\d{8}$")
        Return regExpTel.IsMatch(tel)
    End Function
    Private Function esNombreValido(nombre As String) As Boolean
        Dim regExpNombre As New Regex("^[a-zA-Z]+(\s[a-zA-Z]+)*$")
        Return regExpNombre.IsMatch(nombre)
    End Function

    Private Function validarForm() As Boolean

        Dim errores As New List(Of String)
        If String.IsNullOrEmpty(txtNombre.Text) Then
            errores.Add("* El nombre es obligatorio")

        End If
        If String.IsNullOrEmpty(txtTelefono.Text) Then
            errores.Add("* El telefono es obligatorio")
        End If
        If String.IsNullOrEmpty(txtCorreo.Text) Then
            errores.Add("* El correo es obligatorio")
        End If

        If Not esEmailValido(txtCorreo.Text) Then
            errores.Add("* El correo no es válido")
        End If

        If Not esTelefonoValido(txtTelefono.Text) Then
            errores.Add("* El telefono debe tener 10 caracteres numericos y comenzar por 11 o 15")
        End If


        If pl.existeCorreo(txtCorreo.Text) Then
            errores.Add("* El correo del cliente ya se encuentra registrado")
        End If

        If errores.Any() Then
            lblErrorMensajes.Text = String.Join(Environment.NewLine, errores)
            tablaErrores.Visible = True
            Return False
        End If

        clienteAAgregar.NombreCliente = txtNombre.Text
        clienteAAgregar.Telefono = txtTelefono.Text
        clienteAAgregar.Correo = txtCorreo.Text

        tablaErrores.Visible = False
        Return True

    End Function


    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Dim estado As Boolean = validarForm()
        If estado Then
            Dim exito As Integer = pl.agregarCliente(clienteAAgregar)
            If exito Then
                limpiarControles()
                MessageBox.Show("Agregado con éxito")
            End If
        End If
    End Sub
    Private Sub limpiarControles()
        txtCorreo.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
    End Sub
End Class