Public Class Form1

	Public config As New Config
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim f As New Form2
		f.config = config
		f.NB_TABLE_ROW = MaskedTextBox1.Text
		f.NB_TABLE_COL = MaskedTextBox6.Text
		f.NB_TABLE = MaskedTextBox1.Text                'Creer une nouvelle fenetre avec tout les parametres inclus

		f.minMort = MaskedTextBox2.Text
		f.maxMort = MaskedTextBox3.Text
		f.minNaissance = MaskedTextBox4.Text
		f.maxNaissance = MaskedTextBox5.Text

		If f.NB_TABLE_COL < 1 Or f.NB_TABLE_COL > 99 And f.NB_TABLE_ROW < 1 Or f.NB_TABLE_ROW > 99 Then
			MessageBox.Show("Le chiffre n'est pas valide", "Erreur")
		Else

			f.Show()
			'Me.Hide()

		End If
	End Sub

	Public Sub ControleTextBox(ByRef e As System.Windows.Forms.KeyPressEventArgs)

		Dim ch As String
		Dim chBack As String

		ch = e.KeyChar
		chBack = Asc(e.KeyChar)                         'Modification des textbox

		If Not Char.IsDigit(e.KeyChar) Then
			' Tous les caractères non numériques ne sont pas traités sur le TextBox.
			e.Handled = True
		End If

	End Sub

	Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
		ControleTextBox(e)
	End Sub

	Sub Oscillateur()

		Dim f As New Form2
		f.config = config
		f.NB_TABLE_COL = MaskedTextBox1.Text
		f.NB_TABLE_ROW = MaskedTextBox6.Text


		Form2.Close()
		f.NB_TABLE_COL = 15
		f.NB_TABLE_ROW = 15
		f.Show()

		f.all(3, 3).BackColor = Color.Black
		f.all(3, 4).BackColor = Color.Black
		f.all(3, 5).BackColor = Color.Black
		f.all(4, 5).BackColor = Color.Black
		f.all(3, 6).BackColor = Color.Black
		f.all(4, 6).BackColor = Color.Black
		f.all(3, 7).BackColor = Color.Black
		f.all(4, 7).BackColor = Color.Black
		f.all(3, 8).BackColor = Color.Black
		f.all(4, 8).BackColor = Color.Black
		f.all(3, 10).BackColor = Color.Black
		f.all(4, 10).BackColor = Color.Black
		f.all(3, 11).BackColor = Color.Black
		f.all(4, 11).BackColor = Color.Black
		f.all(5, 10).BackColor = Color.Black
		f.all(6, 10).BackColor = Color.Black        'forme d'oscillateur
		f.all(5, 11).BackColor = Color.Black
		f.all(6, 11).BackColor = Color.Black
		f.all(7, 10).BackColor = Color.Black
		f.all(8, 10).BackColor = Color.Black
		f.all(7, 11).BackColor = Color.Black
		f.all(8, 11).BackColor = Color.Black
		f.all(10, 10).BackColor = Color.Black
		f.all(10, 11).BackColor = Color.Black
		f.all(3, 6).BackColor = Color.Black
		f.all(4, 6).BackColor = Color.Black
		f.all(3, 7).BackColor = Color.Black
		f.all(4, 7).BackColor = Color.Black
		f.all(3, 8).BackColor = Color.Black
		f.all(4, 8).BackColor = Color.Black
		f.all(3, 10).BackColor = Color.Black
		f.all(4, 10).BackColor = Color.Black
		f.all(3, 11).BackColor = Color.Black
		f.all(4, 11).BackColor = Color.Black

		f.all(4, 3).BackColor = Color.Black
		f.all(4, 4).BackColor = Color.Black
		f.all(6, 3).BackColor = Color.Black
		f.all(6, 4).BackColor = Color.Black
		f.all(7, 3).BackColor = Color.Black
		f.all(7, 4).BackColor = Color.Black
		f.all(8, 3).BackColor = Color.Black
		f.all(8, 4).BackColor = Color.Black
		f.all(10, 3).BackColor = Color.Black
		f.all(10, 4).BackColor = Color.Black
		f.all(11, 3).BackColor = Color.Black
		f.all(11, 4).BackColor = Color.Black
		f.all(10, 6).BackColor = Color.Black
		f.all(11, 6).BackColor = Color.Black
		f.all(10, 7).BackColor = Color.Black
		f.all(10, 8).BackColor = Color.Black
		f.all(11, 7).BackColor = Color.Black
		f.all(11, 8).BackColor = Color.Black
		f.all(10, 9).BackColor = Color.Black
		f.all(11, 9).BackColor = Color.Black
		f.all(11, 10).BackColor = Color.Black
		f.all(11, 11).BackColor = Color.Black
		f.all(6, 3).BackColor = Color.Black
		f.all(6, 4).BackColor = Color.Black
		f.all(7, 3).BackColor = Color.Black
		f.all(7, 4).BackColor = Color.Black
		f.all(8, 3).BackColor = Color.Black
		f.all(8, 4).BackColor = Color.Black
		f.all(9, 3).BackColor = Color.Black
		f.all(9, 4).BackColor = Color.Black
		f.all(10, 3).BackColor = Color.Black
		f.all(10, 4).BackColor = Color.Black
		f.all(11, 3).BackColor = Color.Black
		f.all(11, 4).BackColor = Color.Black

	End Sub

	Sub Canon()

		Dim f As New Form2
		f.config = config
		f.NB_TABLE_COL = MaskedTextBox1.Text
		f.NB_TABLE_ROW = MaskedTextBox6.Text

		Form2.Close()
		f.NB_TABLE_COL = 70
		f.NB_TABLE_ROW = 70
		f.Show()

		f.all(9, 6).BackColor = Color.Black
		f.all(10, 6).BackColor = Color.Black
		f.all(9, 7).BackColor = Color.Black
		f.all(10, 7).BackColor = Color.Black
		f.all(9, 16).BackColor = Color.Black
		f.all(10, 16).BackColor = Color.Black
		f.all(11, 16).BackColor = Color.Black
		f.all(12, 17).BackColor = Color.Black
		f.all(8, 17).BackColor = Color.Black
		f.all(13, 18).BackColor = Color.Black
		f.all(7, 18).BackColor = Color.Black
		f.all(13, 19).BackColor = Color.Black
		f.all(7, 19).BackColor = Color.Black
		f.all(12, 21).BackColor = Color.Black           'Forme de canon
		f.all(8, 21).BackColor = Color.Black
		f.all(11, 22).BackColor = Color.Black
		f.all(9, 22).BackColor = Color.Black
		f.all(10, 22).BackColor = Color.Black
		f.all(10, 23).BackColor = Color.Black
		f.all(10, 20).BackColor = Color.Black
		f.all(9, 26).BackColor = Color.Black
		f.all(8, 26).BackColor = Color.Black
		f.all(7, 26).BackColor = Color.Black
		f.all(9, 27).BackColor = Color.Black
		f.all(8, 27).BackColor = Color.Black
		f.all(7, 27).BackColor = Color.Black
		f.all(10, 28).BackColor = Color.Black
		f.all(6, 28).BackColor = Color.Black
		f.all(10, 30).BackColor = Color.Black
		f.all(6, 30).BackColor = Color.Black
		f.all(11, 30).BackColor = Color.Black
		f.all(5, 30).BackColor = Color.Black
		f.all(8, 40).BackColor = Color.Black
		f.all(7, 40).BackColor = Color.Black
		f.all(8, 41).BackColor = Color.Black
		f.all(7, 41).BackColor = Color.Black
	End Sub

	Sub Vaisseau()

		Dim f As New Form2
		f.config = config
		f.NB_TABLE_COL = MaskedTextBox1.Text
		f.NB_TABLE_ROW = MaskedTextBox6.Text

		Form2.Close()
		f.NB_TABLE_COL = 70
		f.NB_TABLE_ROW = 70
		f.Show()

		f.all(68, 25).BackColor = Color.Black
		f.all(68, 29).BackColor = Color.Black
		f.all(68, 30).BackColor = Color.Black
		f.all(68, 42).BackColor = Color.Black
		f.all(68, 43).BackColor = Color.Black
		f.all(68, 47).BackColor = Color.Black

		f.all(67, 26).BackColor = Color.Black
		f.all(66, 26).BackColor = Color.Black
		f.all(65, 26).BackColor = Color.Black
		f.all(64, 26).BackColor = Color.Black
		f.all(63, 26).BackColor = Color.Black
		f.all(62, 26).BackColor = Color.Black
		f.all(62, 25).BackColor = Color.Black
		f.all(62, 24).BackColor = Color.Black
		f.all(63, 23).BackColor = Color.Black





		f.all(67, 29).BackColor = Color.Black
		f.all(67, 30).BackColor = Color.Black
		f.all(66, 29).BackColor = Color.Black
		f.all(7, 18).BackColor = Color.Black
		f.all(13, 19).BackColor = Color.Black
		f.all(7, 19).BackColor = Color.Black
		f.all(12, 21).BackColor = Color.Black           'Forme de vaisseau
		f.all(8, 21).BackColor = Color.Black
		f.all(11, 22).BackColor = Color.Black
		f.all(9, 22).BackColor = Color.Black
		f.all(10, 22).BackColor = Color.Black
		f.all(10, 23).BackColor = Color.Black
		f.all(10, 20).BackColor = Color.Black
		f.all(9, 26).BackColor = Color.Black
		f.all(8, 26).BackColor = Color.Black
		f.all(7, 26).BackColor = Color.Black
		f.all(9, 27).BackColor = Color.Black
		f.all(8, 27).BackColor = Color.Black
		f.all(7, 27).BackColor = Color.Black
		f.all(10, 28).BackColor = Color.Black
		f.all(6, 28).BackColor = Color.Black
		f.all(10, 30).BackColor = Color.Black
		f.all(6, 30).BackColor = Color.Black
		f.all(11, 30).BackColor = Color.Black
		f.all(5, 30).BackColor = Color.Black
		f.all(8, 40).BackColor = Color.Black
		f.all(7, 40).BackColor = Color.Black
		f.all(8, 41).BackColor = Color.Black
		f.all(7, 41).BackColor = Color.Black
	End Sub



	Private Sub MaskedTextBox6_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox6.TextChanged

		MaskedTextBox1.Text = MaskedTextBox6.Text                   'textbox qui prend la valeur d'une autre
	End Sub


	Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
		MaskedTextBox6.Text = MaskedTextBox1.Text               'textbox qui prend la valeur d'une autre

	End Sub

	Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected

	End Sub
End Class
