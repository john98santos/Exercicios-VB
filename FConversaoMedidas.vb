Public Class FConversaoMedidas
    Private Sub txtDe_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDe.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbxDe.Text = "" Then
                txtDe.Text = ""
                txtPara.Text = ""
                cbxDe.Text = ""
                cbxPara.Text = ""
                txtDe.Focus()
            Else
                If IsNumeric(txtDe.Text) Then
                    Select Case cbxDe.Text
                        Case Is = "Arroba"
                            txtPara.Text = CDbl(txtDe.Text) * 15.0
                            cbxPara.Text = cbxPara.Items(0)

                        Case = "Libra"
                            txtPara.Text = CDbl(txtDe.Text) * 0.4535923
                            cbxPara.Text = cbxPara.Items(0)

                        Case = "Onça"
                            txtPara.Text = CDbl(txtDe.Text) * 28.349
                            cbxPara.Text = cbxPara.Items(1)

                        Case = "Acre"
                            txtPara.Text = CDbl(txtDe.Text) * 0.4046856224
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "Hectare"
                            txtPara.Text = CDbl(txtDe.Text) * 10000.0
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "AlqueireMG"
                            txtPara.Text = CDbl(txtDe.Text) * 4.84
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "AlqueireSP"
                            txtPara.Text = CDbl(txtDe.Text) * 2.42
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "AlqueireNorte"
                            txtPara.Text = CDbl(txtDe.Text) * 2.72
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "Braça"
                            txtPara.Text = CDbl(txtDe.Text) * 1.8288
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "Jarda"
                            txtPara.Text = CDbl(txtDe.Text) * 0.9144
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "Pé"
                            txtPara.Text = CDbl(txtDe.Text) * 30.48
                            cbxPara.Text = cbxPara.Items(4)

                        Case = "Polegada"
                            txtPara.Text = CDbl(txtDe.Text) * 2.54
                            cbxPara.Text = cbxPara.Items(4)

                        Case = "Milha"
                            txtPara.Text = CDbl(txtDe.Text) * 1.609344
                            cbxPara.Text = cbxPara.Items(5)

                    End Select
                Else
                    MsgBox("Digite um valor numerico")
                End If
            End If
        End If
    End Sub

    Private Sub txtPara_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbxDe.Text = "" Then
                txtDe.Text = ""
                txtPara.Text = ""
                cbxDe.Text = ""
                cbxPara.Text = ""
                txtDe.Focus()
            Else
                If IsNumeric(txtDe.Text) Then
                    Select Case cbxDe.Text
                        Case Is = "Arroba"
                            txtDe.Text = CDbl(txtPara.Text) / 15.0
                            cbxPara.Text = cbxPara.Items(0)

                        Case = "Libra"
                            txtDe.Text = CDbl(txtPara.Text) / 0.4535923
                            cbxPara.Text = cbxPara.Items(0)

                        Case = "Onça"
                            txtDe.Text = CDbl(txtPara.Text) / 28.349
                            cbxPara.Text = cbxPara.Items(1)

                        Case = "Acre"
                            txtDe.Text = CDbl(txtPara.Text) / 0.4046856224
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "Hectare"
                            txtDe.Text = CDbl(txtPara.Text) / 10000.0
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "AlqueireMG"
                            txtDe.Text = CDbl(txtPara.Text) / 4.84
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "AlqueireSP"
                            txtDe.Text = CDbl(txtPara.Text) / 2.42
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "AlqueireNorte"
                            txtDe.Text = CDbl(txtPara.Text) / 2.72
                            cbxPara.Text = cbxPara.Items(2)

                        Case = "Braça"
                            txtDe.Text = CDbl(txtPara.Text) / 1.8288
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "Jarda"
                            txtDe.Text = CDbl(txtPara.Text) / 0.9144
                            cbxPara.Text = cbxPara.Items(3)

                        Case = "Pé"
                            txtDe.Text = CDbl(txtPara.Text) / 30.48
                            cbxPara.Text = cbxPara.Items(4)

                        Case = "Polegada"
                            txtDe.Text = CDbl(txtPara.Text) / 2.54
                            cbxPara.Text = cbxPara.Items(4)

                        Case = "Milha"
                            txtDe.Text = CDbl(txtPara.Text) / 1.609344
                            cbxPara.Text = cbxPara.Items(5)

                    End Select
                Else
                    MsgBox("Digite um valor numerico")
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDe.Text = ""
        txtPara.Text = ""
        cbxDe.Text = ""
        cbxPara.Text = ""
    End Sub
End Class
