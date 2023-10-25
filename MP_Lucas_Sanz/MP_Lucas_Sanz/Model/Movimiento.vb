Public Class Movimiento
    Private codigoMovimiento As Integer
    Private tipoMovimiento As String
    Private facturaMovimiento As String
    Private clienteMovimiento As Integer
    Private proveedorMovimiento As Integer
    Private fechaMovimiento As Date
    Private articuloMovimiento As Integer
    Private stockActualMovimiento As Integer

    Public Property CodigoDeMovimiento() As Integer
        Get
            Return codigoMovimiento
        End Get
        Set(value As Integer)
            codigoMovimiento = value
        End Set
    End Property
    Public Property TipoDeMovimiento() As String
        Get
            Return tipoMovimiento
        End Get
        Set(value As String)
            tipoMovimiento = value
        End Set
    End Property
    Public Property FacturaDeMovimiento() As String
        Get
            Return facturaMovimiento
        End Get
        Set(value As String)
            facturaMovimiento = value
        End Set
    End Property
    Public Property ClienteDeMovimiento() As Integer
        Get
            Return clienteMovimiento
        End Get
        Set(value As Integer)
            clienteMovimiento = value
        End Set
    End Property
    Public Property ProveedorDeMovimiento() As Integer
        Get
            Return proveedorMovimiento
        End Get
        Set(value As Integer)
            proveedorMovimiento = value
        End Set
    End Property
    Public Property FechaDeMovimiento() As Date
        Get
            Return fechaMovimiento
        End Get
        Set(value As Date)
            fechaMovimiento = value
        End Set
    End Property
    Public Property ArticuloDeMovimiento() As Integer
        Get
            Return articuloMovimiento
        End Get
        Set(value As Integer)
            articuloMovimiento = value
        End Set
    End Property
    Public Property StockActualDeMovimiento() As Integer
        Get
            Return stockActualMovimiento
        End Get
        Set(value As Integer)
            stockActualMovimiento = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(tipoMovimientoP As String, facturaMovimientoP As String,
                   usuarioMovimientoP As Integer, fechaMovimientoP As Date,
                   articuloMovimientoP As Integer, stockActualP As Integer)
        MyBase.New()
        CodigoDeMovimiento = managerMovimientoAux.getIDMovimiento()
        TipoDeMovimiento = tipoMovimientoP
        FacturaDeMovimiento = facturaMovimientoP
        FechaDeMovimiento = fechaMovimientoP
        ArticuloDeMovimiento = articuloMovimientoP
        StockActualDeMovimiento = stockActualP
        If TipoDeMovimiento.Equals("V") Then
            ClienteDeMovimiento = usuarioMovimientoP
            ProveedorDeMovimiento = 0
        ElseIf TipoDeMovimiento.Equals("C") Then
            ProveedorDeMovimiento = usuarioMovimientoP
            ClienteDeMovimiento = 0
        Else
            ClienteDeMovimiento = 0
            ProveedorDeMovimiento = 0
            FacturaDeMovimiento = 0
        End If
    End Sub
    Public Sub New(codigoMovimientoP As Integer, tipoMovimientoP As Char, facturaMovimientoP As String,
                   usuarioMovimientoP As Integer, fechaMovimientoP As Date,
                   articuloMovimientoP As Integer, stockActualP As Integer)
        MyBase.New()
        CodigoDeMovimiento = codigoMovimientoP
        TipoDeMovimiento = tipoMovimientoP
        FacturaDeMovimiento = facturaMovimientoP
        FechaDeMovimiento = fechaMovimientoP
        ArticuloDeMovimiento = articuloMovimientoP
        StockActualDeMovimiento = stockActualP
        If tipoMovimiento.Equals("V") Then
            ClienteDeMovimiento = usuarioMovimientoP
        ElseIf tipoMovimiento.Equals("C") Then
            ProveedorDeMovimiento = usuarioMovimientoP
        Else
            ClienteDeMovimiento = Nothing
            ProveedorDeMovimiento = Nothing
            FacturaDeMovimiento = Nothing
        End If
    End Sub

    Public Sub addMovimiento()
        managerMovimientoAux.addMovimiento(Me)
    End Sub
    Public Sub modifyMovimiento()
        managerMovimientoAux.modifyMovimiento(Me)
    End Sub
    Public Sub deleteMovimiento()
        managerMovimientoAux.deleteMovimiento(Me)
    End Sub
End Class