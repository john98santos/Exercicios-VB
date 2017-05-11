Public Class FCadastro
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtNome.Text = "" Or txtEmpresa.Text = "" Or txtTelefone.Text = "" Or
        rbtCasado.Enabled = False Or rbtDesquitado.Enabled = False Or rbtDivorciado.Enabled = False Or
        rbtSolteiro.Enabled = False Or rbtViuvo.Enabled = False Or mtbSarario.Text = "" Then
            MsgBox("Preencha todos os campos")
        Else
            If cbxExperiencia.Text = "até um ano" Then
                MsgBox("Você não possui os requisitos necessários para preencher a vaga")
            Else
                If cbxExperiencia.Text = "de um a dois anos" Then
                    MsgBox("aguarde, brevemente chamaremos você para um teste")
                Else
                    If chbFeminino.Checked And chbFilhos.Checked Then
                        MsgBox("Você não preenche os requisitos pois a empresa não fornece creche para os funcionários")
                    Else
                        If CDbl(mtbSarario.Text) < 1000.0 Or CDbl(mtbSarario.Text) > 2500.0 Then
                            MsgBox("Você não preenche os requisitos")
                        Else
                            MsgBox("Contratado")
                        End If
                    End If
                    End If
            End If
        End If
    End Sub
End Class
