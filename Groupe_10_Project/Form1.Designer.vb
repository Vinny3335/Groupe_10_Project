<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroup10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCompanyDetails = New System.Windows.Forms.Button()
        Me.btnCompDetails = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCompanies = New System.Windows.Forms.TextBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSaveToFile = New System.Windows.Forms.Button()
        Me.lblGetCompanyInfo = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCompanyDetails
        '
        Me.btnCompanyDetails.Location = New System.Drawing.Point(12, 76)
        Me.btnCompanyDetails.Name = "btnCompanyDetails"
        Me.btnCompanyDetails.Size = New System.Drawing.Size(199, 62)
        Me.btnCompanyDetails.TabIndex = 0
        Me.btnCompanyDetails.Text = "Get the company's details and the Jobs details"
        Me.btnCompanyDetails.UseVisualStyleBackColor = True
        '
        'btnCompDetails
        '
        Me.btnCompDetails.Location = New System.Drawing.Point(14, 329)
        Me.btnCompDetails.Name = "btnCompDetails"
        Me.btnCompDetails.Size = New System.Drawing.Size(194, 55)
        Me.btnCompDetails.TabIndex = 1
        Me.btnCompDetails.Text = "Get the company details"
        Me.btnCompDetails.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(14, 291)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 20)
        Me.txtName.TabIndex = 2
        '
        'txtCompanies
        '
        Me.txtCompanies.Location = New System.Drawing.Point(238, 38)
        Me.txtCompanies.Multiline = True
        Me.txtCompanies.Name = "txtCompanies"
        Me.txtCompanies.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCompanies.Size = New System.Drawing.Size(206, 346)
        Me.txtCompanies.TabIndex = 3
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(485, 38)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDetails.Size = New System.Drawing.Size(263, 346)
        Me.txtDetails.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 275)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(200, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Enter the company's Name. As on the list"
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.Location = New System.Drawing.Point(12, 154)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Size = New System.Drawing.Size(197, 38)
        Me.btnSaveToFile.TabIndex = 6
        Me.btnSaveToFile.Text = "Save All the informations to file"
        Me.btnSaveToFile.UseVisualStyleBackColor = True
        '
        'lblGetCompanyInfo
        '
        Me.lblGetCompanyInfo.AutoSize = True
        Me.lblGetCompanyInfo.Location = New System.Drawing.Point(26, 38)
        Me.lblGetCompanyInfo.Name = "lblGetCompanyInfo"
        Me.lblGetCompanyInfo.Size = New System.Drawing.Size(181, 13)
        Me.lblGetCompanyInfo.TabIndex = 7
        Me.lblGetCompanyInfo.Text = "Only for company to complete, below"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(26, 238)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(158, 13)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "Only for user to complete, below"
        '
        'frmGroup10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 414)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblGetCompanyInfo)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtCompanies)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCompDetails)
        Me.Controls.Add(Me.btnCompanyDetails)
        Me.Name = "frmGroup10"
        Me.Text = "Find a company's details about jobs positions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCompanyDetails As Button
    Friend WithEvents btnCompDetails As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCompanies As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnSaveToFile As Button
    Friend WithEvents lblGetCompanyInfo As Label
    Friend WithEvents lblUser As Label
End Class
