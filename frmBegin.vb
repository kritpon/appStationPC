Imports System.Windows.Forms.DataVisualization.Charting
'Imports System.ComponentModel

Public Class frmBegin

    Public hist As New Histogram

    Dim subDS As New DataSet
    Dim subDA As SqlClient.SqlDataAdapter
    Dim chkData As Boolean = False

    Private Sub frmBegin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvBOMformat()
    End Sub

    Sub lsvBOMformat()

        lsvData.Columns.Add("#", 30, HorizontalAlignment.Right) '1====== 0   
        lsvData.Columns.Add("วันที่", 100, HorizontalAlignment.Left) '1====== 2   
        lsvData.Columns.Add("Station", 90, HorizontalAlignment.Center) '1====== 3 
        lsvData.Columns.Add("เลขที่", 150, HorizontalAlignment.Center) '1====== 1               
        lsvData.Columns.Add("ชุดงาน", 250, HorizontalAlignment.Left) '1====== 3 
        lsvData.Columns.Add("STD.", 80, HorizontalAlignment.Right) '1====== 3 
        lsvData.Columns.Add("นน.จริง", 80, HorizontalAlignment.Right) '1====== 3 


        lsvData.Columns.Add("Lower.", 80, HorizontalAlignment.Right) '1====== 3 
        lsvData.Columns.Add("Upper.", 80, HorizontalAlignment.Right) '1====== 3 

        ' lsvData.Columns.Add("หน่วย", 50, HorizontalAlignment.Right) '1====== 3 
        lsvData.Columns.Add("วันเวลา", 200, HorizontalAlignment.Right) '1====== 3 

        'lsvShowData.Columns.Add("ลูกค้า", 100, HorizontalAlignment.Left) '4====== 3

        lsvData.View = View.Details
        lsvData.GridLines = True

    End Sub

    Sub showData()


        Dim data01 As New DataPoint()
        Dim series0 As New Series("SERIES0")

        Dim lvi As ListViewItem
        Dim anyData() As String
        Dim i As Integer = 0
        Dim strDate01 As String = strToDate(txtDate01.Value)
        Dim strDate02 As String = strToDate(txtDate02.Value)

        Dim intScales As Integer = 0


        chtWeight.ChartAreas(0).AxisX.LineWidth = 2
        chtWeight.ChartAreas(0).AxisX.Interval = 1
        chtWeight.Series.Clear()

        If optS_1.Checked = True Then '
            intScales = 1
        ElseIf optS_2.Checked = True Then
            intScales = 2
        ElseIf optS_3.Checked = True Then
            intScales = 3
        ElseIf optS_4.Checked = True Then
            intScales = 4
        ElseIf optS_5.Checked = True Then
            intScales = 5
        End If

        txtSQL = "Select BOM_RM_Update,BOMmastF.BOM_No,BOM_PC_Name,BOM_RM_Scales,"
        txtSQL = txtSQL & "(TBmastD.BOM_RM_Values) bomD_Val,(BOMmastF.BOM_RM_Values)bomF_Val,"
        txtSQL = txtSQL & "BOM_RM_UpdateTime  "

        txtSQL = txtSQL & "From BOMmastF "
        txtSQL = txtSQL & "Left Join BOMmastH "
        txtSQL = txtSQL & "On BOMmastH.BOM_No=BOMmastF.BOM_No "

        txtSQL = txtSQL & "Left Join (Select *  "
        txtSQL = txtSQL & "From BOMmastD "
        txtSQL = txtSQL & "Where BOM_RM_Code='04001') TBmastD "

        txtSQL = txtSQL & "On BOMmastF.BOM_No = TBmastD.BOM_No "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On BOM_Stk_Code=Stk_Code "

        txtSQL = txtSQL & "Left Join TranDataH_PM "
        txtSQL = txtSQL & "On BOMmastH.BOM_No=TranDataH_PM.Trh_No "

        txtSQL = txtSQL & "Where BOM_RM_Scales='" & intScales & "' "
        txtSQL = txtSQL & "And (BOM_RM_Update Between '" & strDate01 & "' "
        txtSQL = txtSQL & "And '" & strDate02 & "') "

        If txtStkName.Text <> "" Then
            txtSQL = txtSQL & "And BOM_PC_Name like '%" & txtStkName.Text & "%' "
        End If

        If txtDocNo.Text = "" Then
        Else
            txtSQL = txtSQL & "And BOMmastH.BOM_No = '" & txtDocNo.Text & "' "
        End If

        txtSQL = txtSQL & "Order by BOM_RM_Updatetime asc "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("master").Clear()
            chkData = False
        End If
        subDA.Fill(subDS, "master")
        chkData = True
        lbNTotal.Text = subDS.Tables("master").Rows.Count

        Dim strDate As String
        Dim strDoc As String
        Dim strStkItem As String
        Dim strStation As String
        Dim dblStkWeightLower As Double = 0
        Dim dblStkWeightUpper As Double = 0
        Dim dblStkWeight As Double = 0
        Dim strStkWeight As String = ""
        Dim dblStkWeightSTD As Double
        Dim strUpdateDate As String
        Dim dblChangeValues As Double

        lsvData.Items.Clear()
        lbQtyN.Text = 0
        lbErrLower.Text = 0
        lbErrUpper.Text = 0
        'lbNTotal.Text=0
        lbQtyN_Total.Text = 0
        Dim errValue1 As Double
        Dim errValue2 As Double

        Dim intQtyStd As Integer = 0
        Dim intQtyUpper As Integer = 0
        Dim intQtyLower As Integer = 0
        Dim chkLowerUpper As Integer = 0
        Dim chkRow As Integer = 0
        hist.crt_Histogram()

        For x = 0 To subDS.Tables("master").Rows.Count - 1
            errValue1 = 0
            errValue2 = 0

            If chkRow = 0 Then
                chkRow = 1
            Else
                chkRow = 0
            End If
            With subDS.Tables("master").Rows(x)

                strDate = .Item("BOM_RM_Update")
                strDoc = .Item("BOM_No")
                strStkItem = .Item("BOM_PC_Name")
                strStation = .Item("BOM_RM_Scales")

                dblStkWeight = .Item("bomF_Val")
                dblStkWeightSTD = .Item("bomD_Val")
                '===========  คำนวน Upper Lower ===================

                dblChangeValues = CDbl((dblStkWeightSTD * (txtUplow.Text)) / 100)
                dblStkWeightLower = dblStkWeightSTD - dblChangeValues
                dblStkWeightUpper = dblStkWeightSTD + dblChangeValues

                '===========  คำนวน Upper Lower ===================

                strUpdateDate = .Item("BOM_RM_UpdateTime")
                errValue1 = dblStkWeightSTD - (dblStkWeightSTD * txtErr1.Text) / 100 '
                errValue2 = dblStkWeightSTD + (dblStkWeightSTD * txtErr2.Text) / 100 ' +
                strStkWeight = (dblStkWeight).ToString("#,##0.0")
                hist.addNewHist(strStkWeight, dblStkWeight)

            End With
            '=============================================================
            If chkCutErr1.Checked = False Then  '=======================  01
                If chkCutErr2.Checked = True Then
                    If dblStkWeight <= errValue2 Then

                        If (dblStkWeight <= dblStkWeightUpper) And (dblStkWeight >= dblStkWeightLower) Then
                            intQtyStd = intQtyStd + 1
                            chkLowerUpper = 0
                        Else
                            intQtyLower = intQtyLower + 1
                            chkLowerUpper = 1
                        End If
                        i = i + 1
                        anyData = New String() {i, strDate, strStation, strDoc, strStkItem, dblStkWeightSTD.ToString("#,##0.0"), dblStkWeight.ToString("#,##0.0"), dblStkWeightLower.ToString("#,##0.0"), dblStkWeightUpper.ToString("#,##0.0"), strUpdateDate}
                        lvi = New ListViewItem(anyData)
                        'If chkLowerUpper = 1 Then
                        '    lvi.BackColor = System.Drawing.Color.DarkOrange
                        '    lvi.ForeColor = System.Drawing.Color.Black

                        'Else

                        '    lvi.BackColor = System.Drawing.Color.GreenYellow
                        '    lvi.ForeColor = System.Drawing.Color.Black

                        'End If
                        lsvData.Items.Add(lvi)
                        series0.Points.AddXY(strDoc, dblStkWeight)
                        lbQtyN.Text = lbQtyN.Text + 1
                    Else
                        lbErrUpper.Text = lbErrUpper.Text + 1
                    End If
                ElseIf chkCutErr2.Checked = False Then  '=======================  00

                    If (dblStkWeight <= dblStkWeightUpper) And (dblStkWeight >= dblStkWeightLower) Then
                        intQtyStd = intQtyStd + 1
                        chkLowerUpper = 0
                    Else
                        intQtyLower = intQtyLower + 1
                        chkLowerUpper = 1
                    End If
                    i = i + 1
                    anyData = New String() {i, strDate, strStation, strDoc, strStkItem, dblStkWeightSTD.ToString("#,##0.0"), dblStkWeight.ToString("#,##0.0"), dblStkWeightLower.ToString("#,##0.0"), dblStkWeightUpper.ToString("#,##0.0"), strUpdateDate}
                    lvi = New ListViewItem(anyData)
                    'If chkLowerUpper = 1 Then
                    '    lvi.BackColor = System.Drawing.Color.DarkOrange
                    '    lvi.ForeColor = System.Drawing.Color.Black

                    'Else

                    '    lvi.BackColor = System.Drawing.Color.GreenYellow
                    '    lvi.ForeColor = System.Drawing.Color.Black

                    'End If
                    lsvData.Items.Add(lvi)
                    series0.Points.AddXY(strDoc, dblStkWeight)
                    lbQtyN.Text = lbQtyN.Text + 1
                End If

            ElseIf chkCutErr1.Checked = True Then '=======================  11

                If chkCutErr2.Checked = True Then
                    If dblStkWeight >= errValue1 Then
                        If dblStkWeight <= errValue2 Then

                            If (dblStkWeight <= dblStkWeightUpper) And (dblStkWeight >= dblStkWeightLower) Then
                                intQtyStd = intQtyStd + 1
                                chkLowerUpper = 0
                            Else
                                intQtyLower = intQtyLower + 1
                                chkLowerUpper = 1
                            End If
                            i = i + 1
                            anyData = New String() {i, strDate, strStation, strDoc, strStkItem, dblStkWeightSTD.ToString("#,##0.0"), dblStkWeight.ToString("#,##0.0"), dblStkWeightLower.ToString("#,##0.0"), dblStkWeightUpper.ToString("#,##0.0"), strUpdateDate}
                            lvi = New ListViewItem(anyData)
                            'If chkLowerUpper = 1 Then
                            '    lvi.BackColor = System.Drawing.Color.DarkOrange
                            '    lvi.ForeColor = System.Drawing.Color.Black

                            'Else

                            '    lvi.BackColor = System.Drawing.Color.GreenYellow
                            '    lvi.ForeColor = System.Drawing.Color.Black

                            'End If
                            lsvData.Items.Add(lvi)
                            series0.Points.AddXY(strDoc, dblStkWeight)
                            lbQtyN.Text = lbQtyN.Text + 1
                        Else
                            lbErrUpper.Text = lbErrUpper.Text + 1

                        End If
                    Else
                        lbErrLower.Text = lbErrLower.Text + 1
                    End If

                ElseIf chkCutErr2.Checked = False Then  '=======================  10
                    If dblStkWeight >= errValue1 Then

                        If (dblStkWeight <= dblStkWeightUpper) And (dblStkWeight >= dblStkWeightLower) Then
                            intQtyStd = intQtyStd + 1
                            chkLowerUpper = 0
                        Else
                            intQtyLower = intQtyLower + 1
                            chkLowerUpper = 1
                        End If
                        i = i + 1
                        anyData = New String() {i, strDate, strStation, strDoc, strStkItem, dblStkWeightSTD.ToString("#,##0.0"), dblStkWeight.ToString("#,##0.0"), dblStkWeightLower.ToString("#,##0.0"), dblStkWeightUpper.ToString("#,##0.0"), strUpdateDate}
                        lvi = New ListViewItem(anyData)

                        lsvData.Items.Add(lvi)

                        series0.Points.AddXY(strDoc, dblStkWeight)
                        lbQtyN.Text = lbQtyN.Text + 1
                    Else
                        lbErrLower.Text = lbErrLower.Text + 1
                    End If
                End If

            End If
            If chkLowerUpper = 1 Then

                lvi.BackColor = System.Drawing.Color.DarkOrange
                lvi.ForeColor = System.Drawing.Color.Black


            Else
                If chkRow = 1 Then
                    lvi.BackColor = System.Drawing.Color.WhiteSmoke
                    lvi.ForeColor = System.Drawing.Color.Black

                Else
                    lvi.BackColor = System.Drawing.Color.White
                    lvi.ForeColor = System.Drawing.Color.Black

                End If

            End If
            'Else '=======================  00
            '    anyData = New String() {i, strDate, strStation, strDoc, strStkItem, dblStkWeightSTD.ToString("#,##0.00"), dblStkWeight.ToString("#,##0.00"), dblStkWeightLower.ToString("#,##0.00"), dblStkWeightUpper.ToString("#,##0.00"), strUpdateDate}
            '    lvi = New ListViewItem(anyData)
            '    lsvData.Items.Add(lvi)
            '    series0.Points.AddXY(strDoc, dblStkWeight)
            'End If

        Next
        lbQtyStd.Text = intQtyStd
        lbQtyLower.Text = intQtyLower

        lbQtyN_Total.Text = Format(CInt(lbQtyN.Text) + CInt(lbErrLower.Text) + CInt(lbErrUpper.Text), "#,##0")
        series0.ChartType = SeriesChartType.Column
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        series0.Palette = ChartColorPalette.EarthTones
        series0.ChartType = SeriesChartType.Line
        'If optTypeBar.Checked = True Then

        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    series0.IsVisibleInLegend = True
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)

        With chtWeight
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(series0)
            .BorderlineWidth = 1
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            'chtWeight.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With



    End Sub
    Private Sub cmbRun_Click(sender As Object, e As EventArgs) Handles cmbRun.Click

        Call showData()

    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
        txtDate02.Value = txtDate01.Value
    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        End
    End Sub

    Private Sub txtStkName_TextChanged(sender As Object, e As EventArgs) Handles txtStkName.TextChanged

    End Sub

    Private Sub txtStkName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStkName.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call showData()
        End If


    End Sub

    Private Sub cmbPrint_Click(sender As Object, e As EventArgs) Handles cmbPrint.Click

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim rw As Integer = 0
        Dim rowExcel As Integer = 4 ' เริ่มที่บันทัดที่ 9
        Dim bufferExcel As Integer = 0 '
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0
        ' Dim fileName As String

        'fileName = CurDir() & "\report\rptWeight.xlsx"
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptWeight.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet


            If IsDBNull(subDS.Tables("master")) Then
                Exit Sub
            Else
                rw = subDS.Tables("master").Rows.Count - 1

            End If

            For countRow = 0 To rw
                .Range("B" & rowExcel).Select()
                .Range("B" & rowExcel).Value = countRow + 1
                .Range("C" & rowExcel).Select()
                .Range("C" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_RM_Update")
                .Range("D" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_RM_Scales")
                .Range("E" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_No")
                .Range("F" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_PC_Name")
                .Range("G" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_RM_Values")

                .Range("H" & rowExcel).Value = subDS.Tables("master").Rows(countRow).Item("BOM_RM_UpdateTime")
                rowExcel = rowExcel + 1

            Next

        End With
        objExcel = Nothing
        objExcelWorkBook = Nothing
        objExcelWorkSheet = Nothing
    End Sub

    Private Sub txtDocNo_TextChanged(sender As Object, e As EventArgs) Handles txtDocNo.TextChanged

    End Sub

    Private Sub txtDocNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDocNo.Text = "" Then
                MsgBox("ไม่มีข้อมูล")
            Else
                Call showData()
            End If

        End If
    End Sub

    Private Sub txtErr_TextChanged(sender As Object, e As EventArgs) Handles txtErr1.TextChanged

    End Sub


    Private Sub txtUplow_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUplow.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call showData()

        End If
    End Sub

    Private Sub txtErr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtErr1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call showData()
            txtErr2.Text = txtErr1.Text
            txtErr2.Focus()
        End If
    End Sub

    Private Sub txtErr2_TextChanged(sender As Object, e As EventArgs) Handles txtErr2.TextChanged

    End Sub

    Private Sub txtErr2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtErr2.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call showData()

        End If
    End Sub

    Private Sub chkSection_CheckedChanged(sender As Object, e As EventArgs) Handles chkSection.CheckedChanged
        If chkSection.Checked = True Then
            'If optA.Checked = True Then
            optB.Checked = True
            'Else

            'End If
        Else


        End If
    End Sub
End Class
