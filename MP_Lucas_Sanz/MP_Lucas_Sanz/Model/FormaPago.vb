Public Class FormaPago
    Private codigoPago As String
    Private nombrePago As String
    Private bancoAsignadoPago As Banco
    Private estadoPago As Integer
    Private numPlazosPago As Integer
    Private diasPrimerPlazo As Integer
    Private diasEntrePlazos As Integer

    Public Property CodigoDePago() As String
        Get
            Return codigoPago
        End Get
        Set(value As String)
            codigoPago = value
        End Set
    End Property
    Public Property NombreDePago() As String
        Get
            Return nombrePago
        End Get
        Set(value As String)
            nombrePago = value
        End Set
    End Property
    Public Property BancoAsignado() As Banco
        Get
            Return bancoAsignadoPago
        End Get
        Set(value As Banco)
            bancoAsignadoPago = value
        End Set
    End Property
    Public Property Activo() As Integer
        Get
            Return estadoPago
        End Get
        Set(value As Integer)
            estadoPago = value
        End Set
    End Property
    Public Property NumeroPlazosPago() As Integer
        Get
            Return numPlazosPago
        End Get
        Set(value As Integer)
            numPlazosPago = value
        End Set
    End Property
    Public Property PrimerPlazo() As Integer
        Get
            Return diasPrimerPlazo
        End Get
        Set(value As Integer)
            diasPrimerPlazo = value
        End Set
    End Property
    Public Property DiasPlazos() As Integer
        Get
            Return diasEntrePlazos
        End Get
        Set(value As Integer)
            diasEntrePlazos = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codigoPagoP As String, nombrePagoP As String, bancoAsignadoP As Banco,
                   estadoPagoP As Integer, numPlazosPagoP As Integer, diasPrimerPlazoP As Integer,
                   diasEntrePlazosP As Integer)
        MyBase.New()
        codigoPago = codigoPagoP
        nombrePago = nombrePagoP
        BancoAsignado = bancoAsignadoP
        estadoPago = estadoPagoP
        numPlazosPago = numPlazosPagoP
        diasPrimerPlazo = diasPrimerPlazoP
        diasEntrePlazos = diasEntrePlazosP
    End Sub

    Public Sub addFormaPago()
        'managerFormaPagoAux.addFormaPago()
    End Sub


End Class