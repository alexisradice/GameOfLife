<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.table = New System.Windows.Forms.TableLayoutPanel()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TrackBar1 = New System.Windows.Forms.TrackBar()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'table
		'
		Me.table.ColumnCount = 2
		Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.table.Location = New System.Drawing.Point(12, 40)
		Me.table.Name = "table"
		Me.table.RowCount = 2
		Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.table.Size = New System.Drawing.Size(900, 900)
		Me.table.TabIndex = 0
		'
		'Timer1
		'
		Me.Timer1.Interval = 1000
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 951)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 37)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Start"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(93, 951)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 37)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Stop"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(207, 953)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 37)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Delete"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(776, 953)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(136, 37)
		Me.Button4.TabIndex = 4
		Me.Button4.Text = "Change number of boxes"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Red
		Me.Label1.Location = New System.Drawing.Point(174, 965)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(27, 13)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "OFF"
		'
		'TrackBar1
		'
		Me.TrackBar1.Location = New System.Drawing.Point(566, 951)
		Me.TrackBar1.Maximum = 1000
		Me.TrackBar1.Minimum = 1
		Me.TrackBar1.Name = "TrackBar1"
		Me.TrackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TrackBar1.Size = New System.Drawing.Size(204, 45)
		Me.TrackBar1.TabIndex = 6
		Me.TrackBar1.Value = 1000
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(522, 956)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(44, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Speed :"
		'
		'ComboBox1
		'
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Canon", "Oscillator"})
		Me.ComboBox1.Location = New System.Drawing.Point(382, 970)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 8
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(529, 970)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(31, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "1000"
		'
		'Button5
		'
		Me.Button5.Enabled = False
		Me.Button5.Location = New System.Drawing.Point(405, 946)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 23)
		Me.Button5.TabIndex = 10
		Me.Button5.Text = "Validate"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(288, 953)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(75, 37)
		Me.Button6.TabIndex = 11
		Me.Button6.Text = "Remove lines"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(438, 16)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(80, 13)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "To draw press :"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(518, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(51, 13)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "Nothing"
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(352, 11)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(85, 23)
		Me.Button7.TabIndex = 14
		Me.Button7.Text = "Select key"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Timer2
		'
		Me.Timer2.Interval = 10
		'
		'Timer3
		'
		Me.Timer3.Interval = 75
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Red
		Me.Label6.Location = New System.Drawing.Point(324, 16)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(27, 13)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "OFF"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(283, 15)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(40, 17)
		Me.CheckBox1.TabIndex = 16
		Me.CheckBox1.Text = "Ok"
		Me.CheckBox1.UseVisualStyleBackColor = True
		Me.CheckBox1.Visible = False
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
		Me.GroupBox1.Controls.Add(Me.GroupBox5)
		Me.GroupBox1.Controls.Add(Me.GroupBox4)
		Me.GroupBox1.Controls.Add(Me.GroupBox3)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Location = New System.Drawing.Point(915, 71)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(137, 216)
		Me.GroupBox1.TabIndex = 17
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Statistics"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.Label10)
		Me.GroupBox5.Location = New System.Drawing.Point(6, 169)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(126, 44)
		Me.GroupBox5.TabIndex = 20
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Number of White Cells"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(22, 21)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(13, 13)
		Me.Label10.TabIndex = 0
		Me.Label10.Text = "0"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label9)
		Me.GroupBox4.Location = New System.Drawing.Point(6, 119)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(126, 44)
		Me.GroupBox4.TabIndex = 19
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Total number of cells"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(20, 22)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(13, 13)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "0"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Location = New System.Drawing.Point(6, 69)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(126, 44)
		Me.GroupBox3.TabIndex = 19
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Population"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(20, 21)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(13, 13)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "0"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(126, 44)
		Me.GroupBox2.TabIndex = 18
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Generations"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(19, 20)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(13, 13)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "0"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Black
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Lime
		Me.Label11.Location = New System.Drawing.Point(46, -2)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(71, 29)
		Me.Label11.TabIndex = 18
		Me.Label11.Text = "0.000"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Black
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.Label11)
		Me.Panel1.Location = New System.Drawing.Point(930, 28)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(113, 27)
		Me.Panel1.TabIndex = 19
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1055, 994)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Button7)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TrackBar1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.table)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.Name = "Form2"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Game Of Life"
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents table As TableLayoutPanel
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents TrackBar1 As TrackBar
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button7 As Button
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Timer3 As Timer
	Friend WithEvents Label6 As Label
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents Label10 As Label
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents Label9 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents Label8 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Panel1 As Panel
End Class
