Public Class Form_Inicio

    Private Sub Form_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Form_CamaraCom.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Form_Simple.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Try
            '  FormConfig.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            FormConfig.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Microscopio_Click(sender As Object, e As EventArgs) Handles Button_Microscopio.Click
        Try
            Form_Microscopio.Show()
        Catch ex As Exception

        End Try
    End Sub

End Class