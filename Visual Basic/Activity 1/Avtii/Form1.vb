Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Result.Text = " "
    End Sub

    Private Sub BTN_Ok_Click(sender As Object, e As EventArgs) Handles BTN_Ok.Click
        Dim intA, intB As Int64
        intA = Integer.Parse(TXTBX_A.Text)
        intB = Integer.Parse(TXTBX_B.Text)

        If (intA > intB) Then
            LBL_Result.Text = intA & " > " & intB
        ElseIf (intB > intA) Then
            LBL_Result.Text = intB & " < " & intA
        Else
            LBL_Result.Text = intA & " = " & intB
        End If
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        TXTBX_A.Text = " "
        TXTBX_B.Text = " "
        LBL_Result.Text = " "
    End Sub

End Class
