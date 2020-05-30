<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBegin
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
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lsvData = New System.Windows.Forms.ListView()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.txtDate02 = New System.Windows.Forms.DateTimePicker()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optS_1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optS_5 = New System.Windows.Forms.RadioButton()
        Me.optS_4 = New System.Windows.Forms.RadioButton()
        Me.optS_3 = New System.Windows.Forms.RadioButton()
        Me.optS_2 = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chtUpperLow = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chtWeight = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtStkName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkCutErr1 = New System.Windows.Forms.CheckBox()
        Me.cmbPrint = New System.Windows.Forms.Button()
        Me.txtErr1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUplow = New System.Windows.Forms.TextBox()
        Me.lbQtyN = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.optSection = New System.Windows.Forms.GroupBox()
        Me.chkSection = New System.Windows.Forms.CheckBox()
        Me.optB = New System.Windows.Forms.RadioButton()
        Me.optA = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtErr2 = New System.Windows.Forms.TextBox()
        Me.chkCutErr2 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbErrLower = New System.Windows.Forms.Label()
        Me.lbErrUpper = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbQtyN_Total = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbNTotal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbQtyUper = New System.Windows.Forms.Label()
        Me.lbQtyLower = New System.Windows.Forms.Label()
        Me.lbQtyStd = New System.Windows.Forms.Label()
        Me.lbLowUpperTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbTotal_Retio = New System.Windows.Forms.Label()
        Me.lbUpper_Retio = New System.Windows.Forms.Label()
        Me.lbLower_Retio = New System.Windows.Forms.Label()
        Me.lbStd_Retio = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.chtUpperLow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.chtWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.optSection.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvData
        '
        Me.lsvData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvData.FullRowSelect = True
        Me.lsvData.GridLines = True
        Me.lsvData.HideSelection = False
        Me.lsvData.Location = New System.Drawing.Point(6, 6)
        Me.lsvData.Name = "lsvData"
        Me.lsvData.Size = New System.Drawing.Size(1322, 417)
        Me.lsvData.TabIndex = 0
        Me.lsvData.UseCompatibleStateImageBehavior = False
        '
        'cmbRun
        '
        Me.cmbRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRun.Location = New System.Drawing.Point(399, 17)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(105, 43)
        Me.cmbRun.TabIndex = 1
        Me.cmbRun.Text = "RUN"
        Me.cmbRun.UseVisualStyleBackColor = False
        '
        'txtDate02
        '
        Me.txtDate02.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate02.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate02.Location = New System.Drawing.Point(219, 22)
        Me.txtDate02.Name = "txtDate02"
        Me.txtDate02.Size = New System.Drawing.Size(157, 24)
        Me.txtDate02.TabIndex = 2
        '
        'txtDate01
        '
        Me.txtDate01.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate01.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate01.Location = New System.Drawing.Point(28, 23)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(157, 24)
        Me.txtDate01.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ถึง"
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Red
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(399, 155)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(105, 43)
        Me.cmbExit.TabIndex = 5
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(219, 56)
        Me.txtDocNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(157, 24)
        Me.txtDocNo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "เลขที่เอกสาร"
        '
        'optS_1
        '
        Me.optS_1.AutoSize = True
        Me.optS_1.Location = New System.Drawing.Point(6, 17)
        Me.optS_1.Name = "optS_1"
        Me.optS_1.Size = New System.Drawing.Size(66, 17)
        Me.optS_1.TabIndex = 8
        Me.optS_1.Text = "Scales 1"
        Me.optS_1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optS_5)
        Me.GroupBox1.Controls.Add(Me.optS_4)
        Me.GroupBox1.Controls.Add(Me.optS_3)
        Me.GroupBox1.Controls.Add(Me.optS_2)
        Me.GroupBox1.Controls.Add(Me.optS_1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 133)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scales ที่"
        '
        'optS_5
        '
        Me.optS_5.AutoSize = True
        Me.optS_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optS_5.Checked = True
        Me.optS_5.Location = New System.Drawing.Point(6, 105)
        Me.optS_5.Name = "optS_5"
        Me.optS_5.Size = New System.Drawing.Size(66, 17)
        Me.optS_5.TabIndex = 12
        Me.optS_5.TabStop = True
        Me.optS_5.Text = "Scales 5"
        Me.optS_5.UseVisualStyleBackColor = False
        '
        'optS_4
        '
        Me.optS_4.AutoSize = True
        Me.optS_4.Location = New System.Drawing.Point(6, 83)
        Me.optS_4.Name = "optS_4"
        Me.optS_4.Size = New System.Drawing.Size(66, 17)
        Me.optS_4.TabIndex = 11
        Me.optS_4.Text = "Scales 4"
        Me.optS_4.UseVisualStyleBackColor = True
        '
        'optS_3
        '
        Me.optS_3.AutoSize = True
        Me.optS_3.Location = New System.Drawing.Point(6, 61)
        Me.optS_3.Name = "optS_3"
        Me.optS_3.Size = New System.Drawing.Size(66, 17)
        Me.optS_3.TabIndex = 10
        Me.optS_3.Text = "Scales 3"
        Me.optS_3.UseVisualStyleBackColor = True
        '
        'optS_2
        '
        Me.optS_2.AutoSize = True
        Me.optS_2.Location = New System.Drawing.Point(6, 39)
        Me.optS_2.Name = "optS_2"
        Me.optS_2.Size = New System.Drawing.Size(66, 17)
        Me.optS_2.TabIndex = 9
        Me.optS_2.Text = "Scales 2"
        Me.optS_2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(10, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1389, 455)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lsvData)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1381, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chtUpperLow)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1381, 429)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chtUpperLow
        '
        Me.chtUpperLow.BorderlineColor = System.Drawing.Color.Black
        ChartArea11.Name = "ChartArea1"
        Me.chtUpperLow.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.chtUpperLow.Legends.Add(Legend11)
        Me.chtUpperLow.Location = New System.Drawing.Point(6, 6)
        Me.chtUpperLow.Name = "chtUpperLow"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.chtUpperLow.Series.Add(Series11)
        Me.chtUpperLow.Size = New System.Drawing.Size(1362, 417)
        Me.chtUpperLow.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chtWeight)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1334, 353)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chtWeight
        '
        Me.chtWeight.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea12.Name = "ChartArea1"
        Me.chtWeight.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.chtWeight.Legends.Add(Legend12)
        Me.chtWeight.Location = New System.Drawing.Point(17, 8)
        Me.chtWeight.Name = "chtWeight"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.chtWeight.Series.Add(Series12)
        Me.chtWeight.Size = New System.Drawing.Size(1301, 328)
        Me.chtWeight.TabIndex = 1
        Me.chtWeight.Text = "Chart1"
        '
        'txtStkName
        '
        Me.txtStkName.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtStkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStkName.Location = New System.Drawing.Point(86, 19)
        Me.txtStkName.Name = "txtStkName"
        Me.txtStkName.Size = New System.Drawing.Size(299, 26)
        Me.txtStkName.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ชื่อชุดงาน"
        '
        'chkCutErr1
        '
        Me.chkCutErr1.AutoSize = True
        Me.chkCutErr1.Checked = True
        Me.chkCutErr1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCutErr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCutErr1.Location = New System.Drawing.Point(23, 19)
        Me.chkCutErr1.Name = "chkCutErr1"
        Me.chkCutErr1.Size = New System.Drawing.Size(135, 22)
        Me.chkCutErr1.TabIndex = 19
        Me.chkCutErr1.Text = "ตัดข้อมูล Error <="
        Me.chkCutErr1.UseVisualStyleBackColor = True
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.Green
        Me.cmbPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrint.Location = New System.Drawing.Point(399, 93)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(105, 43)
        Me.cmbPrint.TabIndex = 20
        Me.cmbPrint.Text = "Print"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'txtErr1
        '
        Me.txtErr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtErr1.Location = New System.Drawing.Point(209, 18)
        Me.txtErr1.Name = "txtErr1"
        Me.txtErr1.Size = New System.Drawing.Size(58, 24)
        Me.txtErr1.TabIndex = 21
        Me.txtErr1.Text = "10"
        Me.txtErr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "%"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(573, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "%"
        '
        'txtUplow
        '
        Me.txtUplow.BackColor = System.Drawing.Color.Yellow
        Me.txtUplow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUplow.Location = New System.Drawing.Point(511, 20)
        Me.txtUplow.Name = "txtUplow"
        Me.txtUplow.Size = New System.Drawing.Size(58, 24)
        Me.txtUplow.TabIndex = 26
        Me.txtUplow.Text = "5"
        Me.txtUplow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbQtyN
        '
        Me.lbQtyN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbQtyN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQtyN.ForeColor = System.Drawing.Color.White
        Me.lbQtyN.Location = New System.Drawing.Point(435, 79)
        Me.lbQtyN.Name = "lbQtyN"
        Me.lbQtyN.Size = New System.Drawing.Size(70, 21)
        Me.lbQtyN.TabIndex = 28
        Me.lbQtyN.Text = "0"
        Me.lbQtyN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(391, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 21)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "ค่า Lower Upper"
        '
        'optSection
        '
        Me.optSection.Controls.Add(Me.chkSection)
        Me.optSection.Controls.Add(Me.optB)
        Me.optSection.Controls.Add(Me.optA)
        Me.optSection.Location = New System.Drawing.Point(132, 91)
        Me.optSection.Margin = New System.Windows.Forms.Padding(2)
        Me.optSection.Name = "optSection"
        Me.optSection.Padding = New System.Windows.Forms.Padding(2)
        Me.optSection.Size = New System.Drawing.Size(244, 54)
        Me.optSection.TabIndex = 30
        Me.optSection.TabStop = False
        Me.optSection.Text = "กะผลิต"
        '
        'chkSection
        '
        Me.chkSection.AutoSize = True
        Me.chkSection.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkSection.Checked = True
        Me.chkSection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSection.Location = New System.Drawing.Point(5, 21)
        Me.chkSection.Name = "chkSection"
        Me.chkSection.Size = New System.Drawing.Size(92, 22)
        Me.chkSection.TabIndex = 44
        Me.chkSection.Text = "เลือกกะผลิต"
        Me.chkSection.UseVisualStyleBackColor = False
        '
        'optB
        '
        Me.optB.AutoSize = True
        Me.optB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optB.Location = New System.Drawing.Point(182, 21)
        Me.optB.Margin = New System.Windows.Forms.Padding(2)
        Me.optB.Name = "optB"
        Me.optB.Size = New System.Drawing.Size(58, 24)
        Me.optB.TabIndex = 1
        Me.optB.TabStop = True
        Me.optB.Text = "กะ B"
        Me.optB.UseVisualStyleBackColor = True
        '
        'optA
        '
        Me.optA.AutoSize = True
        Me.optA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optA.Location = New System.Drawing.Point(110, 21)
        Me.optA.Margin = New System.Windows.Forms.Padding(2)
        Me.optA.Name = "optA"
        Me.optA.Size = New System.Drawing.Size(62, 24)
        Me.optA.TabIndex = 0
        Me.optA.TabStop = True
        Me.optA.Text = " กะ A"
        Me.optA.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(271, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "%"
        '
        'txtErr2
        '
        Me.txtErr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtErr2.Location = New System.Drawing.Point(209, 47)
        Me.txtErr2.Name = "txtErr2"
        Me.txtErr2.Size = New System.Drawing.Size(58, 24)
        Me.txtErr2.TabIndex = 32
        Me.txtErr2.Text = "10"
        Me.txtErr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCutErr2
        '
        Me.chkCutErr2.AutoSize = True
        Me.chkCutErr2.Checked = True
        Me.chkCutErr2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCutErr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCutErr2.Location = New System.Drawing.Point(23, 48)
        Me.chkCutErr2.Name = "chkCutErr2"
        Me.chkCutErr2.Size = New System.Drawing.Size(135, 22)
        Me.chkCutErr2.TabIndex = 31
        Me.chkCutErr2.Text = "ตัดข้อมูล Error >="
        Me.chkCutErr2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(164, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 21)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Std. +"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(164, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 21)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Std. -"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(296, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 21)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "จำนวนข้อมูลที่ตัดออก"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Yellow
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(296, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 21)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "จำนวนข้อมูลที่ตัดออก"
        '
        'lbErrLower
        '
        Me.lbErrLower.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbErrLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbErrLower.Location = New System.Drawing.Point(435, 20)
        Me.lbErrLower.Name = "lbErrLower"
        Me.lbErrLower.Size = New System.Drawing.Size(70, 21)
        Me.lbErrLower.TabIndex = 39
        Me.lbErrLower.Text = "0"
        Me.lbErrLower.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbErrUpper
        '
        Me.lbErrUpper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbErrUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbErrUpper.Location = New System.Drawing.Point(435, 49)
        Me.lbErrUpper.Name = "lbErrUpper"
        Me.lbErrUpper.Size = New System.Drawing.Size(70, 21)
        Me.lbErrUpper.TabIndex = 38
        Me.lbErrUpper.Text = "0"
        Me.lbErrUpper.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Yellow
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(293, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "จำนวนข้อมูลที่แสดง"
        '
        'lbQtyN_Total
        '
        Me.lbQtyN_Total.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbQtyN_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQtyN_Total.ForeColor = System.Drawing.Color.White
        Me.lbQtyN_Total.Location = New System.Drawing.Point(435, 108)
        Me.lbQtyN_Total.Name = "lbQtyN_Total"
        Me.lbQtyN_Total.Size = New System.Drawing.Size(70, 21)
        Me.lbQtyN_Total.TabIndex = 41
        Me.lbQtyN_Total.Text = "0"
        Me.lbQtyN_Total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Yellow
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(293, 108)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 21)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "จำนวนข้อมูลทุั้งหมด"
        '
        'lbNTotal
        '
        Me.lbNTotal.BackColor = System.Drawing.Color.White
        Me.lbNTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNTotal.ForeColor = System.Drawing.Color.Black
        Me.lbNTotal.Location = New System.Drawing.Point(209, 78)
        Me.lbNTotal.Name = "lbNTotal"
        Me.lbNTotal.Size = New System.Drawing.Size(70, 21)
        Me.lbNTotal.TabIndex = 43
        Me.lbNTotal.Text = "0"
        Me.lbNTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Yellow
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(68, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 21)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "ข้อมูลจริงทั้งหมด"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "จำนวนข้อมูลหลุด Lower"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Brown
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 21)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "จำนวนข้อมูลหลุด Upper"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "จำนวนข้อมูลเข้า Std."
        '
        'lbQtyUper
        '
        Me.lbQtyUper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbQtyUper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQtyUper.Location = New System.Drawing.Point(180, 58)
        Me.lbQtyUper.Name = "lbQtyUper"
        Me.lbQtyUper.Size = New System.Drawing.Size(70, 21)
        Me.lbQtyUper.TabIndex = 49
        Me.lbQtyUper.Text = "0"
        Me.lbQtyUper.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbQtyLower
        '
        Me.lbQtyLower.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbQtyLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQtyLower.Location = New System.Drawing.Point(180, 88)
        Me.lbQtyLower.Name = "lbQtyLower"
        Me.lbQtyLower.Size = New System.Drawing.Size(70, 21)
        Me.lbQtyLower.TabIndex = 48
        Me.lbQtyLower.Text = "0"
        Me.lbQtyLower.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbQtyStd
        '
        Me.lbQtyStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbQtyStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQtyStd.ForeColor = System.Drawing.Color.White
        Me.lbQtyStd.Location = New System.Drawing.Point(180, 117)
        Me.lbQtyStd.Name = "lbQtyStd"
        Me.lbQtyStd.Size = New System.Drawing.Size(70, 21)
        Me.lbQtyStd.TabIndex = 47
        Me.lbQtyStd.Text = "0"
        Me.lbQtyStd.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbLowUpperTotal
        '
        Me.lbLowUpperTotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbLowUpperTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLowUpperTotal.ForeColor = System.Drawing.Color.White
        Me.lbLowUpperTotal.Location = New System.Drawing.Point(180, 146)
        Me.lbLowUpperTotal.Name = "lbLowUpperTotal"
        Me.lbLowUpperTotal.Size = New System.Drawing.Size(70, 21)
        Me.lbLowUpperTotal.TabIndex = 51
        Me.lbLowUpperTotal.Text = "0"
        Me.lbLowUpperTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(155, 21)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "จำนวนข้อมูลทั้งหมด"
        '
        'lbTotal_Retio
        '
        Me.lbTotal_Retio.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbTotal_Retio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal_Retio.ForeColor = System.Drawing.Color.White
        Me.lbTotal_Retio.Location = New System.Drawing.Point(260, 146)
        Me.lbTotal_Retio.Name = "lbTotal_Retio"
        Me.lbTotal_Retio.Size = New System.Drawing.Size(70, 21)
        Me.lbTotal_Retio.TabIndex = 55
        Me.lbTotal_Retio.Text = "0"
        Me.lbTotal_Retio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbUpper_Retio
        '
        Me.lbUpper_Retio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbUpper_Retio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbUpper_Retio.Location = New System.Drawing.Point(260, 58)
        Me.lbUpper_Retio.Name = "lbUpper_Retio"
        Me.lbUpper_Retio.Size = New System.Drawing.Size(70, 21)
        Me.lbUpper_Retio.TabIndex = 54
        Me.lbUpper_Retio.Text = "0"
        Me.lbUpper_Retio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbLower_Retio
        '
        Me.lbLower_Retio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbLower_Retio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLower_Retio.Location = New System.Drawing.Point(260, 88)
        Me.lbLower_Retio.Name = "lbLower_Retio"
        Me.lbLower_Retio.Size = New System.Drawing.Size(70, 21)
        Me.lbLower_Retio.TabIndex = 53
        Me.lbLower_Retio.Text = "0"
        Me.lbLower_Retio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbStd_Retio
        '
        Me.lbStd_Retio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbStd_Retio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_Retio.ForeColor = System.Drawing.Color.White
        Me.lbStd_Retio.Location = New System.Drawing.Point(260, 117)
        Me.lbStd_Retio.Name = "lbStd_Retio"
        Me.lbStd_Retio.Size = New System.Drawing.Size(70, 21)
        Me.lbStd_Retio.TabIndex = 52
        Me.lbStd_Retio.Text = "0"
        Me.lbStd_Retio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(336, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 21)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "%"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(336, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 21)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "%"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(336, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 21)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "%"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(874, 473)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(529, 254)
        Me.TabControl2.TabIndex = 59
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cmbExit)
        Me.TabPage4.Controls.Add(Me.cmbRun)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.txtDate02)
        Me.TabPage4.Controls.Add(Me.txtDate01)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.txtDocNo)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.cmbPrint)
        Me.TabPage4.Controls.Add(Me.optSection)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(521, 228)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtErr2)
        Me.TabPage5.Controls.Add(Me.txtErr1)
        Me.TabPage5.Controls.Add(Me.lbNTotal)
        Me.TabPage5.Controls.Add(Me.lbErrLower)
        Me.TabPage5.Controls.Add(Me.chkCutErr1)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.lbQtyN)
        Me.TabPage5.Controls.Add(Me.chkCutErr2)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.lbErrUpper)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.lbQtyN_Total)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(521, 186)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtStkName)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtUplow)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbTotal_Retio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbUpper_Retio)
        Me.GroupBox2.Controls.Add(Me.lbQtyStd)
        Me.GroupBox2.Controls.Add(Me.lbLower_Retio)
        Me.GroupBox2.Controls.Add(Me.lbQtyLower)
        Me.GroupBox2.Controls.Add(Me.lbStd_Retio)
        Me.GroupBox2.Controls.Add(Me.lbQtyUper)
        Me.GroupBox2.Controls.Add(Me.lbLowUpperTotal)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 493)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 234)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(371, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 21)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "0"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(371, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 21)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "0"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(371, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 21)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "0"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 789)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmBegin"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.chtUpperLow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.chtWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.optSection.ResumeLayout(False)
        Me.optSection.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvData As ListView
    Friend WithEvents cmbRun As Button
    Friend WithEvents txtDate02 As DateTimePicker
    Friend WithEvents txtDate01 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbExit As Button
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents optS_1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optS_5 As RadioButton
    Friend WithEvents optS_4 As RadioButton
    Friend WithEvents optS_3 As RadioButton
    Friend WithEvents optS_2 As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtStkName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkCutErr1 As CheckBox
    Friend WithEvents cmbPrint As Button
    Friend WithEvents txtErr1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUplow As TextBox
    Friend WithEvents lbQtyN As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents optSection As GroupBox
    Friend WithEvents optB As RadioButton
    Friend WithEvents optA As RadioButton
    Friend WithEvents chtUpperLow As DataVisualization.Charting.Chart
    Friend WithEvents Label11 As Label
    Friend WithEvents txtErr2 As TextBox
    Friend WithEvents chkCutErr2 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbErrLower As Label
    Friend WithEvents lbErrUpper As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbQtyN_Total As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbNTotal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents chkSection As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbQtyUper As Label
    Friend WithEvents lbQtyLower As Label
    Friend WithEvents lbQtyStd As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents chtWeight As DataVisualization.Charting.Chart
    Friend WithEvents lbLowUpperTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbTotal_Retio As Label
    Friend WithEvents lbUpper_Retio As Label
    Friend WithEvents lbLower_Retio As Label
    Friend WithEvents lbStd_Retio As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
