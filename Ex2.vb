Public Class Ex2
    Private Sub btnExecutar_Click(sender As Object, e As EventArgs) Handles btnExecutar.Click
        Dim Valores(10) As Integer
        Dim Calculo(10) As Integer
        Dim str As String

        For x = 0 To 9
            str = InputBox("Insira o valor do indice: " & CStr(x), "Entrada de Dados")

            If Not IsNumeric(str) Then
                x = x - 1
                MsgBox("Digite um valor Númerico")
                Continue For
            Else
                Valores(x) = CInt(str)

                If (x And 1) = 0 Then
                    Calculo(x) = CInt(str) * 5
                Else
                    Calculo(x) = CInt(str) + 5
                End If
            End If
        Next



        str = ""
        For x = 0 To 9
            str = str & Valores(x) & "                            " & Calculo(x) & "              " & Chr(13)
        Next

        MsgBox("Entrada:              " & "Calculo:              " & Chr(13) & str)
    End Sub
End Class
