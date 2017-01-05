Public Class Calculadora

    Dim valor, resultado As Decimal
    Dim signo As Integer


    


    Private Sub uno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uno.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub dos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dos.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub tres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tres.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub cuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuatro.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub cinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cinco.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub seis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seis.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub siete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siete.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub ocho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocho.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub nueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueve.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub cero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cero.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub






 

    Private Sub igual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles igual.Click

        If signo = "1" Then
            resultado = resultado + TextBox1.Text
            TextBox1.Text = " "
            Sig.Text = resultado

        End If
        If signo = "2" Then
            resultado = resultado - TextBox1.Text
            TextBox1.Text = " "
            Sig.Text = resultado

        End If
        If signo = "3" Then
            resultado = resultado * TextBox1.Text
            TextBox1.Text = " "
            Sig.Text = resultado
        End If
    
    End Sub

    Private Sub sumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sumar.Click


        If TextBox1.Text <> "" Then
            signo = "1"
            valor = TextBox1.Text
            TextBox1.Text = ""
            resultado = valor + Sig.Text
            Sig.Text = resultado
        End If

  
    End Sub
    Private Sub restar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restar.Click

        If TextBox1.Text <> "" Then
            signo = "2"
            valor = TextBox1.Text
            TextBox1.Text = ""
            resultado = Sig.Text - valor
            Sig.Text = resultado
        End If

        If TextBox1.Text = "" Then
            valor = 0
            resultado = resultado * 2

        End If

      

    End Sub

    Private Sub multiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplicar.Click

        signo = "3"
        valor = TextBox1.Text
        TextBox1.Text = ""
        resultado = Sig.Text * valor
        Sig.Text = resultado


    End Sub

    Private Sub dividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dividir.Click

        signo = "4"
        valor = TextBox1.Text
        TextBox1.Text = ""
        resultado = Sig.Text / valor
        Sig.Text = resultado
    End Sub


    Private Sub borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrar.Click
        TextBox1.Text = ""
        Sig.Text = 0

    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Close()
    End Sub



 
    Private Sub Calculadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class