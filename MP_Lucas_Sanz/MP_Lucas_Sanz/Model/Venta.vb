Public Class Venta
    Private codigoVenta As Integer
    Private clienteVenta As Integer
    Private articuloVenta As String
    Private formaPagoVenta As Integer
    Private precioArticuloVenta As Double
    Private cantidadVenta As Integer
    Private descuentoVenta As Double
    Private precioTotalVenta As Double
    Private fechaVenta As Date
    Private eliminadoVenta As Boolean
    Private facturaVenta As String

    Public Property CodigoDeVenta() As Integer
        Get
            Return codigoVenta
        End Get
        Set(value As Integer)
            codigoVenta = value
        End Set
    End Property
    Public Property ClienteDeVenta() As Integer
        Get
            Return clienteVenta
        End Get
        Set(value As Integer)
            clienteVenta = value
        End Set
    End Property
    Public Property ArticuloDeVenta() As String
        Get
            Return articuloVenta
        End Get
        Set(value As String)
            articuloVenta = value
        End Set
    End Property
    Public Property FormaDePagoVenta() As Integer
        Get
            Return formaPagoVenta
        End Get
        Set(value As Integer)
            formaPagoVenta = value
        End Set
    End Property
    Public Property PrecioDeArticuloVenta() As Double
        Get
            Return precioArticuloVenta
        End Get
        Set(value As Double)
            precioArticuloVenta = value
        End Set
    End Property
    Public Property CantidadDeVenta() As Integer
        Get
            Return cantidadVenta
        End Get
        Set(value As Integer)
            cantidadVenta = value
        End Set
    End Property
    Public Property DescuentoDeVenta() As Double
        Get
            Return descuentoVenta
        End Get
        Set(value As Double)
            descuentoVenta = value
        End Set
    End Property
    Public Property PrecioTotalDeVenta() As Double
        Get
            Return precioTotalVenta
        End Get
        Set(value As Double)
            precioTotalVenta = value
        End Set
    End Property
    Public Property FechaDeVenta() As Date
        Get
            Return fechaVenta
        End Get
        Set(value As Date)
            fechaVenta = value
        End Set
    End Property
    Public Property VentaEliminada() As Boolean
        Get
            Return eliminadoVenta
        End Get
        Set(value As Boolean)
            eliminadoVenta = value
        End Set
    End Property
    Public Property FacturaDeVenta() As String
        Get
            Return facturaVenta
        End Get
        Set(value As String)
            facturaVenta = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date, facturaP As String, descuentoP As Double)
        MyBase.New()
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        descuentoVenta = descuentoP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
        VentaEliminada = False
        FacturaDeVenta = facturaP
    End Sub
    Public Sub New(codigoVentaP As Integer, clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date, descuentoP As Double)
        MyBase.New()
        CodigoDeVenta = codigoVentaP
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        descuentoVenta = descuentoP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
        VentaEliminada = False
    End Sub
    Public Sub New(codigoVentaP As Integer, clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date, eliminadoVentaP As Boolean, descuentoP As Double)
        MyBase.New()
        CodigoDeVenta = codigoVentaP
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        descuentoVenta = descuentoP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
        VentaEliminada = eliminadoVentaP
    End Sub
    Public Sub New(codigoVentaP As Integer, clienteP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer, fechaP As Date, eliminadoVentaP As Boolean, facturaVentaP As String, descuentoP As Double)
        MyBase.New()
        CodigoDeVenta = codigoVentaP
        ClienteDeVenta = clienteP
        ArticuloDeVenta = articuloP
        FormaDePagoVenta = formaP
        PrecioDeArticuloVenta = precioP
        CantidadDeVenta = cantidadP
        descuentoVenta = descuentoP
        FechaDeVenta = fechaP
        PrecioTotalDeVenta = PrecioDeArticuloVenta * CantidadDeVenta
        VentaEliminada = eliminadoVentaP
        FacturaDeVenta = facturaVentaP
    End Sub
    Public Function getVentas() As List(Of Venta)
        Return managerVentaAux.getVentas()
    End Function
    Public Sub addVenta()
        managerVentaAux.addVenta(Me)
    End Sub
    Public Sub deleteVenta()
        managerVentaAux.cambiarEliminadoVenta(Me)
    End Sub
    Public Function getRandomFactura() As String
        Dim random As New Random()
        Dim numeroAleatorio As Integer
        Dim facturaGenerada As String
        Do
            numeroAleatorio = random.Next(1, 90001)
            facturaGenerada = "V" + numeroAleatorio.ToString()
        Loop While Not managerVentaAux.checkNumFactura(facturaGenerada)
        Return facturaGenerada
    End Function
End Class