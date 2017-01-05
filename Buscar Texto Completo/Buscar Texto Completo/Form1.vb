Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add("Yo me llamo: RUbén Alejandro.")
            .Add("Yo soy de: Tlalnepantla, Edo. de Mexico.")
            .Add("Yo estudio en: FESC campo 4")
            .Add("Amo programar en cualquier lenguaje")
            .Add("Con este programa se busca como buscar con listbox")
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox2.Items.Clear()
        Dim count As Integer = (ListBox1.Items.Count - 1)
        Dim words, wordsB As String
        Dim spaceCharcounter As Integer = 0
        For i = 0 To count
            words = ListBox1.Items.Item(i)
            For j = 0 To words.Length - 1
                If spaceCharcounter >= 2 Then
                    wordsB += words.Substring(j, 1)
                ElseIf words.Substring(j, 1) = Chr(32) Then
                    spaceCharcounter += 1
                End If
            Next
            If InStr(wordsB, TextBox1.Text) Then
                ListBox2.Items.Add(ListBox1.Items.Item(i))
            End If
            words = Nothing
            spaceCharcounter = 0
            wordsB = Nothing
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class