
Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmGroup10
    'Global variables
    Private Companies() As Company
    Private numCompany As Integer = 0
    Private count As Integer = 1
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private fileName As String = "dataBase.info"
    'form load
    Private Sub frmGroup10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCompanies.Text = "LIST OF COMPANIES" & Environment.NewLine
        txtDetails.Text = "COMPANY DETAILS" & Environment.NewLine
        'When the file opens, get all the company names in the file
        FS = New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim CompaniesTemp As Company
        While FS.Position < FS.Length
            'do a direct cast into the base class.
            CompaniesTemp = DirectCast(BF.Deserialize(FS), Company)
            txtCompanies.Text &= CompaniesTemp.DisplayCompanyName()
        End While
        'close the file
        FS.Close()
    End Sub
    'get the details for each company
    Private Sub btnCompanyDetails_Click(sender As Object, e As EventArgs) Handles btnCompanyDetails.Click
        Try
            Dim choice As Integer = CInt(InputBox("1. Electrical Enginnering Company" & Environment.NewLine &
                                              "2. Mechanical Enginnering Company" & Environment.NewLine &
                                              "3. Civil Enginnering Company" & Environment.NewLine &
                                              "4. Computer Enginnering Company" & Environment.NewLine, "Select the type of company"))
            numCompany += 1
            Select Case choice
                Case 1 'Electrical Enginnering Company
                    ReDim Preserve Companies(numCompany)
                    Dim numPosition As Integer = CInt(InputBox("Enter the number of positions available"))
                    Dim temp As ElectricalEng = New ElectricalEng(numPosition)
                    temp.Name = InputBox("Enter the company name", "Electrical company")
                    temp.Location = InputBox("Enter the company location", "Electrical company")
                    temp.Email = InputBox("Enter the company email address", "Electrical company")
                    temp.PhoneNumber = CInt(InputBox("Enter the company phone number", "Electrical company"))
                    For p As Integer = 1 To numPosition Step 1
                        temp.Positions(p).JobName = InputBox("Enter the job name", "Electrical company" & "Position " & p)
                        temp.Positions(p).JobDescription = InputBox("Enter the job description", "Electrical company" & " Position " & p)
                        temp.Positions(p).JobRequirement = InputBox("Enter the job requirement", "Electrical company" & " Position " & p)
                        temp.Positions(p).YearOfExperience = CInt(InputBox("Enter the required years of experience", "Electrical company" & " Position " & p))
                        temp.Positions(p).PayementWeigth = CInt(InputBox("Enter the payement weight between 0 and 9 included", "Electrical company" & " Position " & p))
                        temp.Positions(p).Payement = temp.calcPayement(p)
                    Next
                    txtCompanies.Text &= temp.DisplayCompanyName()
                    Companies(numCompany) = temp
                Case 2 'Mechanical Enginnering Company
                    ReDim Preserve Companies(numCompany)
                    Dim numPosition As Integer = CInt(InputBox("Enter the number of positions available"))
                    Dim temp As MechanicalEng = New MechanicalEng(numPosition)
                    temp.Name = InputBox("Enter the company name", "Mechanical company")
                    temp.Location = InputBox("Enter the company location", "Mechanical company")
                    temp.Email = InputBox("Enter the company email address", "Mechanical company")
                    temp.PhoneNumber = CInt(InputBox("Enter the company phone number", "Mechanical company"))
                    For p As Integer = 1 To numPosition Step 1
                        temp.Positions(p).JobName = InputBox("Enter the job name", "Mechanical company" & " Position " & p)
                        temp.Positions(p).JobDescription = InputBox("Enter the job description", "Mechanical company" & " Position " & p)
                        temp.Positions(p).JobRequirement = InputBox("Enter the job requirement", "Mechanical company" & " Position " & p)
                        temp.Positions(p).YearOfExperience = CInt(InputBox("Enter the required years of experience", "Mechanical company" & " Position " & p))
                        temp.Positions(p).PayementWeigth = CInt(InputBox("Enter the payement weight between 0 and 9 included", "Mechanical company" & " Position " & p))
                        temp.Positions(p).Payement = temp.calcPayement(p)
                    Next
                    txtCompanies.Text &= temp.DisplayCompanyName()
                    Companies(numCompany) = temp
                Case 3 'Civil Enginnering Company
                    ReDim Preserve Companies(numCompany)
                    Dim numPosition As Integer = CInt(InputBox("Enter the number of positions available"))
                    Dim temp As CivilEng = New CivilEng(numPosition)
                    temp.Name = InputBox("Enter the company name", "Civil company")
                    temp.Location = InputBox("Enter the company location", "Civil company")
                    temp.Email = InputBox("Enter the company email address", "Civil company")
                    temp.PhoneNumber = CInt(InputBox("Enter the company phone number", "Civil company"))
                    For p As Integer = 1 To numPosition Step 1
                        temp.Positions(p).JobName = InputBox("Enter the job name", "Civil company" & "Position " & p)
                        temp.Positions(p).JobDescription = InputBox("Enter the job description", "Civil company" & " Position " & p)
                        temp.Positions(p).JobRequirement = InputBox("Enter the job requirement", "Civil company" & " Position " & p)
                        temp.Positions(p).YearOfExperience = CInt(InputBox("Enter the required years of experience", "Civil company" & " Position " & p))
                        temp.Positions(p).PayementWeigth = CInt(InputBox("Enter the payement weight between 0 and 9 included", "Civil company" & " Position " & p))
                        temp.Positions(p).Payement = temp.calcPayement(p)
                    Next
                    txtCompanies.Text &= temp.DisplayCompanyName()
                    Companies(numCompany) = temp
                Case 4 'Computer Enginnering Company
                    ReDim Preserve Companies(numCompany)
                    Dim numPosition As Integer = CInt(InputBox("Enter the number of positions available"))
                    Dim temp As ComputerEng = New ComputerEng(numPosition)
                    temp.Name = InputBox("Enter the company name", "Computer company")
                    temp.Location = InputBox("Enter the company location", "Computer company")
                    temp.Email = InputBox("Enter the company email address", "Computer company")
                    temp.PhoneNumber = CInt(InputBox("Enter the company phone number", "Computer company"))
                    For p As Integer = 1 To numPosition Step 1
                        temp.Positions(p).JobName = InputBox("Enter the job name", "Computer company" & "Position " & p)
                        temp.Positions(p).JobDescription = InputBox("Enter the job description", "Computer company" & " Position " & p)
                        temp.Positions(p).JobRequirement = InputBox("Enter the job requirement", "Computer company" & " Position " & p)
                        temp.Positions(p).YearOfExperience = CInt(InputBox("Enter the required years of experience", "Computer company" & " Position " & p))
                        temp.Positions(p).PayementWeigth = CInt(InputBox("Enter the payement weight between 0 and 9 included", "Computer company" & " Position " & p))
                        temp.Positions(p).Payement = temp.calcPayement(p)
                    Next
                    txtCompanies.Text &= temp.DisplayCompanyName()
                    Companies(numCompany) = temp
                Case Else
                    numCompany -= 1
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'save all the data to file
    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        FS = New FileStream(fileName, FileMode.Append, FileAccess.Write)
        BF = New BinaryFormatter()
        For c As Integer = count To numCompany
            BF.Serialize(FS, Companies(c))
            count = c
        Next
        'increament the counter only when the number of company has changed
        If count = numCompany Then
            count += 1
        End If
        MessageBox.Show("Data_Saved")
        'close the file
        FS.Close()
    End Sub
    'find a specific company in the file and display to text box
    Private Sub btnCompDetails_Click(sender As Object, e As EventArgs) Handles btnCompDetails.Click
        'clear the detail text box , to allow more search
        txtDetails.Clear()
        txtDetails.Text = "COMPANY DETAILS" & Environment.NewLine
        'read from the file
        FS = New FileStream(fileName, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim CompaniesTemp As Company
        Dim companyName As String = txtName.Text
        While FS.Position < FS.Length
            'do a direct cast into the base class.
            CompaniesTemp = DirectCast(BF.Deserialize(FS), Company)
            'do a downcast into the derived class
            Dim ElecTemp As ElectricalEng
            ElecTemp = TryCast(CompaniesTemp, ElectricalEng)
            If Not (ElecTemp Is Nothing) Then
                If String.Equals(companyName, ElecTemp.Name) Then
                    txtDetails.Text &= ElecTemp.Display()
                End If
            End If

            Dim MechTemp As MechanicalEng
            MechTemp = TryCast(CompaniesTemp, MechanicalEng)
            If Not (MechTemp Is Nothing) Then
                If String.Equals(companyName, MechTemp.Name) Then
                    txtDetails.Text &= MechTemp.Display()
                End If
            End If

            Dim CivilTemp As CivilEng
            CivilTemp = TryCast(CompaniesTemp, CivilEng)
            If Not (CivilTemp Is Nothing) Then
                If String.Equals(companyName, CivilTemp.Name) Then
                    txtDetails.Text &= CivilTemp.Display()
                End If
            End If

            Dim CompTemp As ComputerEng
            CompTemp = TryCast(CompaniesTemp, ComputerEng)
            If Not (CompTemp Is Nothing) Then
                If String.Equals(companyName, CompTemp.Name) Then
                    txtDetails.Text &= CompTemp.Display()
                End If
            End If
        End While

        txtName.Clear()
        'close the file
        FS.Close()
    End Sub
End Class
