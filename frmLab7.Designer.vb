<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมควบคุม ListBox-ComboBox"
        '
        'lstAdd
        '
        Me.lstAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.ItemHeight = 16
        Me.lstAdd.Location = New System.Drawing.Point(29, 65)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(164, 244)
        Me.lstAdd.TabIndex = 1
        '
        'cboOutput
        '
        Me.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(280, 65)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(121, 24)
        Me.cboOutput.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(55, 349)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 36)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(181, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(300, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(42, 391)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(100, 22)
        Me.txtAdd.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.LightSalmon
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.Location = New System.Drawing.Point(273, 388)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(128, 23)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = " "
        '
        'btnMove
        '
        Me.btnMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMove.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMove.Location = New System.Drawing.Point(199, 125)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(41, 28)
        Me.btnMove.TabIndex = 8
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveAll
        '
        Me.btnMoveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMoveAll.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnMoveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMoveAll.Location = New System.Drawing.Point(199, 159)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(41, 28)
        Me.btnMoveAll.TabIndex = 9
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBackAll.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBackAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBackAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(199, 227)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(41, 28)
        Me.btnBackAll.TabIndex = 10
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(199, 193)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(41, 28)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmLab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(446, 461)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab7"
        Me.Text = "frmLab7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstAdd As ListBox
    Friend WithEvents cboOutput As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnMove As Button
    Friend WithEvents btnMoveAll As Button
    Friend WithEvents btnBackAll As Button
    Friend WithEvents btnBack As Button
End Class
