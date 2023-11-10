Public Class Factura
    Private idFactura As Integer
    Private stringAlbaranes As String
    Private listaAlbaranes As List(Of String)
    Private fechaCobro As DateTime
    Private estadoFactura As String
    Private tipoFactura As String

    Public Property CodigoDeFactura() As Integer
        Get
            Return idFactura
        End Get
        Set(value As Integer)
            idFactura = value
        End Set
    End Property
    Public Property StringDeAlbaranes() As String
        Get
            Return stringAlbaranes
        End Get
        Set(value As String)
            stringAlbaranes = value
        End Set
    End Property
    Public Property ListaDeAlbaranes() As List(Of String)
        Get
            Return listaAlbaranes
        End Get
        Set(value As List(Of String))
            listaAlbaranes = value
        End Set
    End Property
    Public Property FechaDeCobro() As DateTime
        Get
            Return fechaCobro
        End Get
        Set(value As DateTime)
            fechaCobro = value
        End Set
    End Property
    Public Property EstadoDeFactura() As String
        Get
            Return estadoFactura
        End Get
        Set(value As String)
            estadoFactura = value
        End Set
    End Property
    Public Property TipoDeFactura() As String
        Get
            Return tipoFactura
        End Get
        Set(value As String)
            tipoFactura = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(stringAlbaranesP As String, fechaP As DateTime, estadoP As String, tipo As String)
        MyBase.New()
        stringAlbaranes = stringAlbaranesP
        listaAlbaranes = getListaAlbaranes(stringAlbaranes)
        estadoFactura = estadoP
        tipoFactura = tipo
    End Sub
    Public Sub New(listaAlbaranesP As List(Of String), fechaP As DateTime, estadoP As String, tipo As String)
        MyBase.New()
        listaAlbaranes = listaAlbaranesP
        stringAlbaranes = getStringAlbaranes(listaAlbaranes)
        estadoFactura = estadoP
        tipoFactura = tipo
    End Sub
    Public Sub New(codigoP As Integer, stringAlbaranesP As String, fechaP As DateTime, estadoP As String, tipo As String)
        MyBase.New()
        idFactura = codigoP
        stringAlbaranes = stringAlbaranesP
        listaAlbaranes = getListaAlbaranes(stringAlbaranes)
        estadoFactura = estadoP
        tipoFactura = tipo
    End Sub
    Public Sub addFactura()
        managerFacturaAux.addFactura(Me)
    End Sub
    Public Sub modifyFactura()
        managerFacturaAux.modifyFactura(Me)
    End Sub
    Public Sub deleteFactura()
        managerFacturaAux.deleteFactura(Me)
    End Sub

    Private Function getListaAlbaranes(stringAlbaranesP As String) As List(Of String)
        Dim listaNumerosFac As List(Of String) = New List(Of String)
        Dim listaSplit As String() = stringAlbaranesP.Split(",")
        For Each s As String In listaSplit
            listaNumerosFac.Add(s)
        Next
        Return listaNumerosFac
    End Function
    Private Function getStringAlbaranes(listaNumerosFac As List(Of String)) As String
        Dim stringNum As String = ""
        For Each numF As String In listaNumerosFac
            stringNum += $"{numF},"
        Next
        Return stringNum
    End Function
End Class