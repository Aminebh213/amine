Public Class Form1
    Dim A As Double
    Dim B As Double
    Dim C As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += "1" ' Changed from TextBox1.Test to TextBox1.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text += "."
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' Clear the TextBox
        TextBox1.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        C = "+"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        C = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        C = "*"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        C = "/" ' Changed from "\" to "/" for standard division
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        B = Val(TextBox1.Text)
        TextBox1.Clear()
        Select Case C
            Case "+"
                TextBox1.Text = (A + B).ToString()
            Case "-"
                TextBox1.Text = (A - B).ToString()
            Case "*"
                TextBox1.Text = (A * B).ToString()
            Case "/"
                If B <> 0 Then
                    TextBox1.Text = (A / B).ToString()
                Else
                    TextBox1.Text = "Error" ' Handle division by zero
                End If
        End Select
    End Sub
End Class
