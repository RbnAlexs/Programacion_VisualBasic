Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim a, b, c As Object
            Dim d, f As Integer
            For Each a In ListBox1.Items
                For Each b In ListBox1.Items
                    If a = b Then
                        d += 1
                    End If
                Next
                If d > f Then
                    f = d
                    c = a
                End If
                d = 0
            Next
            Label1.Text = (c.ToString & " se ha repetido " & f & " veces")
        Catch ex As Exception
        End Try
    End Sub
End Class
