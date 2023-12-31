﻿Public Class frmNuevoArticulo
    Private listaUnidades As List(Of String) = New List(Of String) From {"Kgs", "Metros", "Unidades", "Litros"}
    Dim familiaSeleccionada As Integer = Nothing
    Dim impuestoSeleccionado As Integer = Nothing
    Dim pvpCompraDouble As Double
    Dim porcBenefDouble As Double

    Private Sub frmNuevoArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCBUnidades()
        If btn_confirmar_articulo.Text.Equals("Confirmar") Then
            txt_codigo_articulo.Text = managerArticuloAux.getIDArticulo()
            txt_codigo_articulo.Enabled = False
        End If
    End Sub

    Private Sub fillCBUnidades()
        cb_tipo_unidad_articulo.Items.Clear()
        cb_tipo_unidad_articulo.Items.Add("")
        For Each unidad As String In listaUnidades
            cb_tipo_unidad_articulo.Items.Add(unidad)
        Next
        If btn_confirmar_articulo.Text.Equals("Confirmar") Then
            cb_tipo_unidad_articulo.Text = Nothing
        End If
    End Sub

    Private Sub click_btn_confirmar_articulo(sender As Object, e As EventArgs) Handles btn_confirmar_articulo.Click
        If Not checkCampos() Then
            Return
        End If
        Dim nombreTemp As String = txt_nombre_articulo.Text
        Dim descrTemp As String = txt_descripcion_articulo.Text
        Dim pvpCompraTemp As Double = Nothing
        If Not String.IsNullOrEmpty(txt_pvp_compra_articulo.Text) Then
            pvpCompraTemp = Convert.ToDouble(txt_pvp_compra_articulo.Text)
        End If
        Dim porcTemp As Double = Nothing
        If Not String.IsNullOrEmpty(txt_porc_beneficio_articulo.Text) Then
            porcTemp = Convert.ToDouble(txt_porc_beneficio_articulo.Text)
        End If
        Dim unidadTemp As String = ""
        If Not cb_tipo_unidad_articulo.SelectedItem = Nothing Then
            unidadTemp = cb_tipo_unidad_articulo.SelectedItem.ToString()
        End If
        Dim familiaTemp As Integer = Nothing
        If Not String.IsNullOrEmpty(txt_familia_articulo.Text) Then
            familiaTemp = familiaSeleccionada
        End If
        Dim impuestoTemp As Integer = Nothing
        If Not String.IsNullOrEmpty(txt_impuesto_articulo.Text) Then
            impuestoTemp = impuestoSeleccionado
        End If

        Dim codigoTemp As Integer
        If btn_confirmar_articulo.Text.Equals("Confirmar") Then
            codigoTemp = managerArticuloAux.getIDArticulo()
        Else
            codigoTemp = Convert.ToInt32(txt_codigo_articulo.Text)
        End If
        If btn_confirmar_articulo.Text.Equals("Modificar") Then
            unidadTemp = cb_tipo_unidad_articulo.Text
        End If
        Dim articuloTemp As Articulo = New Articulo(codigoTemp, nombreTemp, descrTemp, pvpCompraTemp, porcTemp, unidadTemp, familiaTemp, impuestoTemp)
        If btn_confirmar_articulo.Text.Equals("Modificar") Then
            articuloTemp.modifyArticulo()
        Else
            articuloTemp.addArticulo()
        End If
        Close()
    End Sub
    Private Function checkCampos() As Boolean
        If String.IsNullOrEmpty(txt_codigo_articulo.Text) Or Not IsNumeric(txt_codigo_articulo.Text) Then
            MessageBox.Show("Introduzca código válido, debe ser numérico")
            Return False
        End If
        Dim valorDouble As Double
        If Not Double.TryParse(txt_pvp_compra_articulo.Text, valorDouble) And Not String.IsNullOrEmpty(txt_pvp_compra_articulo.Text) Then
            MessageBox.Show("Introduzca un número válido")
            Return False
        End If
        If Not Double.TryParse(txt_porc_beneficio_articulo.Text, valorDouble) And Not String.IsNullOrEmpty(txt_porc_beneficio_articulo.Text) Then
            MessageBox.Show("Introduzca un número válido")
            Return False
        End If
        If Not String.IsNullOrEmpty(txt_porc_beneficio_articulo.Text) Then
            valorDouble = Convert.ToDouble(txt_porc_beneficio_articulo.Text)
            If valorDouble > 999.0 Or valorDouble < 0.00 Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub click_btn_familias_articulo(sender As Object, e As EventArgs) Handles btn_familias_articulos.Click
        txt_familia_articulo.Clear()
        frmFamilias.Text = "Familias"
        frmFamilias.ShowDialog()
        familiaSeleccionada = frmFamilias.familiaSeleccionada
        Dim familiaTemp As Familia = New Familia()
        familiaTemp = VariablesGlobales.getFamiliaPorCodigo(familiaSeleccionada)
        txt_familia_articulo.Text = familiaTemp.NombreDeFamilia
    End Sub
    Private Sub click_btn_impuestos_articulos(sender As Object, e As EventArgs) Handles btn_impuestos_articulos.Click
        txt_impuesto_articulo.Clear()
        frmFamilias.Text = "Impuestos"
        frmFamilias.ShowDialog()
        impuestoSeleccionado = frmFamilias.impuestoSeleccionado
        Dim impuestoTemp As Impuesto = VariablesGlobales.getImpuestoPorCodigo(impuestoSeleccionado)
        txt_impuesto_articulo.Text = impuestoTemp.CantidadImpuesto
    End Sub

    Private Sub txtchanged_pvp_compra_articulo(sender As Object, e As EventArgs) Handles txt_pvp_compra_articulo.TextChanged, txt_porc_beneficio_articulo.TextChanged
        txt_pvp_venta_articulo.Clear()
        If String.IsNullOrEmpty(txt_pvp_compra_articulo.Text) Or String.IsNullOrEmpty(txt_porc_beneficio_articulo.Text) Then
            Return
        End If
        If Not Double.TryParse(txt_pvp_compra_articulo.Text, pvpCompraDouble) Or Not Double.TryParse(txt_porc_beneficio_articulo.Text, porcBenefDouble) Then
            Return
        End If

        Dim pvpCompra As Double = Convert.ToDouble(Replace(txt_pvp_compra_articulo.Text, ".", ","))
        Dim porcBenef As Double = Convert.ToDouble(Replace(txt_porc_beneficio_articulo.Text, ".", ","))
        Dim precioVentaCalculado As Double
        precioVentaCalculado = pvpCompra * (1 + (porcBenef / 100))
        txt_pvp_venta_articulo.Text = String.Format("{0:F2}", precioVentaCalculado)
    End Sub
End Class