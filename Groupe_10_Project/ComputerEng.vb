
Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class ComputerEng
    Inherits Company
    'attributes
    Private _Positions() As Position
    Private _numPosition As Integer

    'constructor
    Public Sub New(Index As Integer)
        _numPosition = Index
        ReDim _Positions(_numPosition)
        For p As Integer = 1 To _numPosition
            _Positions(p) = New Position()
        Next
    End Sub
    'methodes
    Public Overrides Function calcPayement(Index As Integer) As Double
        Return (Positions(Index).YearOfExperience * Positions(Index).PayementWeigth * 1000)
    End Function
    Public Overrides Function Display() As String
        Dim temp As String = " "
        temp = MyBase.Display()
        'iterate through all the positions
        For p As Integer = 1 To _numPosition Step 1
            temp &= "Job " & p & Environment.NewLine
            temp &= "Job name: " & Positions(p).JobName & Environment.NewLine
            temp &= "Job description: " & Positions(p).JobDescription & Environment.NewLine
            temp &= "Job requirement: " & Positions(p).JobRequirement & Environment.NewLine
            temp &= "Payement: " & Positions(p).Payement & Environment.NewLine
            temp &= "Year of Experience: " & Positions(p).YearOfExperience & Environment.NewLine
        Next
        Return temp
    End Function
    'properties
    Public Property numPosition() As Integer
        Get
            Return _numPosition
        End Get
        Set(value As Integer)
            _numPosition = value
        End Set
    End Property
    Public Property Positions(Index As Integer) As Position
        Get
            Return _Positions(Index)
        End Get
        Set(value As Position)
            _Positions(Index) = value
        End Set
    End Property

End Class
