﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Label2 = New Label()
        btnDivision = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number:"
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(111, 17)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 1
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(111, 46)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number:"
        ' 
        ' btnDivision
        ' 
        btnDivision.Location = New Point(123, 79)
        btnDivision.Name = "btnDivision"
        btnDivision.Size = New Size(75, 23)
        btnDivision.TabIndex = 4
        btnDivision.Text = "Divide"
        btnDivision.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(135, 111)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(54, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Quotient"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 261)
        Controls.Add(lblResult)
        Controls.Add(btnDivision)
        Controls.Add(Label2)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDivision As Button
    Friend WithEvents lblResult As Label
End Class
