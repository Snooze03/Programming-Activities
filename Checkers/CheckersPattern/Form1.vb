Public Class Form1
    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        LSTBX_Pattern.Items.Clear()

        Dim pattern As String
        Dim cellSize, gridSize, cellSizeInGrid, row, col As Integer

        cellSize = Integer.Parse(TXTBX_Size.Text)
        gridSize = cellSize * (cellSize - 1)
        cellSizeInGrid = (gridSize + 1) / cellSize

        For row = 0 To gridSize
            For col = 0 To gridSize
                '  --------- Full Board ---------
                ' If isBorder(row, col, gridSize) OrElse isCellBorder(row, col, cellSizeInGrid, cellSize) _
                ' OrElse isFilled(row, col, cellSizeInGrid) Then
                ' pattern = pattern & "* "

                ' --------- Full Board no SHADING ---------
                ' If isCellBorder(row, col, cellSizeInGrid, cellSize) Then
                ' pattern = pattern & "* "

                ' --------- Shaded only ---------
                ' If isFilled(row, col, cellSizeInGrid) Then
                ' pattern = pattern & "* "

                ' ---------- Border ONLY ---------
                ' If isBorder(row, col, gridSize) Then
                ' pattern = pattern & "* "
                ' Else

                If isCellBorder(row, col, cellSizeInGrid, cellSize) Then
                    pattern = pattern & "* "
                Else
                    pattern = pattern & "  "
                End If
            Next
            LSTBX_Pattern.Items.Add(pattern)
            pattern = ""
        Next

    End Sub

    Private Shared Function isBorder(ByVal row As Integer, ByVal col As Integer, ByVal gridSize As Integer) As Boolean
        Return row = 0 OrElse col = 0 OrElse row = gridSize OrElse col = gridSize
    End Function

    Private Shared Function isCellBorder(ByVal row As Integer, ByVal col As Integer, ByVal cellSizeInGrid As Integer, ByVal cellSize As Integer) As Boolean
        Return row Mod cellSizeInGrid = cellSizeInGrid - (cellSize - 1) _
            OrElse col Mod cellSizeInGrid = cellSizeInGrid - (cellSize - 1)
    End Function

    Private Shared Function isFilled(ByVal row As Integer, ByVal col As Integer, ByVal cellSizeInGrid As Integer) As Boolean
        Return ((row \ cellSizeInGrid) + (col \ cellSizeInGrid)) Mod 2 = 0
    End Function
End Class
