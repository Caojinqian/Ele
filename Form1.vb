Public Class Form1
    Dim xlApp As Microsoft.Office.Interop.Excel.Application '定义工作表类
    Dim xlBook As Microsoft.Office.Interop.Excel.Workbook  '定义工件簿类  
    Dim xlsheet As Microsoft.Office.Interop.Excel.Worksheet '定义工作表类  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 生成IO符号表.Click
        Dim name_of_sheet_IO = IOSheet.Text
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        ' xlApp.Workbooks.Open("c:\MyDate.xls")
        Dim P = Application.StartupPath & "\输入输出表.xlsx"
        Dim txt = Application.StartupPath & "\IOSymbol.txt"

        xlApp.Caption = "欢迎,使用!"
        Dim xlBook = xlApp.Workbooks.Open(P) '打开电机数据表
        Dim xlsheet = xlBook.Worksheets(name_of_sheet_IO)   '打开输入输出数据表子表name_of_sheet_IO
        xlApp.Visible = True
        ' On Error GoTo 70
        Dim M_NO
        Dim M_OFFSET As String
        Dim Original_M
        Dim LINE_NO    '定义数据表的行号

        Dim Original_Offset As String
        Dim QS As String
        Dim QSB As String
        Dim QF As String
        Dim SB_FW As String
        Dim SB_BW As String
        Dim SB_Stop As String
        Dim F_Running As String
        Dim B_Running As String
        Dim Fault As String
        Dim BQ1 As String
        Dim BQ2 As String
        Dim BQ3 As String
        Dim BQ4 As String
        Dim BQ5 As String
        Dim SQ1 As String
        Dim SQ2 As String
        Dim SQ3 As String
        Dim SQ4 As String
        Dim SA1 As String
        Dim SA2 As String
        Dim SA3 As String
        Dim SA4 As String
        Dim BQ6 As String
        Dim BQ7 As String
        Dim BQ8 As String
        Dim BQ9 As String
        Dim SQ5 As String
        Dim SQ6 As String
        Dim SQ7 As String
        Dim SQ8 As String
        Dim SA1B As String
        Dim SB1B As String
        Dim FW As String
        Dim BW As String
        Dim Brake As String
        Dim HL1 As String
        Dim HL2 As String
        Dim HL3 As String
        Dim YV1 As String
        Dim YV2 As String
        Dim YV3 As String
        Dim YV4 As String
        'Dim HA1 As String
        Dim Reset As String
        Dim Run As String
        Dim Reserve3 As String
        Dim Reserve4 As String
        Dim Reserve5 As String
        Dim Reserve6 As String
        Dim M_SR As String
        Dim M_SR1 As String

        FileOpen(1, txt, OpenMode.Output)
        LINE_NO = 3
20:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then
            LINE_NO = LINE_NO + 1
            GoTo 20

        ElseIf M_NO.ToString = "end" Or M_NO <= "0" Then
            GoTo 170
        Else
            M_OFFSET = xlsheet.Cells(LINE_NO, 2).Value
            Original_M = xlsheet.Cells(LINE_NO, 3).Value
            Original_Offset = xlsheet.Cells(LINE_NO, 4).Value
            QS = xlsheet.Cells(LINE_NO, 5).Value
            QSB = xlsheet.Cells(LINE_NO, 6).Value
            QF = xlsheet.Cells(LINE_NO, 7).Value
            SB_FW = xlsheet.Cells(LINE_NO, 8).Value
            SB_BW = xlsheet.Cells(LINE_NO, 9).Value
            SB_Stop = xlsheet.Cells(LINE_NO, 10).Value
            F_Running = xlsheet.Cells(LINE_NO, 11).Value
            B_Running = xlsheet.Cells(LINE_NO, 12).Value
            Fault = xlsheet.Cells(LINE_NO, 13).Value
            BQ1 = xlsheet.Cells(LINE_NO, 14).Value
            BQ2 = xlsheet.Cells(LINE_NO, 15).Value
            BQ3 = xlsheet.Cells(LINE_NO, 16).Value
            BQ4 = xlsheet.Cells(LINE_NO, 17).Value
            BQ5 = xlsheet.Cells(LINE_NO, 18).Value
            SQ1 = xlsheet.Cells(LINE_NO, 19).Value
            SQ2 = xlsheet.Cells(LINE_NO, 20).Value
            SQ3 = xlsheet.Cells(LINE_NO, 21).Value
            SQ4 = xlsheet.Cells(LINE_NO, 22).Value
            SA1 = xlsheet.Cells(LINE_NO, 23).Value
            SA2 = xlsheet.Cells(LINE_NO, 24).Value
            SA3 = xlsheet.Cells(LINE_NO, 25).Value
            SA4 = xlsheet.Cells(LINE_NO, 26).Value
            BQ6 = xlsheet.Cells(LINE_NO, 27).Value
            BQ7 = xlsheet.Cells(LINE_NO, 28).Value
            BQ8 = xlsheet.Cells(LINE_NO, 29).Value
            BQ9 = xlsheet.Cells(LINE_NO, 30).Value
            SQ5 = xlsheet.Cells(LINE_NO, 31).Value
            SQ6 = xlsheet.Cells(LINE_NO, 32).Value
            SQ7 = xlsheet.Cells(LINE_NO, 33).Value
            SQ8 = xlsheet.Cells(LINE_NO, 34).Value
            SA1B = xlsheet.Cells(LINE_NO, 35).Value
            SB1B = xlsheet.Cells(LINE_NO, 36).Value
            FW = xlsheet.Cells(LINE_NO, 37).Value
            BW = xlsheet.Cells(LINE_NO, 38).Value
            Brake = xlsheet.Cells(LINE_NO, 39).Value
            HL1 = xlsheet.Cells(LINE_NO, 40).Value
            HL2 = xlsheet.Cells(LINE_NO, 41).Value
            HL3 = xlsheet.Cells(LINE_NO, 42).Value
            YV1 = xlsheet.Cells(LINE_NO, 43).Value
            YV2 = xlsheet.Cells(LINE_NO, 44).Value
            YV3 = xlsheet.Cells(LINE_NO, 45).Value
            YV4 = xlsheet.Cells(LINE_NO, 46).Value
            Reset = xlsheet.Cells(LINE_NO, 47).Value
            Run = xlsheet.Cells(LINE_NO, 48).Value
            Reserve3 = xlsheet.Cells(LINE_NO, 49).Value
            Reserve4 = xlsheet.Cells(LINE_NO, 50).Value
            Reserve5 = xlsheet.Cells(LINE_NO, 51).Value
            Reserve6 = xlsheet.Cells(LINE_NO, 52).Value

            M_SR = M_NO
            M_SR1 = Original_M

            If M_NO <> Nothing And Original_M = Nothing Then

                If QS <> Nothing Then
                    If Microsoft.VisualBasic.Left(QS, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QS, 1).ToString <> "i" Then
                        PrintLine(1, "QS" + M_SR + Chr(9) + QS + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QS" + M_SR + Chr(9) + Chr(37) + QS + Chr(9) + " BOOL")
                    End If
                End If
                If QSB <> Nothing Then
                    If Microsoft.VisualBasic.Left(QSB, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QSB, 1).ToString <> "i" Then
                        PrintLine(1, "QSB" + M_SR + Chr(9) + QSB + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QSB" + M_SR + Chr(9) + Chr(37) + QSB + Chr(9) + " BOOL")
                    End If
                End If
                If QF <> Nothing Then
                    If Microsoft.VisualBasic.Left(QF, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QF, 1).ToString <> "i" Then
                        PrintLine(1, "QF" + M_SR + Chr(9) + QF + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QF" + M_SR + Chr(9) + Chr(37) + QF + Chr(9) + " BOOL")
                    End If
                End If
                If SB_FW <> Nothing Then 'SB_FW
                    If Microsoft.VisualBasic.Left(SB_FW, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_FW, 1).ToString <> "i" Then
                        PrintLine(1, "SB" + M_SR + "_FW" + Chr(9) + QS + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB" + M_SR + "_FW" + Chr(9) + Chr(37) + QS + Chr(9) + " BOOL")
                    End If
                End If
                If SB_BW <> Nothing Then 'SB_BW
                    If Microsoft.VisualBasic.Left(SB_BW, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_BW, 1).ToString <> "i" Then
                        PrintLine(1, "SB" + M_SR + "_BW" + Chr(9) + SB_BW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB" + M_SR + "_BW" + Chr(9) + Chr(37) + SB_BW + Chr(9) + " BOOL")
                    End If
                End If
                If SB_Stop <> Nothing Then 'SB_Stop
                    If Microsoft.VisualBasic.Left(SB_Stop, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_Stop, 1).ToString <> "i" Then
                        PrintLine(1, "SB_Stop" + M_SR + Chr(9) + SB_Stop + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB_Stop" + M_SR + Chr(9) + Chr(37) + SB_Stop + Chr(9) + " BOOL")
                    End If
                End If
                If F_Running <> Nothing Then
                    If ((B_Running <> Nothing And (B_Running = F_Running)) Or B_Running = Nothing) Then
                        If Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "i" Then
                            PrintLine(1, M_SR + "_Running" + Chr(9) + F_Running + Chr(9) + " BOOL")
                        Else
                            PrintLine(1, M_SR + "_Running" + Chr(9) + Chr(37) + F_Running + Chr(9) + " BOOL")
                        End If
                    Else
                        If Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "i" Then
                            PrintLine(1, M_SR + "_FRunning" + Chr(9) + F_Running + Chr(9) + " BOOL")
                        Else
                            PrintLine(1, M_SR + "_FRunning" + Chr(9) + Chr(37) + F_Running + Chr(9) + " BOOL")
                        End If
                    End If
                End If
                If B_Running <> Nothing And B_Running <> F_Running Then
                    If Microsoft.VisualBasic.Left(B_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(B_Running, 1).ToString <> "i" Then
                        PrintLine(1, M_SR + "_BRunning" + Chr(9) + B_Running + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_BRunning" + Chr(9) + Chr(37) + B_Running + Chr(9) + " BOOL")
                    End If
                End If
                If Fault <> Nothing Then
                    If Microsoft.VisualBasic.Left(Fault, 1).ToString <> "I" And Microsoft.VisualBasic.Left(Fault, 1).ToString <> "i" Then
                        PrintLine(1, M_SR + "_Fault" + Chr(9) + Fault + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Fault" + Chr(9) + Chr(37) + Fault + Chr(9) + " BOOL")
                    End If
                End If
                If BQ1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ1, 1).ToString <> "i" Then
                        PrintLine(1, "BQ1A" + M_SR + Chr(9) + BQ1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ1A" + M_SR + Chr(9) + Chr(37) + BQ1 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ2, 1).ToString <> "i" Then
                        PrintLine(1, "BQ2A" + M_SR + Chr(9) + BQ2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ2A" + M_SR + Chr(9) + Chr(37) + BQ2 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ3, 1).ToString <> "i" Then
                        PrintLine(1, "BQ3A" + M_SR + Chr(9) + BQ3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ3A" + M_SR + Chr(9) + Chr(37) + BQ3 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ4, 1).ToString <> "i" Then
                        PrintLine(1, "BQ4A" + M_SR + Chr(9) + BQ4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ4A" + M_SR + Chr(9) + Chr(37) + BQ4 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ5, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ5, 1).ToString <> "i" Then
                        PrintLine(1, "BQ5A" + M_SR + Chr(9) + BQ5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ5A" + M_SR + Chr(9) + Chr(37) + BQ5 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ1, 1).ToString <> "i" Then
                        PrintLine(1, "SQ1A" + M_SR + Chr(9) + SQ1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ1A" + M_SR + Chr(9) + Chr(37) + SQ1 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ2, 1).ToString <> "i" Then
                        PrintLine(1, "SQ2A" + M_SR + Chr(9) + SQ2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ2A" + M_SR + Chr(9) + Chr(37) + SQ2 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ3, 1).ToString <> "i" Then
                        PrintLine(1, "SQ3A" + M_SR + Chr(9) + SQ3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ3A" + M_SR + Chr(9) + Chr(37) + SQ3 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ4, 1).ToString <> "i" Then
                        PrintLine(1, "SQ4A" + M_SR + Chr(9) + SQ4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ4A" + M_SR + Chr(9) + Chr(37) + SQ4 + Chr(9) + " BOOL")
                    End If
                End If
                If SA1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA1, 1).ToString <> "i" Then
                        PrintLine(1, "SA1A" + M_SR + Chr(9) + SA1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA1A" + M_SR + Chr(9) + Chr(37) + SA1 + Chr(9) + " BOOL")
                    End If
                End If
                If SA2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA2, 1).ToString <> "i" Then
                        PrintLine(1, "SA2A" + M_SR + Chr(9) + SA2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA2A" + M_SR + Chr(9) + Chr(37) + SA2 + Chr(9) + " BOOL")
                    End If
                End If
                If SA3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA3, 1).ToString <> "i" Then
                        PrintLine(1, "SA3A" + M_SR + Chr(9) + SA3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA3A" + M_SR + Chr(9) + Chr(37) + SA3 + Chr(9) + " BOOL")
                    End If
                End If
                If SA4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA4, 1).ToString <> "i" Then
                        PrintLine(1, "SA4A" + M_SR + Chr(9) + SA4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA4A" + M_SR + Chr(9) + Chr(37) + SA4 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ6 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ6, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ6, 1).ToString <> "i" Then
                        PrintLine(1, "BQ6A" + M_SR + Chr(9) + BQ6 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ6A" + M_SR + Chr(9) + Chr(37) + BQ6 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ7 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ7, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ7, 1).ToString <> "i" Then
                        PrintLine(1, "BQ7A" + M_SR + Chr(9) + BQ7 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ7A" + M_SR + Chr(9) + Chr(37) + BQ7 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ8 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ8, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ8, 1).ToString <> "i" Then
                        PrintLine(1, "BQ8A" + M_SR + Chr(9) + BQ8 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ8A" + M_SR + Chr(9) + Chr(37) + BQ8 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ9 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ9, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ9, 1).ToString <> "i" Then
                        PrintLine(1, "BQ9A" + M_SR + Chr(9) + BQ9 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ9A" + M_SR + Chr(9) + Chr(37) + BQ9 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ5, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ5, 1).ToString <> "i" Then
                        PrintLine(1, "SQ5A" + M_SR + Chr(9) + SQ5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ5A" + M_SR + Chr(9) + Chr(37) + SQ5 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ6 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ6, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ6, 1).ToString <> "i" Then
                        PrintLine(1, "SQ6A" + M_SR + Chr(9) + SQ6 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ6A" + M_SR + Chr(9) + Chr(37) + SQ6 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ7 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ7, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ7, 1).ToString <> "i" Then
                        PrintLine(1, "SQ7A" + M_SR + Chr(9) + SQ7 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ7A" + M_SR + Chr(9) + Chr(37) + SQ7 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ8 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ8, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ8, 1).ToString <> "i" Then
                        PrintLine(1, "SQ8A" + M_SR + Chr(9) + SQ8 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ8A" + M_SR + Chr(9) + Chr(37) + SQ8 + Chr(9) + " BOOL")
                    End If
                End If
                If SA1B <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA1B, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA1B, 1).ToString <> "i" Then
                        PrintLine(1, "SA1B" + M_SR + Chr(9) + SA1B + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA1B" + M_SR + Chr(9) + Chr(37) + SA1B + Chr(9) + " BOOL")
                    End If
                End If
                If SB1B <> Nothing Then
                    If Microsoft.VisualBasic.Left(SB1B, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB1B, 1).ToString <> "i" Then
                        PrintLine(1, "SB1B" + M_SR + Chr(9) + SB1B + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB1B" + M_SR + Chr(9) + Chr(37) + SB1B + Chr(9) + " BOOL")
                    End If
                End If

                ''''///////*****输出****//////

                If FW <> Nothing Then
                    If Microsoft.VisualBasic.Left(FW, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(FW, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_FW" + Chr(9) + FW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_FW" + Chr(9) + Chr(37) + FW + Chr(9) + " BOOL")
                    End If
                End If
                If BW <> Nothing Then
                    If Microsoft.VisualBasic.Left(BW, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(BW, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_BW" + Chr(9) + BW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_BW" + Chr(9) + Chr(37) + BW + Chr(9) + " BOOL")
                    End If
                End If
                If Brake <> Nothing Then
                    If Microsoft.VisualBasic.Left(Brake, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Brake, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Brake" + Chr(9) + Brake + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Brake" + Chr(9) + Chr(37) + Brake + Chr(9) + " BOOL")
                    End If
                End If
                If HL1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL1, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL1, 1).ToString <> "q" Then
                        PrintLine(1, "HL1A" + M_SR + Chr(9) + HL1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "HL1A" + M_SR + Chr(9) + Chr(37) + HL1 + Chr(9) + " BOOL")
                    End If
                End If
                If HL2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL2, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL2, 1).ToString <> "q" Then
                        PrintLine(1, "HL2A" + M_SR + Chr(9) + HL2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "HL2A" + M_SR + Chr(9) + Chr(37) + HL2 + Chr(9) + " BOOL")
                    End If
                End If
                If HL3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL3, 1).ToString <> "q" Then
                        PrintLine(1, "HL3A" + M_SR + Chr(9) + HL3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "HL3A" + M_SR + Chr(9) + Chr(37) + HL3 + Chr(9) + " BOOL")
                    End If
                End If
                If YV1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV1, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV1, 1).ToString <> "q" Then
                        PrintLine(1, "YV1A" + M_SR + Chr(9) + YV1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV1A" + M_SR + Chr(9) + Chr(37) + YV1 + Chr(9) + " BOOL")
                    End If
                End If
                If YV2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV2, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV2, 1).ToString <> "q" Then
                        PrintLine(1, "YV2A" + M_SR + Chr(9) + YV2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV2A" + M_SR + Chr(9) + Chr(37) + YV2 + Chr(9) + " BOOL")
                    End If
                End If
                If YV3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV3, 1).ToString <> "q" Then
                        PrintLine(1, "YV3A" + M_SR + Chr(9) + YV3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV3A" + M_SR + Chr(9) + Chr(37) + YV3 + Chr(9) + " BOOL")
                    End If
                End If
                If YV4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV4, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV4, 1).ToString <> "q" Then
                        PrintLine(1, "YV4A" + M_SR + Chr(9) + YV4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV4A" + M_SR + Chr(9) + Chr(37) + YV4 + Chr(9) + " BOOL")
                    End If
                End If
                If Reset <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reset, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reset, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Reset" + Chr(9) + Reset + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Reset" + Chr(9) + Chr(37) + Reset + Chr(9) + " BOOL")
                    End If
                End If
                If Run <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reset, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reset, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Run" + Chr(9) + Run + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Run" + Chr(9) + Chr(37) + Run + Chr(9) + " BOOL")
                    End If
                End If
                If Run <> Nothing Then
                    If Microsoft.VisualBasic.Left(Run, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Run, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Run" + Chr(9) + Run + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Run" + Chr(9) + Chr(37) + Run + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reserve3, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Reserve3" + Chr(9) + Reserve3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Reserve3" + Chr(9) + Chr(37) + Reserve3 + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve4, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reserve4, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Reserve4" + Chr(9) + Reserve4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Reserve4" + Chr(9) + Chr(37) + Reserve4 + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve5, 1).ToString <> "" And Microsoft.VisualBasic.Left(Reserve5, 1).ToString <> "q" Then
                        PrintLine(1, M_SR + "_Reserve5" + Chr(9) + Reserve5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR + "_Reserve5" + Chr(9) + Chr(37) + Reserve5 + Chr(9) + " BOOL")
                    End If
                End If

            ElseIf M_NO <> Nothing And Original_M <> Nothing And Original_M <> M_NO Then
                If QS <> Nothing Then
                    If Microsoft.VisualBasic.Left(QS, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QS, 1).ToString <> "i" Then
                        PrintLine(1, "QS" + M_SR1 + "." + Original_Offset + Chr(9) + QS + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QS" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + QS + Chr(9) + " BOOL")
                    End If
                End If
                If QSB <> Nothing Then
                    If Microsoft.VisualBasic.Left(QSB, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QSB, 1).ToString <> "i" Then
                        PrintLine(1, "QSB" + M_SR1 + "." + Original_Offset + Chr(9) + QSB + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QSB" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + QSB + Chr(9) + " BOOL")
                    End If
                End If
                If QF <> Nothing Then
                    If Microsoft.VisualBasic.Left(QF, 1).ToString <> "I" And Microsoft.VisualBasic.Left(QF, 1).ToString <> "i" Then
                        PrintLine(1, "QF" + M_SR1 + "." + Original_Offset + Chr(9) + QF + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "QF" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + QF + Chr(9) + " BOOL")
                    End If
                End If
                If SB_FW <> Nothing Then 'SB_FW
                    If Microsoft.VisualBasic.Left(SB_FW, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_FW, 1).ToString <> "i" Then
                        PrintLine(1, "SB" + M_SR1 + "." + Original_Offset + "_FW" + Chr(9) + QS + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB" + M_SR1 + "." + Original_Offset + "_FW" + Chr(9) + Chr(37) + QS + Chr(9) + " BOOL")
                    End If
                End If
                If SB_BW <> Nothing Then 'SB_BW
                    If Microsoft.VisualBasic.Left(SB_BW, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_BW, 1).ToString <> "i" Then
                        PrintLine(1, "SB" + M_SR1 + "." + Original_Offset + "_BW" + Chr(9) + SB_BW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB" + M_SR1 + "." + Original_Offset + "_BW" + Chr(9) + Chr(37) + SB_BW + Chr(9) + " BOOL")
                    End If
                End If
                If SB_Stop <> Nothing Then 'SB_Stop
                    If Microsoft.VisualBasic.Left(SB_Stop, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB_Stop, 1).ToString <> "i" Then
                        PrintLine(1, "SB_Stop" + M_SR1 + "." + Original_Offset + Chr(9) + SB_Stop + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB_Stop" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SB_Stop + Chr(9) + " BOOL")
                    End If
                End If
                If F_Running <> Nothing Then
                    If ((B_Running <> Nothing And (B_Running = F_Running)) Or B_Running = Nothing) Then
                        If Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "i" Then
                            PrintLine(1, M_SR1 + "." + Original_Offset + "_Running" + Chr(9) + F_Running + Chr(9) + " BOOL")
                        Else
                            PrintLine(1, M_SR1 + "." + Original_Offset + "_Running" + Chr(9) + Chr(37) + F_Running + Chr(9) + " BOOL")
                        End If
                    Else
                        If Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(F_Running, 1).ToString <> "i" Then
                            PrintLine(1, M_SR1 + "." + Original_Offset + "_FRunning" + Chr(9) + F_Running + Chr(9) + " BOOL")
                        Else
                            PrintLine(1, M_SR1 + "." + Original_Offset + "_FRunning" + Chr(9) + Chr(37) + F_Running + Chr(9) + " BOOL")
                        End If
                    End If
                End If
                If B_Running <> Nothing And B_Running <> F_Running Then
                    If Microsoft.VisualBasic.Left(B_Running, 1).ToString <> "I" And Microsoft.VisualBasic.Left(B_Running, 1).ToString <> "i" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_BRunning" + Chr(9) + B_Running + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_BRunning" + Chr(9) + Chr(37) + B_Running + Chr(9) + " BOOL")
                    End If
                End If
                If Fault <> Nothing Then
                    If Microsoft.VisualBasic.Left(Fault, 1).ToString <> "I" And Microsoft.VisualBasic.Left(Fault, 1).ToString <> "i" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Fault" + Chr(9) + Fault + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "Fault" + M_SR1 + "." + Original_Offset + "_Fault" + Chr(9) + Chr(37) + Fault + Chr(9) + " BOOL")
                    End If
                End If
                If BQ1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ1, 1).ToString <> "i" Then
                        PrintLine(1, "BQ1A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ1A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ1 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ2, 1).ToString <> "i" Then
                        PrintLine(1, "BQ2A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ2A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ2 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ3, 1).ToString <> "i" Then
                        PrintLine(1, "BQ3A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ3A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ3 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ4, 1).ToString <> "i" Then
                        PrintLine(1, "BQ4A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ4A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ4 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ5, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ5, 1).ToString <> "i" Then
                        PrintLine(1, "BQ5A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ5A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ5 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ1, 1).ToString <> "i" Then
                        PrintLine(1, "SQ1A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ1A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ1 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ2, 1).ToString <> "i" Then
                        PrintLine(1, "SQ2A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ2A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ2 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ3, 1).ToString <> "i" Then
                        PrintLine(1, "SQ3A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ3A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ3 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ4, 1).ToString <> "i" Then
                        PrintLine(1, "SQ4A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ4A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ4 + Chr(9) + " BOOL")
                    End If
                End If
                If SA1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA1, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA1, 1).ToString <> "i" Then
                        PrintLine(1, "SA1A" + M_SR1 + "." + Original_Offset + Chr(9) + SA1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA1A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SA1 + Chr(9) + " BOOL")
                    End If
                End If
                If SA2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA2, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA2, 1).ToString <> "i" Then
                        PrintLine(1, "SA2A" + M_SR1 + "." + Original_Offset + Chr(9) + SA2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA2A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SA2 + Chr(9) + " BOOL")
                    End If
                End If
                If SA3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA3, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA3, 1).ToString <> "i" Then
                        PrintLine(1, "SA3A" + M_SR1 + "." + Original_Offset + Chr(9) + SA3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA3A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SA3 + Chr(9) + " BOOL")
                    End If
                End If
                If SA4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA4, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA4, 1).ToString <> "i" Then
                        PrintLine(1, "SA4A" + M_SR1 + "." + Original_Offset + Chr(9) + SA4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA4A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SA4 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ6 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ6, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ6, 1).ToString <> "i" Then
                        PrintLine(1, "BQ6A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ6 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ6A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ6 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ7 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ7, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ7, 1).ToString <> "i" Then
                        PrintLine(1, "BQ7A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ7 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ7A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ7 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ8 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ8, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ8, 1).ToString <> "i" Then
                        PrintLine(1, "BQ8A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ8 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ8A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ8 + Chr(9) + " BOOL")
                    End If
                End If
                If BQ9 <> Nothing Then
                    If Microsoft.VisualBasic.Left(BQ9, 1).ToString <> "I" And Microsoft.VisualBasic.Left(BQ9, 1).ToString <> "i" Then
                        PrintLine(1, "BQ9A" + M_SR1 + "." + Original_Offset + Chr(9) + BQ9 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "BQ9A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + BQ9 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ5, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ5, 1).ToString <> "i" Then
                        PrintLine(1, "SQ5A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ5A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ5 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ6 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ6, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ6, 1).ToString <> "i" Then
                        PrintLine(1, "SQ6A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ6 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ6A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ6 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ7 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ7, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ7, 1).ToString <> "i" Then
                        PrintLine(1, "SQ7A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ7 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ7A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ7 + Chr(9) + " BOOL")
                    End If
                End If
                If SQ8 <> Nothing Then
                    If Microsoft.VisualBasic.Left(SQ8, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SQ8, 1).ToString <> "i" Then
                        PrintLine(1, "SQ8A" + M_SR1 + "." + Original_Offset + Chr(9) + SQ8 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SQ8A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SQ8 + Chr(9) + " BOOL")
                    End If
                End If
                If SA1B <> Nothing Then
                    If Microsoft.VisualBasic.Left(SA1B, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SA1B, 1).ToString <> "i" Then
                        PrintLine(1, "SA1B" + M_SR1 + "." + Original_Offset + Chr(9) + SA1B + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SA1B" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SA1B + Chr(9) + " BOOL")
                    End If
                End If
                If SB1B <> Nothing Then
                    If Microsoft.VisualBasic.Left(SB1B, 1).ToString <> "I" And Microsoft.VisualBasic.Left(SB1B, 1).ToString <> "i" Then
                        PrintLine(1, "SB1B" + M_SR1 + "." + Original_Offset + Chr(9) + SB1B + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "SB1B" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + SB1B + Chr(9) + " BOOL")
                    End If
                End If

                ''''///////*****输出****//////

                If FW <> Nothing Then
                    If Microsoft.VisualBasic.Left(FW, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(FW, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_FW" + Chr(9) + FW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_FW" + Chr(9) + Chr(37) + FW + Chr(9) + " BOOL")
                    End If
                End If
                If BW <> Nothing Then
                    If Microsoft.VisualBasic.Left(BW, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(BW, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_BW" + Chr(9) + BW + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_BW" + Chr(9) + Chr(37) + BW + Chr(9) + " BOOL")
                    End If
                End If
                If Brake <> Nothing Then
                    If Microsoft.VisualBasic.Left(Brake, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Brake, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Brake" + Chr(9) + Brake + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Brake" + Chr(9) + Chr(37) + Brake + Chr(9) + " BOOL")
                    End If
                End If
                If HL1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL1, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL1, 1).ToString <> "q" Then
                        PrintLine(1, "HL1A" + M_SR1 + "." + Original_Offset + Chr(9) + HL1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "HL1A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + HL1 + Chr(9) + " BOOL")
                    End If
                End If
                If HL2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL2, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL2, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "HL2A" + Chr(9) + HL2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "HL2A" + Chr(9) + Chr(37) + HL2 + Chr(9) + " BOOL")
                    End If
                End If
                If HL3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(HL3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(HL3, 1).ToString <> "q" Then
                        PrintLine(1, "HL3A" + M_SR1 + "." + Original_Offset + Chr(9) + HL3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "HL3A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + HL3 + Chr(9) + " BOOL")
                    End If
                End If
                If YV1 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV1, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV1, 1).ToString <> "q" Then
                        PrintLine(1, "YV1A" + M_SR1 + "." + Original_Offset + Chr(9) + YV1 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV1A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + YV1 + Chr(9) + " BOOL")
                    End If
                End If
                If YV2 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV2, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV2, 1).ToString <> "q" Then
                        PrintLine(1, "YV2A" + M_SR1 + "." + Original_Offset + Chr(9) + YV2 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV2A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + YV2 + Chr(9) + " BOOL")
                    End If
                End If
                If YV3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV3, 1).ToString <> "q" Then
                        PrintLine(1, "YV3A" + M_SR1 + "." + Original_Offset + Chr(9) + YV3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV3A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + YV3 + Chr(9) + " BOOL")
                    End If
                End If
                If YV4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(YV4, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(YV4, 1).ToString <> "q" Then
                        PrintLine(1, "YV4A" + M_SR1 + "." + Original_Offset + Chr(9) + YV4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, "YV4A" + M_SR1 + "." + Original_Offset + Chr(9) + Chr(37) + YV4 + Chr(9) + " BOOL")
                    End If
                End If

                If Reset <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reset, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reset, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reset" + Chr(9) + Reset + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "Reset" + Chr(9) + Chr(37) + Reset + Chr(9) + " BOOL")
                    End If
                End If
                If Run <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reset, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Run, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Run" + Chr(9) + Run + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Run" + Chr(9) + Chr(37) + Run + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve3 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve3, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reserve3, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve3" + Chr(9) + Reserve3 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve3" + Chr(9) + Chr(37) + Reserve3 + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve4 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve4, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reserve4, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve4" + Chr(9) + Reserve4 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve4" + Chr(9) + Chr(37) + Reserve4 + Chr(9) + " BOOL")
                    End If
                End If
                If Reserve5 <> Nothing Then
                    If Microsoft.VisualBasic.Left(Reserve5, 1).ToString <> "Q" And Microsoft.VisualBasic.Left(Reserve5, 1).ToString <> "q" Then
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve5" + Chr(9) + Reserve5 + Chr(9) + " BOOL")
                    Else
                        PrintLine(1, M_SR1 + "." + Original_Offset + "_Reserve5" + Chr(9) + Chr(37) + Reserve5 + Chr(9) + " BOOL")
                    End If
                End If
            End If

            LINE_NO = LINE_NO + 1
50:         GoTo 20
        End If
170:    xlApp.ActiveWorkbook.Close()
        xlApp.Quit()
        '退出excel程序
        xlsheet = Nothing
        xlBook = Nothing
        xlApp = Nothing

        MsgBox(“IO符号生成完毕”)
        FileClose(1)
        '  Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles 输入映射SCL.Click
        Dim name_of_sheet_IO = IOSheet.Text
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        ' xlApp.Workbooks.Open("c:\MyDate.xls")
        Dim P = Application.StartupPath & "\输入输出表.xlsx"
        Dim txt = Application.StartupPath & "\输入SCL.txt"

        xlApp.Caption = "欢迎,使用!"
        Dim xlBook = xlApp.Workbooks.Open(P) '打开电机数据表
        Dim xlsheet = xlBook.Worksheets(name_of_sheet_IO)   '打开输入输出数据表子表name_of_sheet_IO
        xlApp.Visible = True
        ' On Error GoTo 70
        Dim M_NO
        Dim M_OFFSET As String
        Dim Original_M
        Dim LINE_NO    '定义数据表的行号

        Dim Original_Offset As String
        Dim QS As String
        Dim QSB As String
        Dim QF As String
        Dim SB_FW As String
        Dim SB_BW As String
        Dim SB_Stop As String
        Dim F_Running As String
        Dim B_Running As String
        Dim Fault As String
        Dim BQ1 As String
        Dim BQ2 As String
        Dim BQ3 As String
        Dim BQ4 As String
        Dim BQ5 As String
        Dim SQ1 As String
        Dim SQ2 As String
        Dim SQ3 As String
        Dim SQ4 As String
        Dim SA1 As String
        Dim SA2 As String
        Dim SA3 As String
        Dim SA4 As String
        Dim BQ6 As String
        Dim BQ7 As String
        Dim BQ8 As String
        Dim BQ9 As String
        Dim SQ5 As String
        Dim SQ6 As String
        Dim SQ7 As String
        Dim SQ8 As String
        Dim SA1B As String
        Dim SB1B As String
        Dim M_SR As String
        Dim M_SR1 As String


        FileOpen(1, txt, OpenMode.Output)
        PrintLine(1, " FUNCTION_BLOCK " + Chr(34) + "InputTransfer " + Chr(34))
        PrintLine(1, Chr(123) + "S7_Optimized_Access :=" + Chr(39) + "TRUE" + Chr(39) + Chr(125))
        PrintLine(1, "VERSION : 0.1")

        LINE_NO = 3
20:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = “start” Then
            PrintLine(1, "VAR")
            LINE_NO = LINE_NO + 1
            GoTo 20
        ElseIf M_NO.ToString <= "0" Then
            GoTo 70
        ElseIf M_NO.ToString = "end" Then
            PrintLine(1, "END_VAR")
            PrintLine(1, "BEGIN")
            GoTo 30
        Else
            M_SR = M_NO
            PrintLine(1, "M" + M_SR + Chr(58) + Chr(34) + "#YF#InputTransfer" + Chr(34) + Chr(59))
            LINE_NO = LINE_NO + 1
            GoTo 20
        End If

30:     LINE_NO = 3
40:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then
            LINE_NO = LINE_NO + 1
            GoTo 40

        ElseIf M_NO.ToString = "end" Or M_NO <= "0" Then
            GoTo 70

        Else
            M_OFFSET = xlsheet.Cells(LINE_NO, 2).Value
            Original_M = xlsheet.Cells(LINE_NO, 3).Value
            Original_Offset = xlsheet.Cells(LINE_NO, 4).Value
            QS = xlsheet.Cells(LINE_NO, 5).Value
            QSB = xlsheet.Cells(LINE_NO, 6).Value
            QF = xlsheet.Cells(LINE_NO, 7).Value
            SB_FW = xlsheet.Cells(LINE_NO, 8).Value
            SB_BW = xlsheet.Cells(LINE_NO, 9).Value
            SB_Stop = xlsheet.Cells(LINE_NO, 10).Value
            F_Running = xlsheet.Cells(LINE_NO, 11).Value
            B_Running = xlsheet.Cells(LINE_NO, 12).Value
            Fault = xlsheet.Cells(LINE_NO, 13).Value
            BQ1 = xlsheet.Cells(LINE_NO, 14).Value
            BQ2 = xlsheet.Cells(LINE_NO, 15).Value
            BQ3 = xlsheet.Cells(LINE_NO, 16).Value
            BQ4 = xlsheet.Cells(LINE_NO, 17).Value
            BQ5 = xlsheet.Cells(LINE_NO, 18).Value
            SQ1 = xlsheet.Cells(LINE_NO, 19).Value
            SQ2 = xlsheet.Cells(LINE_NO, 20).Value
            SQ3 = xlsheet.Cells(LINE_NO, 21).Value
            SQ4 = xlsheet.Cells(LINE_NO, 22).Value
            SA1 = xlsheet.Cells(LINE_NO, 23).Value
            SA2 = xlsheet.Cells(LINE_NO, 24).Value
            SA3 = xlsheet.Cells(LINE_NO, 25).Value
            SA4 = xlsheet.Cells(LINE_NO, 26).Value
            BQ6 = xlsheet.Cells(LINE_NO, 27).Value
            BQ7 = xlsheet.Cells(LINE_NO, 28).Value
            BQ8 = xlsheet.Cells(LINE_NO, 29).Value
            BQ9 = xlsheet.Cells(LINE_NO, 30).Value
            SQ5 = xlsheet.Cells(LINE_NO, 31).Value
            SQ6 = xlsheet.Cells(LINE_NO, 32).Value
            SQ7 = xlsheet.Cells(LINE_NO, 33).Value
            SQ8 = xlsheet.Cells(LINE_NO, 34).Value
            SA1B = xlsheet.Cells(LINE_NO, 35).Value
            SB1B = xlsheet.Cells(LINE_NO, 36).Value

            M_SR = M_NO
            M_SR1 = Original_M
            PrintLine(1, "//" + M_SR + "输入信号映射;")
            'Print #1, "//"; M_SR; "输入信号映射;"
            PrintLine(1, Chr(35) + "M" + M_SR + Chr(40))
            PrintLine(1, "M_ID:=" + M_SR + ",")
            Print(1, "M_ID_Offset:=" + M_OFFSET)
            If QS <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(QS, 1).ToString = "I" Or Microsoft.VisualBasic.Left(QS, 1).ToString = "i" Then
                    Print(1, "QS:=" + Chr(37) + QS)
                Else
                    Print(1, "QS :=" + Chr(34) + QS + Chr(34))
                End If
            End If 'QS
            If QSB <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(QSB, 1) <> "I" Or Microsoft.VisualBasic.Left(QSB, 1) <> "i" Then
                    Print(1, "QSB:=" + Chr(37) + QSB)
                Else
                    Print(1, "QSB :=" + Chr(34) + QSB + Chr(34) + ",")
                End If
            End If 'QSB
            If QF <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(QF, 1) <> "I" Or Microsoft.VisualBasic.Left(QF, 1) <> "i" Then
                    Print(1, "QF:=" + Chr(37) + QF)
                Else
                    Print(1, "QF :=" + Chr(34) + QF + Chr(34))
                End If
            End If 'QF
            If SB_FW <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SB_FW, 1) <> "I" Or Microsoft.VisualBasic.Left(SB_FW, 1) <> "i" Then
                    Print(1, "SB_FW:=" + Chr(37) + SB_FW)
                Else
                    Print(1, "SB_FW :=" + Chr(34) + SB_FW + Chr(34))
                End If
            End If 'SB_FW
            If SB_BW <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SB_BW, 1) <> "I" Or Microsoft.VisualBasic.Left(SB_BW, 1) <> "i" Then
                    Print(1, "SB_BW:=" + Chr(37) + SB_BW)
                Else
                    Print(1, "SB_BW :=" + Chr(34) + SB_BW + Chr(34))
                End If
            End If 'SB_BW
            If SB_Stop <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SB_Stop, 1) <> "I" Or Microsoft.VisualBasic.Left(SB_Stop, 1) <> "i" Then
                    Print(1, "SB_Stop:=" + Chr(37) + SB_Stop)
                Else
                    Print(1, "SB_Stop :=" + Chr(34) + SB_Stop + Chr(34))
                End If
            End If 'SB_Stop
            If F_Running <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(F_Running, 1) <> "I" Or Microsoft.VisualBasic.Left(F_Running, 1) <> "i" Then
                    Print(1, "F_Running:=" + Chr(37) + F_Running)
                Else
                    Print(1, "F_Running :=" + Chr(34) + F_Running + Chr(34))
                End If
            End If 'F_Running
            If B_Running <> Nothing Then
                PrintLine(1, ",")
                If B_Running = F_Running Then
                    If Microsoft.VisualBasic.Left(F_Running, 1) <> "I" Or Microsoft.VisualBasic.Left(F_Running, 1) <> "i" Then
                        Print(1, "B_Running:=" + Chr(37) + F_Running)
                    Else
                        Print(1, "B_Running :=" + Chr(34) + F_Running + Chr(34))
                    End If
                Else
                    If Microsoft.VisualBasic.Left(F_Running, 1) <> "I" Or Microsoft.VisualBasic.Left(F_Running, 1) <> "i" Then
                        Print(1, "B_Running:=" + Chr(37) + B_Running)
                    Else
                        Print(1, "B_Running :=" + Chr(34) + B_Running + Chr(34))
                    End If
                End If
            End If 'B_Running
            If Fault <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Fault, 1) <> "I" Or Microsoft.VisualBasic.Left(Fault, 1) <> "i" Then
                    Print(1, "Fault:=" + Chr(37) + Fault)
                Else
                    Print(1, "Fault :=" + Chr(34) + Fault + Chr(34))
                End If
            End If 'Falut
            If BQ1 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ1, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ1, 1) <> "i" Then
                    Print(1, "BQ1:=" + Chr(37) + BQ1)
                Else
                    Print(1, "BQ1 :=" + Chr(34) + BQ1 + Chr(34))
                End If
            End If 'SB_Stop
            If BQ2 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ2, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ2, 1) <> "i" Then
                    Print(1, "BQ2:=" + Chr(37) + BQ2)
                Else
                    Print(1, "BQ2 :=" + Chr(34) + BQ2 + Chr(34))
                End If
            End If 'SB_Stop
            If BQ3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ3, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ3, 1) <> "i" Then
                    Print(1, "BQ3:=" + Chr(37) + BQ3)
                Else
                    Print(1, "BQ3 :=" + Chr(34) + BQ3 + Chr(34))
                End If
            End If 'BQ3
            If BQ4 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ4, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ4, 1) <> "i" Then
                    Print(1, "BQ4:=" + Chr(37) + BQ4)
                Else
                    Print(1, "BQ4 :=" + Chr(34) + BQ4 + Chr(34))
                End If
            End If 'BQ4
            If BQ5 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ5, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ5, 1) <> "i" Then
                    Print(1, "BQ5:=" + Chr(37) + BQ5)
                Else
                    Print(1, "BQ5 :=" + Chr(34) + BQ5 + Chr(34))
                End If
            End If 'BQ5
            If SQ1 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ1, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ1, 1) <> "i" Then
                    Print(1, "SQ1:=" + Chr(37) + SQ1)
                Else
                    Print(1, "SQ1 :=" + Chr(34) + SQ1 + Chr(34))
                End If
            End If 'SQ1
            If SQ2 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ2, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ2, 1) <> "i" Then
                    Print(1, "SQ2:=" + Chr(37) + SQ2)
                Else
                    Print(1, "SQ2 :=" + Chr(34) + SQ2 + Chr(34))
                End If
            End If 'SQ2
            If SQ3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ3, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ3, 1) <> "i" Then
                    Print(1, "SQ3:=" + Chr(37) + SQ3)
                Else
                    Print(1, "SQ3 :=" + Chr(34) + SQ3 + Chr(34))
                End If
            End If 'SQ3
            If SQ4 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ4, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ4, 1) <> "i" Then
                    Print(1, "SQ4:=" + Chr(37) + SQ4)
                Else
                    Print(1, "SQ4 :=" + Chr(34) + SQ4 + Chr(34))
                End If
            End If 'SQ4
            If SA1 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SA1, 1) <> "I" Or Microsoft.VisualBasic.Left(SA1, 1) <> "i" Then
                    Print(1, "SA1:=" + Chr(37) + SA1)
                Else
                    Print(1, "SA1 :=" + Chr(34) + SA1 + Chr(34))
                End If
            End If 'SA1
            If SA2 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SA2, 1) <> "I" Or Microsoft.VisualBasic.Left(SA2, 1) <> "i" Then
                    Print(1, "SA2:=" + Chr(37) + SA2)
                Else
                    Print(1, "SA2 :=" + Chr(34) + SA2 + Chr(34))
                End If
            End If 'SA2
            If SA3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SA3, 1) <> "I" Or Microsoft.VisualBasic.Left(SA3, 1) <> "i" Then
                    Print(1, "SA3:=" + Chr(37) + SA3)
                Else
                    Print(1, "SA3 :=" + Chr(34) + SA3 + Chr(34))
                End If
            End If 'SA3
            If SA4 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SA4, 1) <> "I" Or Microsoft.VisualBasic.Left(SA4, 1) <> "i" Then
                    Print(1, "SA4:=" + Chr(37) + SA4)
                Else
                    Print(1, "SA4 :=" + Chr(34) + SA4 + Chr(34))
                End If
            End If 'SA4
            If BQ6 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ6, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ6, 1) <> "i" Then
                    Print(1, "BQ6:=" + Chr(37) + BQ6)
                Else
                    Print(1, "BQ6 :=" + Chr(34) + BQ6 + Chr(34))
                End If
            End If 'BQ6
            If BQ7 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ7, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ7, 1) <> "i" Then
                    Print(1, "BQ7:=" + Chr(37) + BQ7)
                Else
                    Print(1, "BQ7 :=" + Chr(34) + BQ7 + Chr(34))
                End If
            End If 'BQ7
            If BQ8 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ8, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ8, 1) <> "i" Then
                    Print(1, "BQ8:=" + Chr(37) + BQ8)
                Else
                    Print(1, "BQ8 :=" + Chr(34) + BQ8 + Chr(34))
                End If
            End If 'BQ8
            If BQ9 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BQ9, 1) <> "I" Or Microsoft.VisualBasic.Left(BQ9, 1) <> "i" Then
                    Print(1, "BQ9:=" + Chr(37) + BQ9)
                Else
                    Print(1, "BQ9 :=" + Chr(34) + BQ9 + Chr(34))
                End If
            End If 'BQ9
            If SQ5 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ5, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ5, 1) <> "i" Then
                    Print(1, "SQ5:=" + Chr(37) + SQ5)
                Else
                    Print(1, "SQ5 :=" + Chr(34) + SQ5 + Chr(34))
                End If
            End If 'SQ5
            If SQ6 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ6, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ6, 1) <> "i" Then
                    Print(1, "SQ6:=" + Chr(37) + SQ6)
                Else
                    Print(1, "SQ6 :=" + Chr(34) + SQ6 + Chr(34))
                End If
            End If 'SQ6
            If SQ7 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ7, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ7, 1) <> "i" Then
                    Print(1, "SQ7:=" + Chr(37) + SQ7)
                Else
                    Print(1, "SQ7 :=" + Chr(34) + SQ7 + Chr(34))
                End If
            End If 'SQ7
            If SQ8 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SQ8, 1) <> "I" Or Microsoft.VisualBasic.Left(SQ8, 1) <> "i" Then
                    Print(1, "SQ8:=" + Chr(37) + SQ8)
                Else
                    Print(1, "SQ8 :=" + Chr(34) + SQ8 + Chr(34))
                End If
            End If 'SQ8
            If SA1B <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SA1B, 1) <> "I" Or Microsoft.VisualBasic.Left(SA1B, 1) <> "i" Then
                    Print(1, "SA1B:=" + Chr(37) + SA1B)
                Else
                    Print(1, "SA1B :=" + Chr(34) + SA1B + Chr(34))
                End If
            End If 'SA1B
            If SB1B <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(SB1B, 1) <> "I" Or Microsoft.VisualBasic.Left(SB1B, 1) <> "i" Then
                    Print(1, "SB1B:=" + Chr(37) + SB1B)
                Else
                    Print(1, "SB1B :=" + Chr(34) + SB1B + Chr(34))
                End If
            End If 'SB1B
            PrintLine(1, ");")

            LINE_NO = LINE_NO + 1
50:         GoTo 40
        End If
70:     xlApp.ActiveWorkbook.Close()
        xlApp.Quit()
        '退出excel程序
        xlsheet = Nothing
        xlBook = Nothing
        xlApp = Nothing
        PrintLine(1, "")
        PrintLine(1, "END_FUNCTION_BLOCK")
        MsgBox(“输入SCL生成完毕”)
        FileClose(1)

        ' Close()
    End Sub

    Private Sub 输出映射SCL_Click(sender As Object, e As EventArgs) Handles 输出映射SCL.Click
        Dim name_of_sheet_IO = IOSheet.Text
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        ' xlApp.Workbooks.Open("c:\MyDate.xls")
        Dim P = Application.StartupPath & "\输入输出表.xlsx"
        Dim txt = Application.StartupPath & "\输出SCL.txt"

        xlApp.Caption = "欢迎,使用!"
        Dim xlBook = xlApp.Workbooks.Open(P) '打开电机数据表
        Dim xlsheet = xlBook.Worksheets(name_of_sheet_IO)   '打开输入输出数据表子表name_of_sheet_IO
        xlApp.Visible = True
        ' On Error GoTo 70
        Dim M_NO
        Dim M_OFFSET As String
        Dim Original_M
        Dim LINE_NO    '定义数据表的行号
        Dim FW As String
        Dim BW As String
        Dim Brake As String
        Dim HL1 As String
        Dim HL2 As String
        Dim HL3 As String
        Dim YV1 As String
        Dim YV2 As String
        Dim YV3 As String
        Dim YV4 As String
        Dim Reset As String
        Dim Run As String
        Dim Reserve1 As String
        Dim Reserve2 As String
        Dim Reserve3 As String
        Dim Reserve4 As String
        Dim Reserve5 As String
        Dim M_SR As String
        Dim M_SR1 As String

        FileOpen(1, txt, OpenMode.Output)
        PrintLine(1, " FUNCTION_BLOCK " + Chr(34) + "OutputTransfer " + Chr(34) + "  ")
        PrintLine(1, Chr(123) + "S7_Optimized_Access :=" + Chr(39) + "TRUE" + Chr(39) + Chr(125))
        PrintLine(1, "VERSION : 0.1")

        LINE_NO = 3
20:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = “start” Then
            PrintLine(1, "VAR")
            LINE_NO = LINE_NO + 1
            GoTo 20
        ElseIf M_NO.ToString <= "0" Then
            GoTo 70
        ElseIf M_NO.ToString = "end" Or M_NO = Nothing Then
            PrintLine(1, "END_VAR")
            PrintLine(1, "BEGIN")
            GoTo 30
        Else
            M_SR = M_NO
            PrintLine(1, "M" + M_SR + Chr(58) + Chr(34) + "#YF#OutputTransfer" + Chr(34) + Chr(59))
            LINE_NO = LINE_NO + 1
            GoTo 20
        End If
30:     LINE_NO = 3
40:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then
            LINE_NO = LINE_NO + 1
            GoTo 40

        ElseIf M_NO.ToString = "end" Or M_NO = Nothing Then
            GoTo 70

        Else
            M_OFFSET = xlsheet.Cells(LINE_NO, 2).Value
            Original_M = xlsheet.Cells(LINE_NO, 3).Value

            FW = xlsheet.Cells(LINE_NO, 37).Value
            BW = xlsheet.Cells(LINE_NO, 38).Value
            Brake = xlsheet.Cells(LINE_NO, 39).Value
            HL1 = xlsheet.Cells(LINE_NO, 40).Value
            HL2 = xlsheet.Cells(LINE_NO, 41).Value
            HL3 = xlsheet.Cells(LINE_NO, 42).Value
            YV1 = xlsheet.Cells(LINE_NO, 43).Value
            YV2 = xlsheet.Cells(LINE_NO, 44).Value
            YV3 = xlsheet.Cells(LINE_NO, 45).Value
            YV4 = xlsheet.Cells(LINE_NO, 46).Value
            Reset = xlsheet.Cells(LINE_NO, 47).Value
            Run = xlsheet.Cells(LINE_NO, 48).Value
            Reserve3 = xlsheet.Cells(LINE_NO, 49).Value
            Reserve4 = xlsheet.Cells(LINE_NO, 50).Value
            Reserve5 = xlsheet.Cells(LINE_NO, 51).Value

            M_SR = M_NO
            M_SR1 = Original_M
            PrintLine(1, "//" + M_SR + "输出信号映射;")
            'Print #1, "//"; M_SR; "输入信号映射;"
            PrintLine(1, Chr(35) + "M" + M_SR + Chr(40))
            PrintLine(1, "M_ID:=" + M_SR + ",")
            Print(1, "M_ID_Offset:=" + M_OFFSET)
            If FW <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(FW, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(FW, 1).ToString = "q" Then
                    Print(1, "FW:=" + Chr(37) + FW)
                Else
                    Print(1, "FW :=" + Chr(34) + FW + Chr(34))
                End If
            End If 'FW
            If BW <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(BW, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(BW, 1).ToString = "q" Then
                    Print(1, "BW:=" + Chr(37) + BW)
                Else
                    Print(1, "BW :=" + Chr(34) + BW + Chr(34))
                End If
            End If
            If Brake <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Brake, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Brake, 1).ToString = "q" Then
                    Print(1, "Brake:=" + Chr(37) + Brake)
                Else
                    Print(1, "Brake :=" + Chr(34) + Brake + Chr(34))
                End If
            End If 'Brake
            If HL1 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(HL1, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(HL1, 1).ToString = "q" Then
                    Print(1, "HL1:=" + Chr(37) + HL1)
                Else
                    Print(1, "HL1 :=" + Chr(34) + HL1 + Chr(34))
                End If
            End If 'HL1
            If HL2 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(HL2, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(HL2, 1).ToString = "q" Then
                    Print(1, "HL2:=" + Chr(37) + HL2)
                Else
                    Print(1, "HL2 :=" + Chr(34) + HL2 + Chr(34))
                End If
            End If 'HL2
            If HL3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(HL3, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(HL3, 1).ToString = "q" Then
                    Print(1, "HL3:=" + Chr(37) + HL3)
                Else
                    Print(1, "HL3 :=" + Chr(34) + HL3 + Chr(34))
                End If
            End If 'HL3
            If YV1 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(YV1, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(YV1, 1).ToString = "q" Then
                    Print(1, "YV1:=" + Chr(37) + YV1)
                Else
                    Print(1, "YV1 :=" + Chr(34) + YV1 + Chr(34))
                End If
            End If 'YV1
            If YV2 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(YV2, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(YV2, 1).ToString = "q" Then
                    Print(1, "YV2:=" + Chr(37) + YV2)
                Else
                    Print(1, "YV2 :=" + Chr(34) + YV2 + Chr(34))
                End If
            End If 'YV2
            If YV3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(YV3, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(YV3, 1).ToString = "q" Then
                    Print(1, "YV3:=" + Chr(37) + YV3)
                Else
                    Print(1, "YV3 :=" + Chr(34) + YV3 + Chr(34))
                End If
            End If 'YV3
            If YV4 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(YV4, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(YV4, 1).ToString = "q" Then
                    Print(1, "YV4:=" + Chr(37) + YV4)
                Else
                    Print(1, "YV4 :=" + Chr(34) + YV4 + Chr(34))
                End If
            End If 'YV4

            If Reset <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Reset, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Reset, 1).ToString = "q" Then
                    Print(1, "Reset:=" + Chr(37) + Reset)
                Else
                    Print(1, "Reset :=" + Chr(34) + Reset + Chr(34))
                End If
            End If 'Reserve1
            If Run <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Run, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Run, 1).ToString = "q" Then
                    Print(1, "Run:=" + Chr(37) + Run)
                Else
                    Print(1, "Run :=" + Chr(34) + Run + Chr(34))
                End If
            End If 'Reserve2
            If Reserve3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Reserve3, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Reserve3, 1).ToString = "q" Then
                    Print(1, "Reserve3:=" + Chr(37) + Reserve3)
                Else
                    Print(1, "Reserve3 :=" + Chr(34) + Reserve3 + Chr(34))
                End If
            End If
            If Reserve3 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Reserve3, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Reserve3, 1).ToString = "q" Then
                    Print(1, "Reserve3:=" + Chr(37) + Reserve3)
                Else
                    Print(1, "Reserve3 :=" + Chr(34) + Reserve3 + Chr(34))
                End If
            End If
            If Reserve4 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Reserve4, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Reserve4, 1).ToString = "q" Then
                    Print(1, "Reserve4:=" + Chr(37) + Reserve4)
                Else
                    Print(1, "Reserve4 :=" + Chr(34) + Reserve4 + Chr(34))
                End If
            End If

            If Reserve5 <> Nothing Then
                PrintLine(1, ",")
                If Microsoft.VisualBasic.Left(Reserve5, 1).ToString = "Q" Or Microsoft.VisualBasic.Left(Reserve5, 1).ToString = "q" Then
                    Print(1, "Reserve5:=" + Chr(37) + Reserve5)
                Else
                    Print(1, "Reserve5 :=" + Chr(34) + Reserve5 + Chr(34))
                End If
            End If


            PrintLine(1, ");")
            LINE_NO = LINE_NO + 1
50:         GoTo 40
        End If



70:     xlApp.ActiveWorkbook.Close()
        xlApp.Quit()
        '退出excel程序
        xlsheet = Nothing
        xlBook = Nothing
        xlApp = Nothing
        PrintLine(1, "")
        PrintLine(1, "END_FUNCTION_BLOCK")
        MsgBox(“输出SCL生成完毕”)
        FileClose(1)
        ' Close()
    End Sub

    Private Sub 电机故障诊断SCL_Click(sender As Object, e As EventArgs) Handles 电机故障诊断SCL.Click

        Dim name_of_sheet_IO = IOSheet.Text
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        ' xlApp.Workbooks.Open("c:\MyDate.xls")
        Dim P = Application.StartupPath & "\电机数据表.xlsx"
        Dim txt = Application.StartupPath & "\Status.txt"

        xlApp.Caption = "欢迎,使用!"

        'Dim xlBook = xlApp.Workbooks.Open("c:\电机数据表.xlsx") '打开电机数据表
        Dim xlBook = xlApp.Workbooks.Open(p) '打开电机数据表
        Dim xlsheet = xlBook.Worksheets(name_of_sheet_IO)   '打开输入输出数据表子表name_of_sheet_IO
        xlApp.Visible = True
        ' On Error GoTo 70

        Dim M_NO
        Dim M2_NO
        Dim M_1or2 As String
        Dim M_MorF As String
        Dim M2_MorF
        Dim M_BQ_1or2
        Dim M_NEXTBQ_1or2
        Dim M_SBorNO
        Dim M_AUTO_1or2
        Dim M_AD_M
        Dim M_AD_C
        Dim M2_AD_M
        Dim M2_AD_C
        Dim M_T_1or2
        Dim LINE_NO
        Dim KM_Err_Enable
        Dim IVALUE1
        Dim IVALUE2

        '定义数据表'定义数据表的行号


        Dim M_NEXT As String
        Dim M_OFFSET As String
        Dim M_BQ As String
        Dim M_NEXTBQ As String
        Dim M_TEMP As String
        Dim M_SR As String
        Dim AUTO As String
        Dim False_ACK As String
        Dim OP_FW As String
        Dim OP_BW As String
        Dim Time_RES As String
        Dim MOTO_RES As String
        Dim PART_READY As String
        Dim TIMER1 As String
        Dim OP_False As String
        Dim T_S1 As String
        Dim TIMER2 As String
        Dim T_S2 As String
        Dim M_TEMP1 As String
        Dim M_SR1 As String
        Dim KM_Err_Timer1 As String
        Dim KM_Err_Timer2 As String
        Dim VFStatus As String
        Dim OP_Fault As String

        FileOpen(1, txt, OpenMode.Output)
        PrintLine(1, " FUNCTION_BLOCK " + Chr(34) + "Status " + Chr(34) + "  ")
        PrintLine(1, Chr(123) + "S7_Optimized_Access :=" + Chr(39) + "TRUE" + Chr(39) + Chr(125))
        PrintLine(1, "VERSION : 0.1")
        PrintLine(1, "VAR")
        LINE_NO = 4
201 ： M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then
            LINE_NO = LINE_NO + 1
            GoTo 201

        ElseIf M_NO.ToString = "end" Or M_NO.ToString = Nothing Then
            GoTo 702

        Else
            M2_NO = xlsheet.Cells(LINE_NO, 11).Value
            M_1or2 = xlsheet.Cells(LINE_NO, 2).Value
            M_NO = xlsheet.Cells(LINE_NO, 1).Value
            M_MorF = xlsheet.Cells(LINE_NO, 3).Value
            M2_MorF = xlsheet.Cells(LINE_NO, 26).Value
            M_SR = M_NO
            M_SR1 = M2_NO

            If M_1or2 = "1" Then
                If M_MorF = "1" Then
                    PrintLine(1, "M" + M_SR + "_Status" + ":" + Chr(34) + "#YF#StatusSTHF" + Chr(34) + Chr(59))
                End If
                If M_MorF = "2" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusVF" + Chr(34))
                End If
                If M_MorF = "3" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusST" + Chr(34))
                End If
                If M_MorF = "4" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusPHIX" + Chr(34))
                End If
                If M_MorF = "5" Then
                    PrintLine(1, "M" + M_SR + "_Status" + ":" + Chr(34) + "#YF#StatusIO" + Chr(34) + Chr(59))
                End If
                If M_MorF = "6" Then
                    PrintLine(1, "M" + M_SR + "_Status" + ":" + Chr(34) + "#YF#StatusIO_VF" + Chr(34) + Chr(59))
                End If
            End If

            If M_1or2 = "2" Then
                If M_MorF = "1" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusSTHF" + Chr(34))
                End If
                If M_MorF = "2" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusVF" + Chr(34))
                End If
                If M_MorF = "3" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusST" + Chr(34))
                End If
                If M_MorF = "4" Then
                    PrintLine(1, Chr(34) + "M" + M_SR + "_Status"":" + Chr(34) + "#YF#StatusPHIX" + Chr(34))
                End If
                If M_MorF = "5" Then
                    PrintLine(1, "M" + M_SR + "_Status" + ":" + Chr(34) + "#YF#StatusIO" + Chr(34) + Chr(59))
                End If
                If M_MorF = "6" Then
                    PrintLine(1, "M" + M_SR + "_Status" + ":" + Chr(34) + "#YF#StatusIO_VF" + Chr(34) + Chr(59))
                End If

                If M2_MorF = "1" Then
                    PrintLine(1, Chr(34) + "M" + M_SR1 + "_Status"":" + Chr(34) + "#YF#StatusSTHF" + Chr(34))
                End If
                If M2_MorF = "2" Then
                    PrintLine(1, Chr(34) + "M" + M_SR1 + "_Status"":" + Chr(34) + "#YF#StatusVF" + Chr(34))
                End If
                If M2_MorF = "3" Then
                    PrintLine(1, Chr(34) + "M" + M_SR1 + "_Status"":" + Chr(34) + "#YF#StatusST" + Chr(34))
                End If
                If M2_MorF = "4" Then
                    PrintLine(1, Chr(34) + "M" + M_SR1 + "_Status"":" + Chr(34) + "#YF#StatusPHIX" + Chr(34))
                End If
                If M2_MorF = "5" Then

                    PrintLine(1, "M" + M_SR1 + "_Status" + ":" + Chr(34) + "#YF#StatusIO" + Chr(34) + Chr(59))
                End If
                If M2_MorF = "6" Then
                    PrintLine(1, "M" + M_SR1 + "_Status" + ":" + Chr(34) + "#YF#StatusIO_VF" + Chr(34) + Chr(59))
                End If
            End If

            LINE_NO = LINE_NO + 1
            GoTo 201
        End If
702:    PrintLine(1, "END_VAR")
        PrintLine(1, "BEGIN")

        LINE_NO = 4
20:     M_NO = xlsheet.Cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then

            AUTO = xlsheet.Cells(LINE_NO, 2).Value
            False_ACK = xlsheet.Cells(LINE_NO, 3).Value
            MOTO_RES = xlsheet.Cells(LINE_NO, 4).Value
            PART_READY = xlsheet.Cells(LINE_NO, 5).Value
            OP_FW = xlsheet.Cells(LINE_NO, 6).Value
            OP_BW = xlsheet.Cells(LINE_NO, 7).Value
            Time_RES = xlsheet.Cells(LINE_NO, 8).Value

            LINE_NO = LINE_NO + 1

            GoTo 20

        ElseIf M_NO.ToString = "end" Or M_NO.ToString = Nothing Then
            GoTo 70

        Else
            M_1or2 = xlsheet.Cells(LINE_NO, 2).Value
            M_MorF = xlsheet.Cells(LINE_NO, 3).Value
            M2_MorF = xlsheet.Cells(LINE_NO, 26).Value
            M_NEXT = xlsheet.Cells(LINE_NO, 4).Value
            M_OFFSET = xlsheet.Cells(LINE_NO, 5).Value
            M_BQ_1or2 = xlsheet.Cells(LINE_NO, 6).Value
            M_NEXTBQ_1or2 = xlsheet.Cells(LINE_NO, 7).Value
            M_AUTO_1or2 = xlsheet.Cells(LINE_NO, 8).Value
            M_BQ = xlsheet.Cells(LINE_NO, 9).Value
            M_NEXTBQ = xlsheet.Cells(LINE_NO, 10).Value
            M2_NO = xlsheet.Cells(LINE_NO, 11).Value
            M_SBorNO = xlsheet.Cells(LINE_NO, 12).Value
            M_AD_M = xlsheet.Cells(LINE_NO, 13).Value
            M_AD_C = xlsheet.Cells(LINE_NO, 14).Value
            M2_AD_M = xlsheet.Cells(LINE_NO, 24).Value
            M2_AD_C = xlsheet.Cells(LINE_NO, 25).Value
            M_T_1or2 = xlsheet.Cells(LINE_NO, 15).Value
            TIMER1 = xlsheet.Cells(LINE_NO, 16).Value
            T_S1 = xlsheet.Cells(LINE_NO, 17).Value
            TIMER2 = xlsheet.Cells(LINE_NO, 18).Value
            T_S2 = xlsheet.Cells(LINE_NO, 19).Value
            KM_Err_Enable = xlsheet.Cells(LINE_NO, 27).Value
            KM_Err_Timer1 = xlsheet.Cells(LINE_NO, 28).Value
            KM_Err_Timer2 = xlsheet.Cells(LINE_NO, 29).Value
            IVALUE1 = xlsheet.Cells(LINE_NO, 30).Value
            IVALUE2 = xlsheet.Cells(LINE_NO, 31).Value
            VFStatus = xlsheet.Cells(LINE_NO, 32).Value

            M_SR = M_NO
            M_SR1 = M2_NO

            If M_MorF = "1" Then
                    PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                    PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                    PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_NO * M_AD_M + M_AD_C), 4) + ",")
                    PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                    PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID);")

            ElseIf M_MorF = "2" Then
                    PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                    PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                    PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                    PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                    PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                    PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID);")

                ElseIf M_MorF = "3" Then
                PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                    PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                    PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                    PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                    PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",") ''
                    PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID);")
                ElseIf M_MorF = "4" Then
                PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                    PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                    PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                    PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")   ''
                    PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID,")
                    PrintLine(1, "Ivalue  := B#16#" + IVALUE1 + ");")

                ElseIf M_MorF = "5" Then
                PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                    PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                '  PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If KM_Err_Enable = "2" Then
                        PrintLine(1, "KM_Err_Enable := " + Chr(34) + "False" + Chr(34) + ",")
                        'ElseIf KM_Err_Enable = 2 Then
                    Else
                        PrintLine(1, "KM_Err_Enable  := " + Chr(34) + "True" + Chr(34) + ",")
                    End If
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                    PrintLine(1, "KM_Err_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                    PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID);")
                ElseIf M_MorF = "6" Then
                PrintLine(1, "//" + M_SR + "故障处理程序; ")
                PrintLine(1, Chr(35) + "M" + M_SR + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR + ",")
                    PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                '  PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                    PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                    If M_T_1or2 = "1" Then
                        PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                    Else
                        PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                    End If
                    PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                    PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "VF_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= " + Chr(34) + "INFO" + Chr(34) + ".M[" + M_SR + "].Work_ID);")
                End If



            If M_1or2 = "2" And M2_MorF = "1" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)

                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_NO * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                If M_T_1or2 = "1" Then
                    PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                Else
                    PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                End If
                PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= DB8.DB1000")

            ElseIf M_1or2 = "2" And M2_MorF = "2" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)
                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                If M_T_1or2 = "1" Then
                    PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                Else
                    PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                End If
                PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= DB8.DB1000")

            ElseIf M_1or2 = "2" And M2_MorF = "3" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)
                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                If M_T_1or2 = "1" Then
                    PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                Else
                    PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                End If
                PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",") ''
                PrintLine(1, "Job_ID:=DB8.DB1000")
            ElseIf M_1or2 = "2" And M2_MorF = "4" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)
                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                If M_T_1or2 = "1" Then
                    PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                Else
                    PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                End If
                PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "M_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")   ''
                PrintLine(1, "Job_ID:= DB8.DB1000")
                PrintLine(1, "Ivalue  := B#16#" + IVALUE1 + ");")

            ElseIf M_1or2 = "2" And M2_MorF = "5" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)
                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                '  PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                If KM_Err_Enable = "2" Then
                    PrintLine(1, "KM_Err_Enable := " + Chr(34) + "False" + Chr(34) + ",")
                    'ElseIf KM_Err_Enable = 2 Then
                Else
                    PrintLine(1, "KM_Err_Enable  := " + Chr(34) + "True" + Chr(34) + ",")
                End If
                If M_T_1or2 = "1" Then
                    PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                Else
                    PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                End If
                PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "KM_Err_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= DB8.DB1000")
            ElseIf M_1or2 = "2" And M2_MorF = "6" Then
                PrintLine(1, "//" + M_SR + ".1故障处理程序: " + M_SR + ".1虚拟设备平面号为" + M_SR1)
                PrintLine(1, Chr(35) + "M" + M_SR1 + "_status" + Chr(40))
                PrintLine(1, "M_ID :=" + M_SR1 + ",")
                        PrintLine(1, "M_ID_Offset :=" + M_OFFSET + ",")
                '     PrintLine(1, "Address :=" + Microsoft.VisualBasic.Left(Str(M_SR * M_AD_M + M_AD_C), 4) + ",")
                PrintLine(1, "OP_Mode :=" + Chr(34) + AUTO + Chr(34) + ",")
                        PrintLine(1, "Sensor:=" + Chr(34) + "INPUT" + Chr(34) + ".M[" + M_SR + "]." + M_BQ + ",")
                        If M_T_1or2 = "1" Then
                            PrintLine(1, "T_Enable :=" + Chr(34) + "True" + Chr(34) + ",")
                        Else
                            PrintLine(1, "T_Enable :=" + Chr(34) + "False" + Chr(34) + ",")
                        End If
                        PrintLine(1, "T_Time := T#" + T_S1 + "S,")
                        PrintLine(1, "T_Reset :=" + Chr(34) + Time_RES + Chr(34) + ",")
                PrintLine(1, "VF_Reset:=" + Chr(34) + MOTO_RES + Chr(34) + ",")
                PrintLine(1, "Job_ID:= DB8.DB1000")



            End If


            LINE_NO = LINE_NO + 1
50:             GoTo 20
            End If


70:     LINE_NO = 4
200:    M_NO = xlsheet.cells(LINE_NO, 1).Value
        If M_NO.ToString = "start" Then
            OP_Fault = xlsheet.cells(LINE_NO, 9).Value

            PrintLine(1, "// 故障汇总")
            Print(1, "IF")
            LINE_NO = LINE_NO + 1
            GoTo 200
        ElseIf M_NO.ToString = "end" Then
            PrintLine(1, "Then")
            PrintLine(1, Chr(34) + OP_Fault + Chr(34) + ":" + "= 1" + ";")
            PrintLine(1, "ELSE")
            PrintLine(1, Chr(34) + OP_Fault + Chr(34) + ":" + "= 0" + ";")
            PrintLine(1, "END_IF;")
            GoTo 700

        Else
            M2_NO = xlsheet.cells(LINE_NO, 11).Value
            M_1or2 = xlsheet.cells(LINE_NO, 2).Value
            M_SR = M_NO
            M_SR1 = M2_NO

            If M_1or2 = 1 Then
                PrintLine(1, " OR" + Chr(34) + "STA" + Chr(34) + ".M[" + M_SR + "].Fault")
            ElseIf M_1or2 = 2 Then
                PrintLine(1, "OR" + Chr(34) + "STA" + Chr(34) + ".M[" + M_SR + "].Fault")
                PrintLine(1, "OR" + Chr(34) + "STA" + Chr(34) + ".M[" + M_SR1 + "].Fault")
            End If
            LINE_NO = LINE_NO + 1

            GoTo 200
        End If





700:    xlApp.ActiveWorkbook.Close()
        xlApp.Quit()
        '退出excel程序
        xlsheet = Nothing
        xlBook = Nothing
        xlApp = Nothing
        PrintLine(1, "")
        PrintLine(1, "END_FUNCTION_BLOCK")
        MsgBox(“故障诊断SCL生成完毕”)
        FileClose(1)
        '  Close()






    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class




