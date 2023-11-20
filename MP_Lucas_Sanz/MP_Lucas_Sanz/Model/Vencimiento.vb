Public Class Vencimiento
    Dim idVencimiento As Integer
    Dim tipoEntidad As String
    Dim clienteVencimiento As Cliente
    Dim proveedorVencimiento As Proveedor
    Dim formaPagoVencimiento As FormaPago
    Dim plazosVencimiento As Integer
    Dim plazoActual As Integer
    Dim importeVencimiento As Double
    Dim fechaVencimiento As Date
    Dim estadoVencimiento As Integer
    Dim importePagadoVencimiento As Double
    Dim importePendienteVencimiento As Double

    Property CodigoDeVencimiento() As Integer
        Get
            Return idVencimiento
        End Get
        Set(value As Integer)
            idVencimiento = value
        End Set
    End Property
    Property TipoDeEntidad() As String
        Get
            Return tipoEntidad
        End Get
        Set(value As String)
            tipoEntidad = value
        End Set
    End Property
    Property ClienteDeVencimiento() As Cliente
        Get
            Return clienteVencimiento
        End Get
        Set(value As Cliente)
            clienteVencimiento = value
        End Set
    End Property
    Property ProveedorDeVencimiento() As Proveedor
        Get
            Return proveedorVencimiento
        End Get
        Set(value As Proveedor)
            proveedorVencimiento = value
        End Set
    End Property
    Property FormaPagoDeVencimiento() As FormaPago
        Get
            Return formaPagoVencimiento
        End Get
        Set(value As FormaPago)
            formaPagoVencimiento = value
        End Set
    End Property
    Property PlazosDeVencimiento() As Integer
        Get
            Return plazosVencimiento
        End Get
        Set(value As Integer)
            plazosVencimiento = value
        End Set
    End Property
    Property PlazoActualDeVencimiento() As Integer
        Get
            Return plazoActual
        End Get
        Set(value As Integer)
            plazoActual = value
        End Set
    End Property
    Property ImporteDeVencimiento() As Double
        Get
            Return importeVencimiento
        End Get
        Set(value As Double)
            importeVencimiento = value
        End Set
    End Property
    Property FechaDeVencimiento() As Date
        Get
            Return fechaVencimiento
        End Get
        Set(value As Date)
            fechaVencimiento = value
        End Set
    End Property
    Property EstadoDeVencimiento() As Integer
        Get
            Return estadoVencimiento
        End Get
        Set(value As Integer)
            estadoVencimiento = value
        End Set
    End Property
    Property ImportePagado() As Double
        Get
            Return importePagadoVencimiento
        End Get
        Set(value As Double)
            importePagadoVencimiento = value
        End Set
    End Property
    Property ImportePendiente() As Double
        Get
            Return importePendienteVencimiento
        End Get
        Set(value As Double)
            importePendienteVencimiento = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(cliente As Cliente, formaPago As FormaPago, numPlazos As Integer, plazoActualP As Integer, importe As Double, fecha As Date, estado As Integer, importePagado As Double)
        MyBase.New()
        clienteVencimiento = cliente
        tipoEntidad = "C"
        formaPagoVencimiento = formaPago
        plazosVencimiento = numPlazos
        plazoActual = plazoActualP
        importeVencimiento = importe
        fechaVencimiento = fecha
        estadoVencimiento = estado
        importePagadoVencimiento = importePagado
        importePendienteVencimiento = importe - importePagado
    End Sub
    Public Sub New(proveedor As Proveedor, formaPago As FormaPago, numPlazos As Integer, plazoActualP As Integer, importe As Double, fecha As Date, estado As Integer, importePagado As Double)
        MyBase.New()
        proveedorVencimiento = proveedor
        tipoEntidad = "P"
        formaPagoVencimiento = formaPago
        plazosVencimiento = numPlazos
        plazoActual = plazoActualP
        importeVencimiento = importe
        fechaVencimiento = fecha
        estadoVencimiento = estado
        importePagadoVencimiento = importePagado
        importePendienteVencimiento = importe - importePagado
    End Sub
    Public Sub New(id As Integer, cliente As Cliente, formaPago As FormaPago, numPlazos As Integer, plazoActualP As Integer, importe As Double, fecha As Date, estado As Integer, importePagado As Double)
        MyBase.New()
        idVencimiento = id
        tipoEntidad = "C"
        clienteVencimiento = cliente
        formaPagoVencimiento = formaPago
        plazosVencimiento = numPlazos
        plazoActual = plazoActualP
        importeVencimiento = importe
        fechaVencimiento = fecha
        estadoVencimiento = estado
        importePagadoVencimiento = importePagado
        importePendienteVencimiento = importe - importePagado
    End Sub
    Public Sub New(id As Integer, proveedor As Proveedor, formaPago As FormaPago, numPlazos As Integer, plazoActualP As Integer, importe As Double, fecha As Date, estado As Integer, importePagado As Double)
        MyBase.New()
        idVencimiento = id
        tipoEntidad = "P"
        proveedorVencimiento = proveedor
        formaPagoVencimiento = formaPago
        plazosVencimiento = numPlazos
        plazoActual = plazoActualP
        importeVencimiento = importe
        fechaVencimiento = fecha
        estadoVencimiento = estado
        importePagadoVencimiento = importePagado
        importePendienteVencimiento = importe - importePagado
    End Sub
    Public Sub addVencimiento()
        managerVencimientoAux.addVencimiento(Me)
    End Sub
    Public Sub modifyVencimiento()
        managerVencimientoAux.modifyVencimiento(Me)
    End Sub
    Public Sub deleteVencimiento()
        managerVencimientoAux.deleteVencimiento(Me)
    End Sub
    Public Sub cobrarVencimiento()
        managerVencimientoAux.cobrarVencimiento(Me)
    End Sub
End Class