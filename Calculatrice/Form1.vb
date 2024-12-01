
Imports System.Globalization
Imports System.Threading


Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim op As String
    Private Function Egale() As Object
        If op = "" Then
            txt.Text = txtInput.Text + "="
        End If
        b = Val(txtInput.Text)
        Select Case op
            Case "+"
                c = a + b
            Case "-"
                c = a - b
            Case "*"
                c = a * b
            Case "/"
                If b = 0 Then
                    MessageBox.Show("Division par zéro impossible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt.Text = ""
                    Return 0
                End If
                c = a / b
        End Select
        op = ""
        Return c
    End Function
    Private Sub btnEgale_Click(sender As Object, e As EventArgs) Handles btnEgale.Click
        If txt.Text = "" Then
            txt.Text = txtInput.Text + "="
            op = "="
        ElseIf op <> "=" Then
            txt.Text = txt.Text + txtInput.Text + "="
            txtInput.Text = Egale().ToString()
            op = "="
        ElseIf op = "=" Then
            txt.Text = txtInput.Text + "="
        End If

    End Sub

    Private Sub btnSur_Click(sender As Object, e As EventArgs) Handles btnSur.Click
            a = Val(txtInput.Text)
            txt.Text = txtInput.Text + "/"
            txtInput.Text = "0"
            op = "/"
    End Sub

    Private Sub btnFois_Click(sender As Object, e As EventArgs) Handles btnFois.Click
        a = Val(txtInput.Text)
        txt.Text = txtInput.Text + "*"
        txtInput.Text = "0"
        op = "*"
    End Sub

    Private Sub bntMoins_Click(sender As Object, e As EventArgs) Handles bntMoins.Click
        a = Val(txtInput.Text)
        txt.Text = txtInput.Text + "-"
        txtInput.Text = "0"
        op = "-"
    End Sub

    Private Sub bntPlus_Click(sender As Object, e As EventArgs) Handles bntPlus.Click
        a = Val(txtInput.Text)
        txt.Text = txtInput.Text + "+"
        txtInput.Text = "0"
        op = "+"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "1"
        Else
            txtInput.Text = "1"
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "2"
        Else
            txtInput.Text = "2"
        End If
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "3"
        Else
            txtInput.Text = "3"
        End If
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "4"
        Else
            txtInput.Text = "4"
        End If
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "5"
        Else
            txtInput.Text = "5"
        End If
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "6"
        Else
            txtInput.Text = "6"
        End If
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "7"
        Else
            txtInput.Text = "7"
        End If
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "8"
        Else
            txtInput.Text = "8"
        End If
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtInput.Text <> "0" Then
            txtInput.Text += "9"
        Else
            txtInput.Text = "9"
        End If
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtInput.Text = "" Or txtInput.Text = "0" Then
            txtInput.Text = "0"
        Else
            txtInput.Text += "0"
        End If

    End Sub
    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        If txtInput.Text = "" Or txtInput.Text = "0" Then
            txtInput.Text = "0"
        Else
            txtInput.Text += "00"
        End If
    End Sub
    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        txtInput.Text += "."
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = "0"
        txt.Text = ""
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txtInput.Text.Length > 0 Then
            txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1)
        Else
            txtInput.Text = ""
        End If
    End Sub

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'invariant culture force  le "." comme séparateur décimal et pas la virgule
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture
        Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture
    End Sub
End Class
