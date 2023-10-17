﻿Imports System.ComponentModel

Public Class infCompra
    Dim listaCompra As BindingList(Of Compra) = New BindingList(Of Compra)
    Dim fechaCompra As Date

    Public Sub New(listaCompraP As BindingList(Of Compra), fechaCompraP As Date)
        MyBase.New()
        listaCompra = New BindingList(Of Compra)
        listaCompra = listaCompraP
        fechaCompra = fechaCompraP

        showReport()
    End Sub
    Private Sub showReport()
        Dim codigoProveedor As String = listaCompra(0).ProveedorDeCompra
        Dim ds As DataSet = New dsCompra

        Dim dr As DataRow

        For Each c As Compra In listaCompra
            dr = ds.Tables("Compra").NewRow()

            dr("Proveedor") = c.ProveedorDeCompra
            dr("Artículo") = c.ArticuloDeCompra
            dr("Forma Pago") = c.FormaDePagoCompra
            dr("Precio Unitario") = c.PrecioDeArticuloCompra
            dr("Cantidad") = c.CantidadDeCompra
            dr("Precio Total") = c.PrecioDeArticuloCompra * c.CantidadDeCompra

            ds.Tables("Compra").Rows.Add(dr)
        Next

        Dim drP As DataRow
        Dim proveedorSeleccionado As Proveedor = getProveedorSeleccionado(codigoProveedor)

        drP = ds.Tables("Proveedor").NewRow()
        drP("Código") = proveedorSeleccionado.CodigoDeProveedor
        drP("Nombre") = proveedorSeleccionado.NombreDeProveedor
        drP("Dirección") = proveedorSeleccionado.DireccionDeProveedor
        drP("Teléfono") = proveedorSeleccionado.TelefonoDeProveedor
        drP("Fecha Compra") = fechaCompra

        ds.Tables("Proveedor").Rows.Add(drP)

        Dim informe As New rptCompra()
        informe.SetDataSource(ds)
        informe.Refresh()

        Dim visorRPT As viewerRPTCompra = New viewerRPTCompra()
        visorRPT.crvCompra.ReportSource = informe
        visorRPT.Text = "Informe de Compra"
        visorRPT.WindowState = FormWindowState.Maximized
        visorRPT.ShowDialog()
    End Sub
    Private Function getProveedorSeleccionado(codigoProveedor As String) As Proveedor
        Dim listaProveedores As List(Of Proveedor) = proveedorAux.getProveedores()
        Dim proveedorFind As Proveedor = listaProveedores.Find(Function(p) p.CodigoDeProveedor = codigoProveedor)
        Return proveedorFind
    End Function
End Class
