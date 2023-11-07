Public Class Factura
    Private idFactura As Integer
    Private stringAlbaranes As String
    Private listaAlbaranes As List(Of Integer)

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
    Public Property ListaDeAlbaranes() As List(Of Integer)
        Get
            Return listaAlbaranes
        End Get
        Set(value As List(Of Integer))
            listaAlbaranes = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(stringAlbaranesP As String)
        MyBase.New()
        stringAlbaranes = stringAlbaranesP
        listaAlbaranes = getListaAlbaranes(stringAlbaranes)
    End Sub
    Public Sub New(listaAlbaranesP As List(Of Integer))
        MyBase.New()
        listaAlbaranes = listaAlbaranesP
        stringAlbaranes = getStringAlbaranes(listaAlbaranes)
    End Sub
    Public Sub New(codigoP As Integer, stringAlbaranesP As String)
        MyBase.New()
        idFactura = codigoP
        stringAlbaranes = stringAlbaranesP
        listaAlbaranes = getListaAlbaranes(stringAlbaranes)
    End Sub
    Private Sub addFactura()

    End Sub
    Private Sub modifyFactura()

    End Sub
    Private Sub deleteFactura()

    End Sub

    Private Function getListaAlbaranes(stringAlbaranesP As String) As List(Of Integer)
        Dim listaNumeros As List(Of Integer) = New List(Of Integer)
        Dim listaSplit As String() = stringAlbaranesP.Split(",")
        For Each s As String In listaSplit
            listaNumeros.Add(Convert.ToInt32(s))
        Next
        Return listaNumeros
    End Function
    Private Function getStringAlbaranes(listaNum As List(Of Integer)) As String
        Dim stringNum As String = ""
        For Each num As Integer In listaNum
            stringNum += $"{num},"
        Next
        Return stringNum
    End Function
End Class