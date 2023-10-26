Public Class Compra
    Private codigoCompra As Integer
    Private proveedorCompra As Integer
    Private articuloCompra As String
    Private formaPagoCompra As Integer
    Private precioArticuloCompra As Double
    Private cantidadCompra As Integer
    Private precioTotalCompra As Double
    Private fechaCompra As Date
    Private eliminadoCompra As Boolean
    Private facturaCompra As String

    Public Property CodigoDeCompra() As Integer
        Get
            Return codigoCompra
        End Get
        Set(value As Integer)
            codigoCompra = value
        End Set
    End Property
    Public Property ProveedorDeCompra() As Integer
        Get
            Return proveedorCompra
        End Get
        Set(value As Integer)
            proveedorCompra = value
        End Set
    End Property
    Public Property ArticuloDeCompra() As String
        Get
            Return articuloCompra
        End Get
        Set(value As String)
            articuloCompra = value
        End Set
    End Property
    Public Property FormaDePagoCompra() As Integer
        Get
            Return formaPagoCompra
        End Get
        Set(value As Integer)
            formaPagoCompra = value
        End Set
    End Property
    Public Property PrecioDeArticuloCompra() As Double
        Get
            Return precioArticuloCompra
        End Get
        Set(value As Double)
            precioArticuloCompra = value
        End Set
    End Property
    Public Property CantidadDeCompra() As Integer
        Get
            Return cantidadCompra
        End Get
        Set(value As Integer)
            cantidadCompra = value
        End Set
    End Property
    Public Property PrecioTotalDeCompra() As Double
        Get
            Return precioTotalCompra
        End Get
        Set(value As Double)
            precioTotalCompra = value
        End Set
    End Property
    Public Property FechaDeCompra() As Date
        Get
            Return fechaCompra
        End Get
        Set(value As Date)
            fechaCompra = value
        End Set
    End Property
    Public Property CompraEliminada() As Boolean
        Get
            Return eliminadoCompra
        End Get
        Set(value As Boolean)
            eliminadoCompra = value
        End Set
    End Property
    Public Property FacturaDeCompra() As String
        Get
            Return facturaCompra
        End Get
        Set(value As String)
            facturaCompra = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(proveedorP As Integer, articuloP As String, formaP As Integer, precioP As Double, cantidadP As Integer, fechaP As Date, facturaP As String)
        MyBase.New()
        ProveedorDeCompra = proveedorP
        ArticuloDeCompra = articuloP
        FormaDePagoCompra = formaP
        PrecioDeArticuloCompra = precioP
        CantidadDeCompra = cantidadP
        FechaDeCompra = fechaP
        PrecioTotalDeCompra = PrecioDeArticuloCompra * CantidadDeCompra
        CompraEliminada = False
        facturaCompra = facturaP
    End Sub
    Public Sub New(codigoCompraP As Integer, proveedorP As Integer, articuloP As String, formaP As Integer, precioP As Double, cantidadP As Integer, fechaP As Date, facturaP As String)
        MyBase.New()
        CodigoDeCompra = codigoCompraP
        ProveedorDeCompra = proveedorP
        ArticuloDeCompra = articuloP
        FormaDePagoCompra = formaP
        PrecioDeArticuloCompra = precioP
        CantidadDeCompra = cantidadP
        FechaDeCompra = fechaP
        PrecioTotalDeCompra = PrecioDeArticuloCompra * CantidadDeCompra
        CompraEliminada = False
        facturaCompra = facturaP
    End Sub
    Public Sub New(codigoCompraP As Integer, proveedorP As Integer, articuloP As String, formaP As Integer, precioP As Double, cantidadP As Integer, fechaP As Date, eliminadaCompraP As Boolean, facturaP As String)
        MyBase.New()
        CodigoDeCompra = codigoCompraP
        ProveedorDeCompra = proveedorP
        ArticuloDeCompra = articuloP
        FormaDePagoCompra = formaP
        PrecioDeArticuloCompra = precioP
        CantidadDeCompra = cantidadP
        FechaDeCompra = fechaP
        PrecioTotalDeCompra = PrecioDeArticuloCompra * CantidadDeCompra
        CompraEliminada = eliminadaCompraP
        facturaCompra = facturaP
    End Sub
    Public Function getCompras() As List(Of Compra)
        Return managerCompraAux.getCompras()
    End Function
    Public Sub addCompra()
        managerCompraAux.addCompra(Me)
    End Sub
    Public Function getRandomFactura() As String
        Dim random As New Random()
        Dim numeroAleatorio As Integer
        Dim facturaGenerada As String
        Do
            numeroAleatorio = random.Next(1, 90001)
            facturaGenerada = "V" + numeroAleatorio.ToString()
        Loop While Not managerCompraAux.checkNumFactura(facturaGenerada)
        Return facturaGenerada
    End Function
End Class