Public Class Form3
	Public config As Config

	Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		config.toucheDessin = e.KeyCode                     'choix de la touche pour le mode dessin
		Label1.Text = config.toucheDessin.ToString
	End Sub
End Class