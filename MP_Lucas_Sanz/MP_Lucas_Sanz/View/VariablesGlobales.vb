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