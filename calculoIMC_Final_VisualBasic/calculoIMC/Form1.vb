Public Class Form1
    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        Dim IMC, riesgo
        IMC = Math.Round(tbPeso.Text / (tbAltura.Text * tbAltura.Text), 1)
        riesgo = ""

        If (IMC >= 18.5 And IMC <= 24.9) Then
            riesgo = ", el nivel de riesgo es Promedio"
        ElseIf (IMC >= 25 And IMC <= 29.9) Then
            riesgo = ", el nivel de riesgo es Aumentado"
        ElseIf (IMC >= 30 And IMC <= 34.9) Then
            riesgo = ", el nivel de riesgo es Moderado"
        ElseIf (IMC >= 35 And IMC <= 39.9) Then
            riesgo = ", el nivel de riesgo es Severo"
        ElseIf (IMC >= 40) Then
            riesgo = ", el nivel de riesgo es Muy severo"
        End If

        MessageBox.Show("El IMC es: " + IMC.ToString() + riesgo)

    End Sub
End Class
