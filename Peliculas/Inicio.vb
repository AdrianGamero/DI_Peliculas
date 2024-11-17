Public Class Inicio
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Formulario.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Formulario.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub
End Class