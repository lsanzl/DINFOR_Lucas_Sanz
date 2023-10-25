﻿Module VariablesGlobales

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

    'CLIENTES
    Public listaClientesAux As List(Of Cliente) = New List(Of Cliente)
    Public Sub updateListaClientes()
        listaClientesAux = New List(Of Cliente)
        listaClientesAux = managerClienteAux.getClientes()
    End Sub
    Public Function getClientePorCodigo(codigo As Integer) As Cliente
        Return listaClientesAux.Find(Function(c) c.CodigoDelCliente = codigo)
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

    ' ------------ VARIABLES GLOBALES -------------
    Private empresaSeleccionadaDB As String = Nothing
    Private seleccionadaEmpresa As Boolean = False

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