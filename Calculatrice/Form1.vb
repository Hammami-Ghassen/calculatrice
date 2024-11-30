Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim op As String

    Private Sub btnEgale_Click(sender As Object, e As EventArgs) Handles btnEgale.Click
        b = Val(txt.Text)
        Select Case op
            Case "+"
                c = a + b
            Case "-"
                c = a - b
            Case "*"
                c = a * b
            Case "/"
                c = a / b
        End Select
        txt.Text = c
    End Sub

    Private Sub btnSur_Click(sender As Object, e As EventArgs) Handles btnSur.Click
        a = Val(txt.Text)
        txt.Text = ""
        op = "/"
    End Sub

    Private Sub btnFois_Click(sender As Object, e As EventArgs) Handles btnFois.Click
        a = Val(txt.Text)
        txt.Text = ""
        op = "*"
    End Sub

    Private Sub bntMoins_Click(sender As Object, e As EventArgs) Handles bntMoins.Click
        a = Val(txt.Text)
        txt.Text = ""
        op = "-"
    End Sub

    Private Sub bntPlus_Click(sender As Object, e As EventArgs) Handles bntPlus.Click
        a = Val(txt.Text)
        txt.Text = ""
        op = "+"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt.Text += "1"
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt.Text += "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt.Text += "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt.Text += "4"
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt.Text += "5"
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt.Text += "6"
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt.Text += "7"
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt.Text += "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt.Text += "9"
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txt.Text += "0"
    End Sub
    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        txt.Text += "00"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt.Text = ""
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txt.Text.Length > 0 Then
            txt.Text = txt.Text.Substring(0, txt.Text.Length - 1)
        Else
            txt.Text = ""
        End If
    End Sub
End Class
