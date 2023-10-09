Public Class frmNuevoCliente
    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If btn_confirmar_cliente.Text.Equals("Confirmar") Then
            clearFields()
        End If
        fillCBBancos()
        fillCBGrupos()
    End Sub

    Private bancoYaSeleccionado As Integer
    Private grupoYaSeleccionado As Integer
    Private contador As Integer
    Private bancoAsignadoMod As Integer
    Private grupoAsignadoMod As Integer
    Private bancoSeleccionado As String = Nothing
    Private grupoSeleccionado As String = Nothing

    Private Sub fillCBBancos()
        contador = 0
        bancoYaSeleccionado = -1
        cb_banco_cliente.Items.Clear()

        Dim listaBancosTemp As List(Of Banco) = bancoAux.getBancos()
        Dim nombreBanco As String
        cb_banco_cliente.Items.Add("")

        For Each Banco In listaBancosTemp
            If Not bancoAsignadoMod = Nothing Then
                If Banco.CodigoDeBanco = bancoAsignadoMod Then
                    bancoYaSeleccionado = contador
                End If
            End If
            nombreBanco = $"{Banco.NombreDeBanco} - {Banco.CodigoDeBanco}"
            cb_banco_cliente.Items.Add(nombreBanco)
            contador += 1
        Next
        cb_banco_cliente.SelectedIndex = bancoYaSeleccionado
    End Sub
    Private Sub fillCBGrupos()
        contador = 0
        grupoYaSeleccionado = -1
        cb_grupo_cliente.Items.Clear()

        Dim listaGruposTemp As List(Of Grupo) = grupoAux.getGrupos()
        Dim nombreGrupo As String
        cb_grupo_cliente.Items.Add("")

        For Each Grupo In listaGruposTemp
            If Not grupoAsignadoMod = Nothing Then
                If Grupo.CodigoDeGrupo = grupoAsignadoMod Then
                    grupoYaSeleccionado = contador
                End If
            End If
            nombreGrupo = $"{Grupo.NombreDeGrupo} - {Grupo.CodigoDeGrupo}"
            cb_grupo_cliente.Items.Add(nombreGrupo)
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
        Dim codigoClienteTemp As String = txt_codigo_cliente.Text
        Dim nombreClienteTemp As String = txt_nombre_cliente.Text
        Dim nifClienteTemp As String = txt_nif_cliente.Text
        Dim direccionClienteTemp As String = txt_direccion_cliente.Text
        Dim fechaNacClienteTemp As Date = dp_fecha_nacimiento_cliente.Value

        Dim stringBanco() As String
        Dim stringGrupo() As String
        Dim bancoClienteTemp As String
        Dim grupoClienteTemp As String
        If Not bancoSeleccionado = Nothing Then
            stringBanco = bancoSeleccionado.Split(" - ")
            bancoClienteTemp = stringBanco(2)
        Else
            bancoClienteTemp = Nothing
        End If
        If Not grupoSeleccionado = Nothing Then
            stringGrupo = grupoSeleccionado.Split(" - ")
            grupoClienteTemp = stringGrupo(2)
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
        If String.IsNullOrEmpty(txt_codigo_cliente.Text) Then
            MessageBox.Show("Introduzca código válido")
            Return False
        End If
        If managerClienteAux.checkCliente(txt_codigo_cliente.Text) And btn_confirmar_cliente.Text.Equals("Confirmar") Then
            MessageBox.Show("Ya existe dicho cliente")
            Return False
        End If
        If txt_codigo_cliente.Text.Length > 6 Then
            MessageBox.Show("Máx longitud de código: 6 caracteres")
            Return False
        End If
        If dp_fecha_nacimiento_cliente.Value > DateTime.Now Then
            MessageBox.Show("La fecha de nacimiento no puede posterior a la actual")
            Return False
        End If
        If txt_nif_cliente.Text.Length > 12 Then
            MessageBox.Show("Máx longitud de NIF: 12 caracteres")
            Return False
        End If
        Return True
    End Function
    Private Sub cb_changed_banco_cliente(sender As Object, e As EventArgs) Handles cb_banco_cliente.SelectedIndexChanged
        If cb_banco_cliente.SelectedIndex > 0 Then
            bancoSeleccionado = cb_banco_cliente.SelectedItem.ToString()
        End If
    End Sub
    Private Sub cb_changed_grupo_cliente(sender As Object, e As EventArgs) Handles cb_grupo_cliente.SelectedIndexChanged
        If cb_grupo_cliente.SelectedIndex > 0 Then
            grupoSeleccionado = cb_grupo_cliente.SelectedItem.ToString()
        End If
    End Sub
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