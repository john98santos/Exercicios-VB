Public Class Ex1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Soma As Double = 0
        Dim N As Integer

        If IsNumeric(txtText.Text) Then
            N = CInt(txtText.Text)

            If N < 0 Or N > 50 Then
                MsgBox("Valor não suportado. Favor digitar um valor válido")
            Else
                For X = 1 To N
                    Soma = Soma + (X / (X + 1))
                Next
            End If

            MsgBox("Soma=" & CStr(Soma))
        Else
            MsgBox("Insira um valor numerico")
        End If
    End Sub
End Class
