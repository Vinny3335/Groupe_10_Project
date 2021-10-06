
Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public MustInherit Class Company
    'Attributes
    Protected _Name As String
    Protected _Location As String
    Protected _Email As String
    Protected _PhoneNumber As Integer 'must Positive and must be 10 digits

    'Constructor
    Public Sub New()

    End Sub
    'Methodes
    Public MustOverride Function calcPayement(Index As Integer) As Double
    Public Function DisplayCompanyName() As String
        Dim temp As String = " "
        temp = "Name: " & _Name & Environment.NewLine
        Return temp
    End Function
    Public Overridable Function Display() As String
        Dim temp As String = " "
        temp = "Name: " & _Name & Environment.NewLine
        temp &= "Location: " & _Location & Environment.NewLine
        temp &= "Email: " & _Email & Environment.NewLine
        temp &= "Phone Number: " & _PhoneNumber & Environment.NewLine
        Return temp
    End Function
    'Properties
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
    Public WriteOnly Property Location() As String
        Set(value As String)
            _Location = value
        End Set
    End Property
    Public WriteOnly Property Email() As String
        Set(value As String)
            _Email = value
        End Set
    End Property
    Public WriteOnly Property PhoneNumber() As Integer
        Set(value As Integer)
            If (value > 0) Then
                _PhoneNumber = value
            Else
                Throw New System.Exception("Invalid Phone Number") ' first option
                Throw New ApplicationException("Invalid Phone Number") ' second option
            End If
        End Set
    End Property
End Class
