Public Class Form1

    Private Sub BtnPapar_Click(sender As Object, e As EventArgs) Handles BtnPapar.Click
        Dim strNamaHari(6) As String
        Dim strOutput As String
        strNamaHari(0) = "Ahadd"
        strNamaHari(1) = "Isninn"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        Array.Reverse(strNamaHari)
        For count = 0 To 6
            strOutput = strNamaHari(count)
            lstBox.Items.Add(strOutput)
        Next

    End Sub
End Class
