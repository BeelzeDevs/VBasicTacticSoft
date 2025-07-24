Imports System.Windows.Forms

Public Class CustomDataGridView
    Inherits DataGridView

    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            ' Cambiar el comportamiento de Enter a Tab.
            Return MyBase.ProcessDialogKey(Keys.Tab)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function
End Class
