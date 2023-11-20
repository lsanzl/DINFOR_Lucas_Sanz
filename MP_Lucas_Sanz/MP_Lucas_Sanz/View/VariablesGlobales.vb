Module VariablesGlobales

    ' ------ OBJETOS AUXILIARES DE MODELOS --------
    Public connectionDB As ConnectionDB = New ConnectionDB
    Public empresaAux As Empresa = New Empresa()
    Public bancoAux As Banco = New Banco()
    Public formaPagoAux As FormaPago = New FormaPago()
    Public grupoAux As Grupo = New Grupo()
    Public clienteAux As Cliente = New Cliente()
    Public proveedorAux As Proveedor = New Proveedor()
    Public articuloAux As Articulo = New Articulo()
    Public familiaAux As Familia = New Familia()
    Public inventarioAux As Inventario = New Inventario()
    Public compraAux As Compra = New Compra()
    Public ventaAux As Venta = New Venta()
    Public movimientoAux As Movimiento = New Movimiento()
    Public impuestoAux As Impuesto = New Impuesto()
    Public facturaAux As Factura = New Factura()
    Public vencimientoAux As Vencimiento = New Vencimiento()

    ' ----- MANAGERS AUXILIARES DE CADA CLASE -----
    Public managerEmpAux As ManagerEmpresa = New ManagerEmpresa()
    Public managerBancoAux As ManagerBanco = New ManagerBanco()
    Public managerFormaPagoAux As ManagerFormaPago = New ManagerFormaPago()
    Public managerGrupoAux As ManagerGrupo = New ManagerGrupo()
    Public managerClienteAux As ManagerCliente = New ManagerCliente()
    Public managerProveedorAux As ManagerProveedor = New ManagerProveedor()
    Public managerArticuloAux As ManagerArticulo = New ManagerArticulo()
    Public managerFamiliaAux As ManagerFamilia = New ManagerFamilia()
    Public managerInventarioAux As ManagerInventario = New ManagerInventario()
    Public managerCompraAux As ManagerCompra = New ManagerCompra()
    Public managerVentaAux As ManagerVenta = New ManagerVenta()
    Public managerConfiguracionAux As ManagerConfiguracion = New ManagerConfiguracion()
    Public managerMovimientoAux As ManagerMovimiento = New ManagerMovimiento()
    Public managerImpuestoAux As ManagerImpuesto = New ManagerImpuesto()
    Public managerFacturaAux As ManagerFactura = New ManagerFactura()
    Public managerVencimientoAux As ManagerVencimiento = New ManagerVencimiento()

    ' ----- LISTAS AUXILIARES DE CADA CLASE -----
    'ARTÍCULOS
    Public listaArticulosAux As List(Of Articulo) = New List(Of Articulo)
    Public Sub updateListaArticulos()
        listaArticulosAux = New List(Of Articulo)
        listaArticulosAux = managerArticuloAux.getArticulos()
    End Sub
    Public Function getArticuloPorNombre(nombre As String) As Articulo
        Return listaArticulosAux.Find(Function(a) a.NombreDeArticulo = nombre)
    End Function
    Public Function getArticuloPorCodigo(codigo As Integer) As Articulo
        Return listaArticulosAux.Find(Function(a) a.CodigoDeArticulo = codigo)
    End Function

    'BANCOS
    Public listaBancosAux As List(Of Banco) = New List(Of Banco)
    Public Sub updateListaBancos()
        listaBancosAux = New List(Of Banco)
        listaBancosAux = managerBancoAux.getBancos()
    End Sub
    Public Function getBancoPorCodigo(codigo As Integer) As Banco
        Return listaBancosAux.Find(Function(b) b.CodigoDeBanco = codigo)
    End Function

    'CLIENTES
    Public listaClientesAux As List(Of Cliente) = New List(Of Cliente)
    Public Sub updateListaClientes()
        listaClientesAux = New List(Of Cliente)
        listaClientesAux = managerClienteAux.getClientes()
    End Sub
    Public Function getClientePorCodigo(codigo As Integer) As Cliente
        Return listaClientesAux.Find(Function(c) c.CodigoDelCliente = codigo)
    End Function

    'COMPRAS
    Public listaComprasAux As List(Of Compra) = New List(Of Compra)
    Public Sub updateListaCompras()
        listaComprasAux = New List(Of Compra)
        listaComprasAux = managerCompraAux.getCompras()
    End Sub
    Public Function getCompraPorCodigo(codigo As Integer)
        Return listaComprasAux.Find(Function(c) c.CodigoDeCompra = codigo)
    End Function
    Public Function getCompraPorFactura(factura As String) As Compra
        Return listaComprasAux.Find(Function(c) c.FacturaDeCompra = factura)
    End Function

    'FACTURAS
    Public listaFacturasAux As List(Of Factura) = New List(Of Factura)
    Public Sub updateListaFacturas()
        listaFacturasAux = New List(Of Factura)
        listaFacturasAux = managerFacturaAux.getFacturas()
    End Sub
    Public Function getFacturaPorCodigo(codigo As Integer) As Factura
        Return listaFacturasAux.Find(Function(f) f.CodigoDeFactura = codigo)
    End Function

    'FAMILIAS
    Public listaFamiliasAux As List(Of Familia) = New List(Of Familia)
    Public Sub updateListaFamilias()
        listaFamiliasAux = New List(Of Familia)
        listaFamiliasAux = managerFamiliaAux.getFamilias()
    End Sub
    Public Function getFamiliaPorCodigo(codigo As Integer) As Familia
        Return listaFamiliasAux.Find(Function(f) f.CodigoDeFamilia = codigo)
    End Function

    'FORMAS PAGO
    Public listaFormasPagoAux As List(Of FormaPago) = New List(Of FormaPago)
    Public Sub updateListaFormasPago()
        listaFormasPagoAux = New List(Of FormaPago)
        listaFormasPagoAux = managerFormaPagoAux.getFormaPagos()
    End Sub
    Public Function getFormaPagoPorCodigo(codigo As Integer) As FormaPago
        Return listaFormasPagoAux.Find(Function(f) f.CodigoDePago = codigo)
    End Function

    'GRUPOS
    Public listaGruposAux As List(Of Grupo) = New List(Of Grupo)
    Public Sub updateListaGrupos()
        listaGruposAux = managerGrupoAux.getGrupos()
    End Sub
    Public Function getGrupoPorCodigo(codigo As Integer) As Grupo
        Return listaGruposAux.Find(Function(g) g.CodigoDeGrupo = codigo)
    End Function

    'IMPUESTOS
    Public listaImpuestosAux As List(Of Impuesto) = New List(Of Impuesto)
    Public Sub updateListaImpuestos()
        listaImpuestosAux = New List(Of Impuesto)
        listaImpuestosAux = managerImpuestoAux.getImpuestos()
    End Sub
    Public Function getImpuestoPorCodigo(codigo As Integer) As Impuesto
        Return listaImpuestosAux.Find(Function(y) y.CodigoDeImpuesto = codigo)
    End Function

    'INVENTARIO
    Public listaInventariosAux As List(Of Inventario) = New List(Of Inventario)
    Public Sub updateListaInventarios()
        listaInventariosAux = New List(Of Inventario)
        listaInventariosAux = managerInventarioAux.getInventario()
    End Sub
    Public Function getInventarioPorCodigo(codigo As Integer) As Inventario
        Return listaInventariosAux.Find(Function(i) i.CodigoDeInventario = codigo)
    End Function

    'MOVIMIENTOS
    Public listaMovimientosAux As List(Of Movimiento) = New List(Of Movimiento)
    Public Sub updateListaMovimientos()
        listaMovimientosAux = New List(Of Movimiento)
        listaMovimientosAux = managerMovimientoAux.getMovimientos()
    End Sub
    Public Function getMovimientoPorCodigo(codigo As Integer) As Movimiento
        Return listaMovimientosAux.Find(Function(m) m.CodigoDeMovimiento = codigo)
    End Function

    'PROVEEDORES
    Public listaProveedoresAux As List(Of Proveedor) = New List(Of Proveedor)
    Public Sub updateListaProveedores()
        listaProveedoresAux = New List(Of Proveedor)
        listaProveedoresAux = managerProveedorAux.getProveedores()
    End Sub
    Public Function getProveedorPorCodigo(codigo As Integer) As Proveedor
        Return listaProveedoresAux.Find(Function(p) p.CodigoDeProveedor = codigo)
    End Function

    'VENCIMIENTOS
    Public listaVencimientosAux As List(Of Vencimiento) = New List(Of Vencimiento)
    Public Sub updateListaVencimientos()
        listaVencimientosAux = New List(Of Vencimiento)
        listaVencimientosAux = managerVencimientoAux.getVencimientos()
    End Sub
    Public Function getVencimientoPorCodigo(codigo As Integer) As Vencimiento
        Return listaVencimientosAux.Find(Function(v) v.CodigoDeVencimiento = codigo)
    End Function

    'VENTAS
    Public listaVentasAux As List(Of Venta) = New List(Of Venta)
    Public Sub updateListaVentas()
        listaVentasAux = New List(Of Venta)
        listaVentasAux = managerVentaAux.getVentas()
    End Sub
    Public Function getVentaPorCodigo(codigo As Integer) As Venta
        Return listaVentasAux.Find(Function(v) v.CodigoDeVenta = codigo)
    End Function
    Public Function getVentaPorFactura(factura As String) As Venta
        Return listaVentasAux.Find(Function(v) v.FacturaDeVenta = factura)
    End Function


    ' ------------ VARIABLES GLOBALES -------------
    Private empresaSeleccionadaDB As String = Nothing
    Private seleccionadaEmpresa As Boolean = False
    Public albaranSeleccionado As String = "Ventas"

    Public Sub setEmpresaSeleccionadaDB(nombre As String)
        empresaSeleccionadaDB = nombre
    End Sub
    Public Function getEmpresaSeleccionada() As String
        Return empresaSeleccionadaDB
    End Function

    Public Sub setSeleccionadaEmpresa(estado As Boolean)
        seleccionadaEmpresa = estado
    End Sub
    Public Function getSeleccionadaEmpresa() As Boolean
        Return seleccionadaEmpresa
    End Function


    ' ------------ AJUSTE DE PANTALLAS ------------
    Public Sub AjustarFormulario(ByRef Formulario As Form)
        Dim AnchoPantallaInicial As Integer = 1024
        Dim AltoPantallaInicial As Integer = 768
        Dim ResolucionDestino As Size
        ResolucionDestino = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim AnchoPantallaDestino As Integer = ResolucionDestino.Width
        Dim AltoPantallaDestino As Integer = ResolucionDestino.Height
        Dim AnchoFormularioInicial As Double = Formulario.Width 'Ancho
        Dim AltoformularioInicial As Double = Formulario.Height 'Alto
        Dim AnchoFormularioDestino = CDbl((AnchoFormularioInicial / AnchoPantallaInicial) * AnchoPantallaDestino)
        Dim AltoFormularioDestino = CDbl((AltoformularioInicial / AltoPantallaInicial) * AltoPantallaDestino)
        Formulario.Width = CInt(AnchoFormularioDestino)
        Formulario.Height = CInt(AltoFormularioDestino)
    End Sub
    Public Sub PosicionarCentro(ByVal form As Form)
        form.Left = CType((Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2, Integer)
        form.Top = CType((Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2, Integer)
    End Sub
End Module