Public Class Form2

	Public NB_TABLE As Integer = 100
	Public NB_TABLE_COL As Integer = 100
	Public NB_TABLE_ROW As Integer = 100
	Public all(NB_TABLE_COL - 1, NB_TABLE_ROW - 1) As Panel

	Dim compte As Integer = 0
	Private arrBlack As New ArrayList
	Private arrWhite As New ArrayList
	Private panelVie As Panel
	Dim compteBlack As Integer = 0              'toutes les variables
	Dim compteWhite As Integer = 0

	Dim ok As Boolean = True

    Private dessin As Boolean = False
	Private led As Boolean = False

	Private nbGenerations As Integer
	Dim Ms As Integer
	Dim Sec As Integer

	Public minMort As Integer
	Public maxMort As Integer
	Public minNaissance As Integer
	Public maxNaissance As Integer


	Public config As Config


    Sub Tableau()

		table.ColumnCount = NB_TABLE_COL
		table.RowCount = NB_TABLE_ROW
		Dim i As Integer = 0
		For i = 0 To NB_TABLE_ROW - 1
																				'Redimensionnement du tablelayoutpanel
			table.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))

		Next

		For i = 0 To NB_TABLE_COL - 1

			table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))

		Next


		Dim y As Integer

		For i = 0 To NB_TABLE_COL - 1
			For y = 0 To NB_TABLE_ROW - 1
				Dim panelVie As New Panel
				'buttonVie.Text = "B" & i
				'buttonVie.ForeColor = Color.Red
				panelVie.BackColor = Color.White
				panelVie.Height = 900
				panelVie.Width = 900
				panelVie.Margin = New Padding(0)                                        'ajout des panels dans le tablelayoutpanel

				all(i, y) = panelVie
				table.Controls.Add(all(i, y))

				'buttonVie.FlatStyle = FlatStyle.Flat
				panelVie.BorderStyle = BorderStyle.FixedSingle

				AddHandler panelVie.MouseClick, AddressOf blackWhite

			Next
		Next

		'verifVie()

	End Sub

    Sub blackWhite(sender As Panel, e As EventArgs)
		If (sender.BackColor = Color.White) Then                        'Chanagement des couleurs des cases lorsque qu'on appui sur un panel
			sender.BackColor = Color.Black
		ElseIf (sender.BackColor = Color.Black) Then
			sender.BackColor = Color.White

        End If

    End Sub

    Sub verifVie()

		For Each panelVie In table.Controls
			AddHandler panelVie.MouseEnter, AddressOf blackWhite
			If led = True Then
				Label6.BackColor = Color.Green                          'Changement de couleur et texte du bouton ON/oFF
				Label6.Text = "ON"
			Else
				Label6.BackColor = Color.Red
				Label6.Text = "OFF"
			End If
		Next

	End Sub

	Sub change(x As Integer, y As Integer)


		If ((x > 0) And (x < NB_TABLE_COL - 1) And (y > 0) And (y < NB_TABLE_ROW - 1)) Then

			If (all(x, y).BackColor = Color.Black) Then                                             'Compteur des cases vivantes autour d'une case
				compte = compte + 1
			End If

			If (all(x - 1, y + 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x + 1, y - 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x + 1, y + 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x - 1, y - 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x - 1, y).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x, y - 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x + 1, y).BackColor = Color.Black) Then
					compte = compte + 1
				End If

				If (all(x, y + 1).BackColor = Color.Black) Then
					compte = compte + 1
				End If
			End If


		If compte = 3 Then
			arrBlack.Add(all(x, y))
			compteBlack = compteBlack + 1

		ElseIf compte = 4 And all(x, y).BackColor = Color.Black Then                'Règle du jeu de la vie
			arrBlack.Add(all(x, y))
			compteBlack = compteBlack + 1

		ElseIf compte >= maxMort Then
			arrWhite.Add(all(x, y))
			compteWhite = compteWhite + 1

		ElseIf compte <= minMort Then
			arrWhite.Add(all(x, y))
			compteWhite = compteWhite + 1


		End If


	End Sub

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tableau()
		Timer3.Start()                                                                              'Lance timer pour le temps et statistiques
		Label9.Text = NB_TABLE_COL * NB_TABLE_ROW
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

		nbGenerations += 1
		Label7.Text = nbGenerations

		arrBlack.Clear()
		arrWhite.Clear()
		For i As Integer = 0 To NB_TABLE_COL - 1
			For y As Integer = 0 To NB_TABLE_ROW - 1                        'Le timer qui permet de faire fonctionner le jeu de la vie qui test chauqe case du tablelayoutpanel
				change(i, y)
				compte = 0
			Next
		Next


		For Each buttonVie In arrBlack
			buttonVie.BackColor = Color.Black

		Next

		For Each buttonVie In arrWhite
			buttonVie.BackColor = Color.White
		Next

		Label8.Text = arrBlack.Count
		Label10.Text = arrWhite.Count

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Timer1.Start()
		Timer2.Start()
		Label1.Text = "ON"
		Label1.BackColor = Color.Green                                              'Lance le jeu 

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Timer1.Stop()
		Timer2.Stop()                                                                               'Stop le jeu
		Label1.Text = "OFF"
		Label1.BackColor = Color.Red
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		For i As Integer = 0 To NB_TABLE_COL - 1
			For y As Integer = 0 To NB_TABLE_ROW - 1
				all(i, y).BackColor = Color.White                                               'Renitialise le jeu
			Next
		Next
		nbGenerations = 0
		Ms = 0
		Sec = 0
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Form1.Show()
		Me.Close()
	End Sub

	Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
		Timer1.Interval = TrackBar1.Value
		Label3.Text = TrackBar1.Value
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

		If ComboBox1.SelectedIndex = 1 Then
			Form1.Oscillateur()
			Me.Close()                                      'Faire apparaitre un shéma déjà réalisé
		End If

		If ComboBox1.SelectedIndex = 0 Then
			Form1.Canon()
			Me.Close()
		End If

		If ComboBox1.SelectedIndex = 2 Then
			Form1.Vaisseau()
			Me.Close()
		End If

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

		If ok = True Then
			For Each buttonVie In table.Controls
				'buttonVie.ForeColor = Color.White
				buttonVie.BorderStyle = BorderStyle.None                                                'Changer le borderstyle pour enlevr les lignes des cases

			Next
			ok = False
			Button6.Text = "Show lines"
		Else

			For Each buttonVie In table.Controls
                'buttonVie.ForeColor = Color.Black
                buttonVie.BorderStyle = BorderStyle.FixedSingle
            Next
			ok = True
			Button6.Text = "Remove lines"
		End If
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2 Or ComboBox1.SelectedIndex = 3 Then
			Button5.Enabled = True
		End If
	End Sub

	Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If config.toucheDessin = e.KeyCode Then
            dessin = True
			'Label4.Text = dessin.ToString																			'Activer le mode dessin
		End If

    End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		Dim f As New Form3
		f.config = config
		f.ShowDialog()

		Touche()
	End Sub

	Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

		Ms = Ms + 1
		If Ms = 58 Then
			Sec = Sec + 1                                                                       'Timer 2 pour afficher un coimpteur de temps 
			Ms = 0
		End If
		Label11.Text = Sec.ToString + "." + Ms.ToString

	End Sub

	Sub Touche()
		Label5.Text = config.toucheDessin.ToString
	End Sub

	Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If config.toucheDessin = e.KeyCode Then
            dessin = False
            'Label4.Text = dessin.ToString
        End If
    End Sub

	Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
		If dessin = True Then

			CheckBox1.Checked = True
			led = Not (led)
			verifVie()
		Else
			CheckBox1.Checked = False
		End If
	End Sub


	Private Sub table_MouseEnter(sender As Object, e As EventArgs) Handles table.MouseEnter
		'Label12.Text = table.GetColumn(table)
	End Sub
End Class