Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add("Yo me llamo: Miguel Villegas.")
            .Add("Yo soy de: Tepeji, Hidalgo.")
            .Add("Yo estudio en: FESC campo 4")
            .Add("Amo programar en cualquier lenguaje")
            .Add("Con este programa se busca como buscar con listbox")
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox2.Items.Clear()
        Dim count As Integer = (ListBox1.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox1.Items.Item(a)
            If InStr(words.ToLower, TextBox1.Text.ToLower) Then
                ListBox2.Items.Add(words)
            End If
        Next
    End Sub
End Class
