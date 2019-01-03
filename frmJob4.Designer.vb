<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAlllncome = New System.Windows.Forms.Label()
        Me.lblAlllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี (อย่างหยาบ)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "วันที่"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(14, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เงินเดือน"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(14, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ยอดขายทั้งปี"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(14, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เงินเดือนทั้งปี"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(14, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "รับเงินโบนัส"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(14, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "รวมรายได้"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(14, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "หักค่าลดหย่อน"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(14, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ภาษีที่ต้องชำระ"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(164, 92)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(145, 26)
        Me.txtSalary.TabIndex = 9
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Location = New System.Drawing.Point(164, 54)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(185, 23)
        Me.lblDate.TabIndex = 10
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSale
        '
        Me.txtSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSale.Location = New System.Drawing.Point(164, 130)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(145, 26)
        Me.txtSale.TabIndex = 11
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblYearSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYearSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblYearSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblYearSalary.Location = New System.Drawing.Point(164, 171)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(145, 23)
        Me.lblYearSalary.TabIndex = 12
        Me.lblYearSalary.Text = "                        "
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBonus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBonus.Location = New System.Drawing.Point(164, 208)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(145, 23)
        Me.lblBonus.TabIndex = 13
        Me.lblBonus.Text = "                        "
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAlllncome
        '
        Me.lblAlllncome.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblAlllncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlllncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAlllncome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAlllncome.Location = New System.Drawing.Point(164, 247)
        Me.lblAlllncome.Name = "lblAlllncome"
        Me.lblAlllncome.Size = New System.Drawing.Size(145, 23)
        Me.lblAlllncome.TabIndex = 14
        Me.lblAlllncome.Text = "                        "
        Me.lblAlllncome.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAlllowance
        '
        Me.lblAlllowance.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblAlllowance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAlllowance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAlllowance.Location = New System.Drawing.Point(164, 286)
        Me.lblAlllowance.Name = "lblAlllowance"
        Me.lblAlllowance.Size = New System.Drawing.Size(145, 23)
        Me.lblAlllowance.TabIndex = 15
        Me.lblAlllowance.Text = "                        "
        Me.lblAlllowance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTax.Location = New System.Drawing.Point(164, 324)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(145, 23)
        Me.lblTax.TabIndex = 16
        Me.lblTax.Text = "                        "
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(355, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 122)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Location = New System.Drawing.Point(15, 25)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(162, 24)
        Me.radShortDate.TabIndex = 0
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Location = New System.Drawing.Point(15, 55)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(180, 24)
        Me.radGenDate.TabIndex = 1
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Location = New System.Drawing.Point(15, 85)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(159, 24)
        Me.radLongDate.TabIndex = 2
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'btnCalTax
        '
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(370, 232)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(180, 99)
        Me.btnCalTax.TabIndex = 18
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(591, 420)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAlllowance)
        Me.Controls.Add(Me.lblAlllncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "frmPractice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSale As TextBox
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblAlllncome As Label
    Friend WithEvents lblAlllowance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radShortDate As RadioButton
    Friend WithEvents btnCalTax As Button
    Friend WithEvents Timer1 As Timer
End Class
