<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInput.Location = New System.Drawing.Point(119, 49)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(279, 75)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.AutoSize = True
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUp.Location = New System.Drawing.Point(398, 47)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(62, 39)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.AutoSize = True
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDown.Location = New System.Drawing.Point(398, 84)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(62, 40)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(404, 148)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(56, 24)
        Me.cboSize.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.AutoSize = True
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFSky.Location = New System.Drawing.Point(165, 51)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(30, 24)
        Me.lblFSky.TabIndex = 9
        Me.lblFSky.Text = "    "
        '
        'lblFWhite
        '
        Me.lblFWhite.AutoSize = True
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFWhite.Location = New System.Drawing.Point(133, 51)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(30, 24)
        Me.lblFWhite.TabIndex = 8
        Me.lblFWhite.Text = "    "
        '
        'lblFBrown
        '
        Me.lblFBrown.AutoSize = True
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFBrown.Location = New System.Drawing.Point(101, 50)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(30, 24)
        Me.lblFBrown.TabIndex = 7
        Me.lblFBrown.Text = "    "
        '
        'lblFYellow
        '
        Me.lblFYellow.AutoSize = True
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFYellow.Location = New System.Drawing.Point(70, 51)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(30, 24)
        Me.lblFYellow.TabIndex = 6
        Me.lblFYellow.Text = "    "
        '
        'lblFOrange
        '
        Me.lblFOrange.AutoSize = True
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFOrange.Location = New System.Drawing.Point(39, 50)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(30, 24)
        Me.lblFOrange.TabIndex = 5
        Me.lblFOrange.Text = "    "
        '
        'lblFBlack
        '
        Me.lblFBlack.AutoSize = True
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFBlack.Location = New System.Drawing.Point(164, 25)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(30, 24)
        Me.lblFBlack.TabIndex = 4
        Me.lblFBlack.Text = "    "
        '
        'lblFViolet
        '
        Me.lblFViolet.AutoSize = True
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFViolet.Location = New System.Drawing.Point(133, 25)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(30, 24)
        Me.lblFViolet.TabIndex = 3
        Me.lblFViolet.Text = "    "
        '
        'lblFGreen
        '
        Me.lblFGreen.AutoSize = True
        Me.lblFGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFGreen.Location = New System.Drawing.Point(102, 25)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(30, 24)
        Me.lblFGreen.TabIndex = 2
        Me.lblFGreen.Text = "    "
        '
        'lblFBlue
        '
        Me.lblFBlue.AutoSize = True
        Me.lblFBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFBlue.Location = New System.Drawing.Point(70, 25)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(30, 24)
        Me.lblFBlue.TabIndex = 1
        Me.lblFBlue.Text = "    "
        '
        'lblFRed
        '
        Me.lblFRed.AutoSize = True
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFRed.Location = New System.Drawing.Point(39, 25)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(30, 24)
        Me.lblFRed.TabIndex = 0
        Me.lblFRed.Text = "    "
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(250, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgClolr"
        '
        'lblBSky
        '
        Me.lblBSky.AutoSize = True
        Me.lblBSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBSky.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBSky.Location = New System.Drawing.Point(163, 51)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(30, 24)
        Me.lblBSky.TabIndex = 19
        Me.lblBSky.Text = "    "
        '
        'lblBWhite
        '
        Me.lblBWhite.AutoSize = True
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBWhite.Location = New System.Drawing.Point(131, 51)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(30, 24)
        Me.lblBWhite.TabIndex = 18
        Me.lblBWhite.Text = "    "
        '
        'lblBBrown
        '
        Me.lblBBrown.AutoSize = True
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBBrown.Location = New System.Drawing.Point(99, 50)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(30, 24)
        Me.lblBBrown.TabIndex = 17
        Me.lblBBrown.Text = "    "
        '
        'lblBYellow
        '
        Me.lblBYellow.AutoSize = True
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBYellow.Location = New System.Drawing.Point(68, 51)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(30, 24)
        Me.lblBYellow.TabIndex = 16
        Me.lblBYellow.Text = "    "
        '
        'lblBOrange
        '
        Me.lblBOrange.AutoSize = True
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBOrange.Location = New System.Drawing.Point(37, 50)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(30, 24)
        Me.lblBOrange.TabIndex = 15
        Me.lblBOrange.Text = "    "
        '
        'lblBBlack
        '
        Me.lblBBlack.AutoSize = True
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBBlack.Location = New System.Drawing.Point(162, 25)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(30, 24)
        Me.lblBBlack.TabIndex = 14
        Me.lblBBlack.Text = "    "
        '
        'lblBViolet
        '
        Me.lblBViolet.AutoSize = True
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBViolet.Location = New System.Drawing.Point(131, 25)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(30, 24)
        Me.lblBViolet.TabIndex = 13
        Me.lblBViolet.Text = "    "
        '
        'lblBGreen
        '
        Me.lblBGreen.AutoSize = True
        Me.lblBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBGreen.Location = New System.Drawing.Point(100, 25)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(30, 24)
        Me.lblBGreen.TabIndex = 12
        Me.lblBGreen.Text = "    "
        '
        'lblBBlue
        '
        Me.lblBBlue.AutoSize = True
        Me.lblBBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBBlue.Location = New System.Drawing.Point(68, 25)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(30, 24)
        Me.lblBBlue.TabIndex = 11
        Me.lblBBlue.Text = "    "
        '
        'lblBRed
        '
        Me.lblBRed.AutoSize = True
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblBRed.Location = New System.Drawing.Point(37, 25)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(30, 24)
        Me.lblBRed.TabIndex = 10
        Me.lblBRed.Text = "    "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ขนาดฟอนด์"
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 372)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmLab3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFRed As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
