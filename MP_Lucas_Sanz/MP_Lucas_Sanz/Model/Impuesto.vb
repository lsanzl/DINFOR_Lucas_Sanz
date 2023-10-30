Public Class Impuesto
    Private idImpuesto As Integer
    Private impuesto As Double

    Public Property CodigoDeImpuesto() As Integer
        Get
            Return idImpuesto
        End Get
        Set(value As Integer)
            idImpuesto = value
        End Set
    End Property
    Public Property CantidadImpuesto() As Double
        Get
            Return impuesto
        End Get
        Set(value As Double)
            impuesto = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(impuestoP As Double)
        MyBase.New()
        impuesto = impuestoP
    End Sub
    Public Sub New(codigoImpuestoP As Integer, impuestoP As Double)
        MyBase.New()
        idImpuesto = codigoImpuestoP
        impuesto = impuestoP
    End Sub

    Public Sub addImpuesto()
        VariablesGlobales.managerImpuestoAux.addImpuesto(Me)
    End Sub
    Public Sub deleteImpuesto()
        VariablesGlobales.managerImpuestoAux.deleteImpuesto(Me)
    End Sub
End Class