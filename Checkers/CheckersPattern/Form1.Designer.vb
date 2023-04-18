<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        TXTBX_Size = New TextBox()
        BTN_OK = New Button()
        LSTBX_Pattern = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 21)
        Label1.TabIndex = 0
        Label1.Text = "Size:"' 
        ' TXTBX_Size
        ' 
        TXTBX_Size.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TXTBX_Size.Location = New Point(59, 9)
        TXTBX_Size.Name = "TXTBX_Size"
        TXTBX_Size.Size = New Size(111, 29)
        TXTBX_Size.TabIndex = 1
        ' 
        ' BTN_OK
        ' 
        BTN_OK.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_OK.Location = New Point(186, 9)
        BTN_OK.Name = "BTN_OK"
        BTN_OK.Size = New Size(55, 29)
        BTN_OK.TabIndex = 2
        BTN_OK.Text = "OK"
        BTN_OK.UseVisualStyleBackColor = True
        ' 
        ' LSTBX_Pattern
        ' 
        LSTBX_Pattern.Font = New Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        LSTBX_Pattern.FormattingEnabled = True
        LSTBX_Pattern.HorizontalScrollbar = True
        LSTBX_Pattern.ItemHeight = 16
        LSTBX_Pattern.Location = New Point(12, 50)
        LSTBX_Pattern.Name = "LSTBX_Pattern"
        LSTBX_Pattern.Size = New Size(1199, 628)
        LSTBX_Pattern.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1223, 689)
        Controls.Add(LSTBX_Pattern)
        Controls.Add(BTN_OK)
        Controls.Add(TXTBX_Size)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTBX_Size As TextBox
    Friend WithEvents BTN_OK As Button
    Friend WithEvents LSTBX_Pattern As ListBox
End Class
