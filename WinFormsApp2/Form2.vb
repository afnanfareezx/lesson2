Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strKelas(5, 3) As String
        strKelas(0, 0) = "DDT1A"
        strKelas(0, 1) = "DDT1B"
        strKelas(1, 0) = "DDT2A"
        strKelas(1, 1) = "DDT2B"
        strKelas(1, 2) = "DDT2C"

        Label1.Text = strKelas(0, 0)
    End Sub
End Class