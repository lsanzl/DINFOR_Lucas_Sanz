Public Class frmVerDatosProveedor
    Private Sub click_modificar_ver_datos_proveedor(sender As Object, e As EventArgs) Handles btn_modificar_proveedor.Click
        If btn_modificar_proveedor.Text.Equals("Modificar") Then
            txt_nombre_proveedor.Enabled = True
            txt_nif_proveedor.Enabled = True
            txt_direccion_proveedor.Enabled = True
            txt_poblacion_proveedor.Enabled = True
            txt_telefono_proveedor.Enabled = True

            btn_modificar_proveedor.Text = "Confirmar"
        Else
            Dim codigoTemp As String = txt_codigo_proveedor.Text
            Dim nombreTemp As String = txt_nombre_proveedor.Text
            Dim nifTemp As String = txt_nif_proveedor.Text
            Dim direccionTemp As String = txt_direccion_proveedor.Text
            Dim poblacionTemp As String = txt_poblacion_proveedor.Text
            Dim telefonoTemp As Integer = Convert.ToInt32(txt_telefono_proveedor.Text)

            Dim proveedorTemp As Proveedor = New Proveedor(codigoTemp, nombreTemp, nifTemp, direccionTemp, poblacionTemp, telefonoTemp)
            proveedorTemp.modifyProveedor()
            btn_modificar_proveedor.Text = "Modificar"
            Close()
        End If
    End Sub
End Class