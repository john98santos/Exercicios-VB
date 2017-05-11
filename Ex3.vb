Public Class Ex3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExecutar.Click
        Dim Valores(4, 5) As Integer
        Dim Linhas(5) As Integer
        Dim linha As Integer = 0
        Dim Total_Geral As Integer = 0
        Dim str As String

        For x = 0 To 4
            For y = 0 To 3
                str = InputBox("Insira o valor do indice: " & CStr(y) & "," & CStr(x), "Entrada de Dados")

                If Not IsNumeric(str) Then
                    y = y - 1
                    MsgBox("Digite um valor Númerico")
                    Continue For
                Else
                    If CInt(str) < 0 Or CInt(str) > 9 Then
                        MsgBox("O valor digitado não está entre 0 e 9")
                        Exit Sub
                    Else
                        Valores(y, x) = CInt(str)
                        linha = linha + CInt(str)
                    End If
                End If
            Next

            Linhas(x) = linha

            Total_Geral = Total_Geral + linha

            linha = 0
        Next

        For x = 0 To 4
            lbxResultado.Items(x) = "Vetor Linha(" & x & "):" & CStr(Linhas(x))
        Next

        lbxResultado.Items(5) = "Total Geral:" & CStr(Total_Geral)
    End Sub
End Class
