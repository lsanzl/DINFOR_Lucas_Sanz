Public Class frmNuevoProveedor
    Private Sub click_btn_confirmar_proveedor(sender As Object, e As EventArgs) Handles btn_confirmar_proveedor.Click
        If checkCampos() Then
            Dim codigoTemp As String = txt_codigo_proveedor.Text
            Dim nombreTemp As String = txt_nombre_proveedor.Text
            Dim nifTemp As String = txt_nif_proveedor.Text
            Dim direccionTemp As String = txt_direccion_proveedor.Text
            Dim poblacionTemp As String = txt_poblacion_proveedor.Text
            Dim telefonoTemp As Integer = Nothing
            If Not String.IsNullOrEmpty(txt_telefono_proveedor.Text) Then
                telefonoTemp = Convert.ToInt64(txt_telefono_proveedor.Text)
            End If
            Dim proveedorTemp As Proveedor = New Proveedor(codigoTemp, nombreTemp, nifTemp, direccionTemp, poblacionTemp, telefonoTemp)
            If btn_confirmar_proveedor.Text = "Confirmar" Then
                proveedorTemp.addProveedor()
            Else
                proveedorTemp.modifyProveedor()
            End If
            Close()
        End If
    End Sub
    Private Function checkCampos() As Boolean
        If String.IsNullOrEmpty(txt_codigo_proveedor.Text) Then
            MessageBox.Show("Introduzca código válido")
            Return False
        End If
        If txt_codigo_proveedor.Text.Length > 6 Then
            MessageBox.Show("Introduzca código válido (máx 6 caracteres)")
            Return False
        End If
        If managerProveedorAux.checkCodigo(txt_codigo_proveedor.Text) And btn_confirmar_proveedor.Text = "Confirmar" Then
            MessageBox.Show("Código repetido")
            Return False
        End If
        If txt_nif_proveedor.Text.Length > 12 Then
            MessageBox.Show("Introduzca NIF válido (máx 12 caracteres)")
            Return False
        End If
        If Not IsNumeric(txt_telefono_proveedor.Text) And Not String.IsNullOrEmpty(txt_telefono_proveedor.Text) Then
            MessageBox.Show("Introduzca un número de teléfono válido")
            Return False
        End If
        If txt_telefono_proveedor.Text.Length > 9 Then
            MessageBox.Show("Número de teléfono demasiado largo")
            Return False
        End If
        Return True
    End Function

    Private Sub frmNuevoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class