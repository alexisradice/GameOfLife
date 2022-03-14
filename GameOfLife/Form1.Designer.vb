<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
		Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
		Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
		Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(10, 40)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(94, 41)
		Me.Button1.TabIndex = 7
		Me.Button1.Text = "Validate"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(242, 26)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Select the number of rows and columns you want." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Select a number between 1 and 99" &
	":"
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(173, 40)
		Me.MaskedTextBox1.Mask = "99"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox1.Size = New System.Drawing.Size(267, 20)
		Me.MaskedTextBox1.TabIndex = 0
		Me.MaskedTextBox1.Text = "20"
		Me.MaskedTextBox1.ValidatingType = GetType(Integer)
		'
		'MaskedTextBox2
		'
		Me.MaskedTextBox2.Enabled = False
		Me.MaskedTextBox2.Location = New System.Drawing.Point(277, 115)
		Me.MaskedTextBox2.Mask = "99"
		Me.MaskedTextBox2.Name = "MaskedTextBox2"
		Me.MaskedTextBox2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox2.Size = New System.Drawing.Size(33, 20)
		Me.MaskedTextBox2.TabIndex = 3
		Me.MaskedTextBox2.Text = "2"
		Me.MaskedTextBox2.ValidatingType = GetType(Integer)
		'
		'MaskedTextBox3
		'
		Me.MaskedTextBox3.Enabled = False
		Me.MaskedTextBox3.Location = New System.Drawing.Point(335, 115)
		Me.MaskedTextBox3.Mask = "99"
		Me.MaskedTextBox3.Name = "MaskedTextBox3"
		Me.MaskedTextBox3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox3.Size = New System.Drawing.Size(33, 20)
		Me.MaskedTextBox3.TabIndex = 4
		Me.MaskedTextBox3.Text = "3"
		Me.MaskedTextBox3.ValidatingType = GetType(Integer)
		'
		'MaskedTextBox4
		'
		Me.MaskedTextBox4.Enabled = False
		Me.MaskedTextBox4.Location = New System.Drawing.Point(277, 144)
		Me.MaskedTextBox4.Mask = "99"
		Me.MaskedTextBox4.Name = "MaskedTextBox4"
		Me.MaskedTextBox4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox4.Size = New System.Drawing.Size(33, 20)
		Me.MaskedTextBox4.TabIndex = 5
		Me.MaskedTextBox4.Text = "3"
		Me.MaskedTextBox4.ValidatingType = GetType(Integer)
		'
		'MaskedTextBox5
		'
		Me.MaskedTextBox5.Enabled = False
		Me.MaskedTextBox5.Location = New System.Drawing.Point(335, 144)
		Me.MaskedTextBox5.Mask = "99"
		Me.MaskedTextBox5.Name = "MaskedTextBox5"
		Me.MaskedTextBox5.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox5.Size = New System.Drawing.Size(33, 20)
		Me.MaskedTextBox5.TabIndex = 6
		Me.MaskedTextBox5.Text = "3"
		Me.MaskedTextBox5.ValidatingType = GetType(Integer)
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(32, 118)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(239, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "A dead cell comes to life when it is surrounded by"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(42, 147)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(229, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "A living cell stays alive when it is surrounded by"
		'
		'MaskedTextBox6
		'
		Me.MaskedTextBox6.Location = New System.Drawing.Point(173, 66)
		Me.MaskedTextBox6.Mask = "99"
		Me.MaskedTextBox6.Name = "MaskedTextBox6"
		Me.MaskedTextBox6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
		Me.MaskedTextBox6.Size = New System.Drawing.Size(267, 20)
		Me.MaskedTextBox6.TabIndex = 1
		Me.MaskedTextBox6.Text = "20"
		Me.MaskedTextBox6.ValidatingType = GetType(Integer)
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(110, 69)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(53, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Columns: "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(126, 43)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 13)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Lines:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(5, 82)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(79, 25)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "Rules :"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(69, 82)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(384, 25)
		Me.Label7.TabIndex = 16
		Me.Label7.Text = "_______________________________"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(316, 118)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(16, 13)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "to"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(316, 147)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(16, 13)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "to"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(374, 118)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(31, 13)
		Me.Label10.TabIndex = 19
		Me.Label10.Text = "cells."
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(374, 147)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(31, 13)
		Me.Label11.TabIndex = 20
		Me.Label11.Text = "cells."
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(448, 172)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.MaskedTextBox6)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MaskedTextBox5)
		Me.Controls.Add(Me.MaskedTextBox4)
		Me.Controls.Add(Me.MaskedTextBox3)
		Me.Controls.Add(Me.MaskedTextBox2)
		Me.Controls.Add(Me.MaskedTextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label7)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.Text = "Game Of Life"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents MaskedTextBox1 As MaskedTextBox
	Friend WithEvents MaskedTextBox2 As MaskedTextBox
	Friend WithEvents MaskedTextBox3 As MaskedTextBox
	Friend WithEvents MaskedTextBox4 As MaskedTextBox
	Friend WithEvents MaskedTextBox5 As MaskedTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents MaskedTextBox6 As MaskedTextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
End Class
