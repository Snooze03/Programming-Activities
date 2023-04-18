<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TXTBX_A = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTBX_B = New System.Windows.Forms.TextBox()
        Me.BTN_Ok = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_Result = New System.Windows.Forms.Label()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTBX_A
        '
        Me.TXTBX_A.Location = New System.Drawing.Point(110, 38)
        Me.TXTBX_A.Name = "TXTBX_A"
        Me.TXTBX_A.Size = New System.Drawing.Size(100, 22)
        Me.TXTBX_A.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "B:"
        '
        'TXTBX_B
        '
        Me.TXTBX_B.Location = New System.Drawing.Point(110, 75)
        Me.TXTBX_B.Name = "TXTBX_B"
        Me.TXTBX_B.Size = New System.Drawing.Size(100, 22)
        Me.TXTBX_B.TabIndex = 2
        '
        'BTN_Ok
        '
        Me.BTN_Ok.Location = New System.Drawing.Point(79, 114)
        Me.BTN_Ok.Name = "BTN_Ok"
        Me.BTN_Ok.Size = New System.Drawing.Size(54, 23)
        Me.BTN_Ok.TabIndex = 4
        Me.BTN_Ok.Text = "OK"
        Me.BTN_Ok.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result:"
        '
        'LBL_Result
        '
        Me.LBL_Result.AutoSize = True
        Me.LBL_Result.Location = New System.Drawing.Point(139, 153)
        Me.LBL_Result.Name = "LBL_Result"
        Me.LBL_Result.Size = New System.Drawing.Size(48, 16)
        Me.LBL_Result.TabIndex = 6
        Me.LBL_Result.Text = "Result:"
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(148, 114)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(74, 23)
        Me.BTN_Clear.TabIndex = 7
        Me.BTN_Clear.Text = "CLEAR"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 236)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.LBL_Result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_Ok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTBX_B)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTBX_A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTBX_A As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTBX_B As TextBox
    Friend WithEvents BTN_Ok As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_Result As Label
    Friend WithEvents BTN_Clear As Button
End Class
