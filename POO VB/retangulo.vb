Public Class retangulo
    'Campos, Atributos ou data Field
    Private _comprimento As Double
    Private _largura As Double

    Public Property Comprimento As Double
        Get
            Return _comprimento
        End Get
        Set(value As Double)
            _comprimento = value
        End Set
    End Property

    Public Property Largura As Double
        Get
            Return _largura
        End Get
        Set(value As Double)
            _largura = value
        End Set
    End Property
    'Construtor
    Public Sub New(C As Double, L As Double)
        Largura = L
        Comprimento = C
    End Sub
    'Construtor Padrão
    Public Sub New()

    End Sub

    'Métodos que retirna valor
    Public Function GetArea() As Double
        Return Comprimento * Largura
    End Function
    'Metodos não retorna valor
    Public Sub initFields(C As Double, L As Double)
        Comprimento = C
        Largura = L
    End Sub

End Class
