Public Class frmNuevoCliente
    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btn_confirmar_cliente.Text.Equals("Confirmar") Then
            clearFields()
            txt_codigo_cliente.Text = managerClienteAux.getIDCliente()
        End If
        fillCBBancos()
        fillCBGrupos()
    End Sub

    Private bancoYaSeleccionado As Integer
    Private grupoYaSeleccionado As Integer
    Private contador As Integer
    Private bancoAsignadoMod As Integer
    Private grupoAsignadoMod As Integer
    Private bancoSeleccionado As Integer = Nothing
    Private grupoSeleccionado As Integer = Nothing

    Private Sub fillCBBancos()
        contador = 0
        bancoYaSeleccionado = -1
        cb_banco_cliente.Items.Clear()

        Dim listaBancosTemp As List(Of Banco) = bancoAux.getBancos()
        cb_banco_cliente.Items.Add("")

        For Each Banco In listaBancosTemp
            If Not bancoAsignadoMod = Nothing Then
                If Banco.CodigoDeBanco = bancoAsignadoMod Then
                    bancoYaSeleccionado = contador
                End If
            End If
            cb_banco_cliente.Items.Add(Banco.CodigoDeBanco)
            contador += 1
        Next
        cb_banco_cliente.SelectedIndex = bancoYaSeleccionado
    End Sub
    Private Sub fillCBGrupos()
        contador = 0
        grupoYaSeleccionado = -1
        cb_grupo_cliente.Items.Clear()

        Dim listaGruposTemp As List(Of Grupo) = grupoAux.getGrupos()
        cb_grupo_cliente.Items.Add("")

        For Each Grupo In listaGruposTemp
            If Not grupoAsignadoMod = Nothing Then
                If Grupo.CodigoDeGrupo = grupoAsignadoMod Then
                    grupoYaSeleccionado = contador
                End If
            End If
            cb_grupo_cliente.Items.Add(Grupo.CodigoDeGrupo)
            contador += 1
        Next
        cb_grupo_cliente.SelectedIndex = grupoYaSeleccionado
    End Sub
    Public Sub setBancoAsignadoMod(numBancoMod As Integer)
        bancoAsignadoMod = numBancoMod
    End Sub
    Public Sub setGrupoAsignadoMod(grupoMod As Integer)
        grupoAsignadoMod = grupoMod
    End Sub

    Private Sub click_btn_confirmar_cliente(sender As Object, e As EventArgs) Handles btn_confirmar_cliente.Click
        Dim codigoClienteTemp As Integer = Convert.ToInt32(txt_codigo_cliente.Text)
        Dim nombreClienteTemp As String = txt_nombre_cliente.Text
        Dim nifClienteTemp As String = txt_nif_cliente.Text
        Dim direccionClienteTemp As String = txt_direccion_cliente.Text
        Dim fechaNacClienteTemp As Date = dp_fecha_nacimiento_cliente.Value
        Dim bancoClienteTemp As Integer
        If Not cb_banco_cliente.SelectedValue.Equals("") Then
            bancoClienteTemp = Convert.ToInt32(cb_banco_cliente.SelectedValue)
        Else
            bancoClienteTemp = Nothing
        End If
        Dim grupoClienteTemp As Integer
        If Not cb_grupo_cliente.SelectedValue.Equals("") Then
            grupoClienteTemp = Convert.ToInt32(cb_grupo_cliente.SelectedValue)
        Else
            grupoClienteTemp = Nothing
        End If
        Dim emailClienteTemp As String = txt_email_cliente.Text

        If Not checkCampos() Then
            Return
        End If

        Dim clienteTemp = New Cliente(codigoClienteTemp, nombreClienteTemp, nifClienteTemp, direccionClienteTemp, fechaNacClienteTemp, bancoClienteTemp, grupoClienteTemp, emailClienteTemp)
        If btn_confirmar_cliente.Text.Equals("Modificar") Then
            clienteTemp.modifyCliente()
        Else
            clienteTemp.addCliente()
        End If
        clearFields()
        Close()
    End Sub

    Private Function checkCampos() As Boolean
        If dp_fecha_nacimiento_cliente.Value > DateTime.Now Then
            MessageBox.Show("La fecha de nacimiento no puede ser posterior a la actual")
            Return False
        End If
        If txt_nif_cliente.Text.Length > 12 Then
            MessageBox.Show("Máx longitud de NIF: 12 caracteres")
            Return False
        End If
        Return True
    End Function
    Public Sub clearFields()
        txt_codigo_cliente.Clear()
        txt_nombre_cliente.Clear()
        txt_nif_cliente.Clear()
        txt_direccion_cliente.Clear()
        txt_email_cliente.Clear()
        cb_banco_cliente.SelectedIndex = -1
        cb_grupo_cliente.SelectedIndex = -1
        dp_fecha_nacimiento_cliente.Value = DateTime.Now()
    End Sub
End Class