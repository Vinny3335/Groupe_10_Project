
Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class Position
    'Attributes
    Private _JobName As String
    Private _JobDescription As String
    Private _JobRequirement As String
    Private _Payement As Double
    Private _YearOfExperience As Integer
    Private _PayementWeight As Integer 'Must be bettwen 1 and 9
    'constructor
    Public Sub New()

    End Sub
    'methods

    'properties
    Public Property JobName() As String
        Get
            Return _JobName
        End Get
        Set(value As String)
            _JobName = value
        End Set
    End Property
    Public Property JobDescription() As String
        Get
            Return _JobDescription
        End Get
        Set(value As String)
            _JobDescription = value
        End Set
    End Property
    Public Property JobRequirement() As String
        Get
            Return _JobRequirement
        End Get
        Set(value As String)
            _JobRequirement = value
        End Set
    End Property
    Public Property Payement() As Double
        Get
            Return _Payement
        End Get
        Set(value As Double)
            _Payement = value
        End Set
    End Property
    Public Property YearOfExperience() As Integer
        Get
            Return _YearOfExperience
        End Get
        Set(value As Integer)
            _YearOfExperience = value
        End Set
    End Property
    Public Property PayementWeigth() As Integer
        Get
            Return _PayementWeight
        End Get
        Set(value As Integer)
            If (0 < value And value < 10) Then
                _PayementWeight = value
            Else
                Throw New ApplicationException("The Payement Weight Not In Range")
            End If
        End Set
    End Property

End Class
