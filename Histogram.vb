'Imports System.Data

Public Class Histogram

    Public dbHist As New Data.DataTable '("dbHist")
    Sub crt_Histogram()

        dbHist.Columns.Add("hist_name", GetType(System.String))
        dbHist.Columns("hist_name").Unique = True
        dbHist.PrimaryKey = New DataColumn() {dbHist.Columns("hist_name")}

        'dbHist.Columns.Add("hist_name", GetType(System.String))
        'dbHist.Columns.Add("Std_Name", GetType(System.String)) ' ชื่อค่ามาตรฐาน เช่น  ค่ากลาง Std , ค่าต่ำ Lower , สูง Upper

        dbHist.Columns.Add("v_x", GetType(System.Double))
        dbHist.Columns.Add("v_y", GetType(System.Double))

        '=============================================
    End Sub

    Sub addNewHist(hist_name As String, hist_x As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = hist_name
        foundRow = dbHist.Rows.Find(s)

        If foundRow IsNot Nothing Then  ' ถ้ามีอยู่แล้ว

            foundRow.Item("v_y") = foundRow.Item("v_y") + 1
            '    foundRow.Item("Name") = SL_Name
        Else
            dbHist.Rows.Add(New Object() {hist_name, hist_x, 1})

        End If
    End Sub

    Sub setHist_y(hist_name As String, hist_x As Double)

    End Sub

End Class
