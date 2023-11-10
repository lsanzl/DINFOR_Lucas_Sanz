Public Class ctrFactura
    Private frm As frmMain
    Private dg As DataGridView
    Private listaFacturas As List(Of Factura)
    Private clienteTemp As Cliente
    Private proveedorTemp As Proveedor
    Private codigoCliente As Integer
    Private codigoProveedor As Integer
    Private tipoFactura As String = "Compras"

    Public Sub New(frmP As frmMain)
        MyBase.New()
        frm = frmP
        dg = frm.dg_facturas
        frm.rdb_facturas_compra.Checked = True

        AddHandler frm.btn_facturar_albaran.Click, AddressOf click_btn_facturar_albaran
        AddHandler frm.rdb_facturas_compra.CheckedChanged, AddressOf checked_changed_gb_facturas
        AddHandler frm.rdb_facturas_venta.CheckedChanged, AddressOf checked_changed_gb_facturas
    End Sub

    Private Sub checked_changed_gb_facturas(sender As Object, e As EventArgs)
        If frm.rdb_facturas_compra.Checked Then
            tipoFactura = "Compras"
            fillDGFacturas()
        Else
            tipoFactura = "Ventas"
            fillDGFacturas()
        End If
    End Sub

    Private Sub fillDGFacturas()
        dg.Rows.Clear()
        listaFacturas = New List(Of Factura)
        listaFacturas = listaFacturasAux
        If tipoFactura.Equals("Compras") Then
            fillDGFacturasCompras(listaFacturas)
        Else
            fillDGFacturasVentas(listaFacturas)
        End If
    End Sub
    Private Sub fillDGFacturasCompras(listaFacturas As List(Of Factura))
        Dim cbAlbaranes As DataGridViewComboBoxCell
        For Each f As Factura In listaFacturas
            If f.TipoDeFactura.Equals("V") Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            codigoProveedor = getCompraPorCodigo(f.ListaDeAlbaranes(0)).ProveedorDeCompra
            proveedorTemp = getProveedorPorCodigo(codigoProveedor)

            dg.Rows(index).Cells("idFactura").Value = f.CodigoDeFactura
            dg.Rows(index).Cells("entidadFactura").Value = proveedorTemp.NombreDeProveedor
            cbAlbaranes = dg.Rows(index).Cells("listaAlbaranesFactura")
            For Each stringFactura As String In f.ListaDeAlbaranes
                cbAlbaranes.Items.Add(stringFactura)
            Next
            dg.Rows(index).Cells("estadoFactura").Value = f.EstadoDeFactura
        Next
    End Sub
    Private Sub fillDGFacturasVentas(listaFacturas As List(Of Factura))
        Dim cbAlbaranes As DataGridViewComboBoxCell
        For Each f As Factura In listaFacturas
            If f.TipoDeFactura.Equals("C") Then
                Continue For
            End If
            Dim index As Integer = dg.Rows.Add()
            codigoCliente = getVentaPorCodigo(f.ListaDeAlbaranes(0)).ClienteDeVenta
            clienteTemp = getClientePorCodigo(codigoCliente)

            dg.Rows(index).Cells("idFactura").Value = f.CodigoDeFactura
            dg.Rows(index).Cells("entidadFactura").Value = clienteTemp.NombreDelCliente
            cbAlbaranes = dg.Rows(index).Cells("listaAlbaranesFactura")
            For Each stringFactura As String In f.ListaDeAlbaranes
                cbAlbaranes.Items.Add(stringFactura)
            Next
            dg.Rows(index).Cells("estadoFactura").Value = f.EstadoDeFactura
        Next
    End Sub

    Private Sub click_btn_facturar_albaran(sender As Object, e As EventArgs)
        Dim frmF As frmFactura = New frmFactura(True)
        frmF.btn_busqueda_cliente.Visible = True
        frmF.ShowDialog()
        fillDGFacturas()
    End Sub
End Class