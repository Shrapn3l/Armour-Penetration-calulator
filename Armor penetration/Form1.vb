Public Class Form1
    Dim v As Double
    Dim p As Double
    Dim k As Double
    Dim d As Double
    Dim b As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v = Val(TextBox1.Text)
        p = Val(TextBox2.Text)
        k = Val(TextBox3.Text)
        d = Val(TextBox4.Text)

        b = (v * p ^ (1 / 2)) / (k * d ^ (1 / 2))
        TextBox5.Text = b * 1000
    End Sub




End Class
