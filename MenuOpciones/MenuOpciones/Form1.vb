Public Class Numeros


    Dim n1, n2, n3, n4, n5 As Integer
    Dim signo As String
    Dim mensaje As String



    Private Sub ComboxBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles operacion.SelectedIndexChanged

        operacion.DropDownStyle = ComboBoxStyle.DropDownList
        signo = operacion.Text


        Select Case signo
            Case ""
                operacion.Text = "Elige una opción y a continuación ingresa los números"



            Case "Calcular cúal es menor (A ó B)"
                Button3.Text = "Calcular"
                ListBox1.Visible = False
                num1.Visible = True
                num2.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                num4.Visible = False
                num5.Visible = False
                num3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
              


            Case "Calcular cúal es mayor (A ó B)"
                Button3.Text = "Calcular"
                ListBox1.Visible = False
                num1.Visible = True
                num2.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                num4.Visible = False
                num5.Visible = False
                num3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False





            Case "Indicar si los números introducidos son distintos (A<>B)"

                Button3.Text = "Calcular"
                ListBox1.Visible = False
                num1.Visible = True
                num2.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                num4.Visible = False
                num5.Visible = False
                num3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False


            Case "Operaciones: Si A>B [(A+B) y (A/B)] ó Si B>A [(A*B) y (A-B)]"
                Button3.Text = "Calcular"
                ListBox1.Visible = False
                num1.Visible = True
                num2.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                num3.Visible = False
                num4.Visible = False
                num5.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False

            Case "Ordenar de mayor a menor (A y B)"

                Button3.Text = "Calcular"
                ListBox1.Visible = False
                num1.Visible = True
                num2.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                num3.Visible = False
                num4.Visible = False
                num5.Visible = False
                Label4.Visible = False
                Label5.Visible = False

            Case "Introducir cinco números y visualizarlos en orden creciente "
                Button3.Text = "Calcular"
                ListBox1.Visible = True
                num1.Visible = True
                num2.Visible = True
                num3.Visible = True
                num4.Visible = True
                num5.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True


            Case "Introducir cinco números y visualizarlos en orden decreciente"
                Button3.Text = "Calcular"
                ListBox1.Visible = True
                num1.Visible = True
                num2.Visible = True
                num3.Visible = True
                num4.Visible = True
                num5.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True




            Case "Visualizar los números entre 10 y 20 que sean pares"
                Button3.Text = "Calcular"

                ListBox1.Visible = True
                num1.Visible = False
                num2.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                num4.Visible = False
                num5.Visible = False
                num3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False




            Case "Calculadora"

                Button3.Text = " "

                Button3.Text = "Ir a Calculadora"





        End Select


      

    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
 



        Dim ctl As Object
        For Each ctl In Me.Controls
            If TypeOf ctl Is CheckBox Then
                ctl.Value = False
            ElseIf TypeOf ctl Is TextBox Then
                ctl.Text = ""
            ElseIf TypeOf ctl Is ListBox Then
                ctl.Text = ""
                ListBox1.Items.Clear()
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calculadora.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Select Case signo


            Case "Calcular cúal es menor (A ó B)"
                ListBox1.Visible = False

                n1 = num1.Text
                n2 = num2.Text

                If (n1 < n2) Then
                    n3 = n1
                    Resultado.Text = "A: " & n3
                ElseIf (n1 > n2) Then
                    n3 = n2
                    Resultado.Text = "B: " & n3
                End If

                Resultado.Visible = True
                Res.Visible = True



            Case "Calcular cúal es mayor (A ó B)"

                n1 = num1.Text
                n2 = num2.Text

                If (n1 < n2) Then
                    n3 = n2
                    Resultado.Text = "B: " & n3
                ElseIf (n1 > n2) Then
                    n3 = n1
                    Resultado.Text = "A: " & n3
                End If

                Resultado.Visible = True
                Res.Visible = True




            Case "Indicar si los números introducidos son distintos (A<>B)"

                n1 = num1.Text
                n2 = num2.Text
                Resultado.Visible = True
                Res.Visible = True


                If (n1 <> n2) Then

                    mensaje = "Los números son distintos"
                    Resultado.Text = mensaje
                ElseIf (n1 = n2) Then
                    mensaje = "Los números son iguales"
                    Resultado.Text = mensaje
                End If



            Case "Ordenar de mayor a menor (A y B)"


                n1 = num1.Text
                n2 = num2.Text
                Resultado.Visible = True
                Res.Visible = True

                If (n1 < n2) Then
                    n3 = n2
                    n2 = n1
                    Resultado.Text = n3 & ", " & n1 & " "
                ElseIf (n1 > n2) Then
                    n3 = n1
                    Resultado.Text = n3 & ", " & n2 & " "
                End If




            Case "Operaciones: Si A>B [(A+B) y (A/B)] ó Si B>A [(A*B) y (A-B)]"

                Resultado.Visible = True
                Res.Visible = True
                Dim div As Double



                n1 = num1.Text
                n2 = num2.Text

                If (n1 > n2) Then
                    n3 = n1 + n2
                    div = n1 / n2
                    Resultado.Text = "(A+B) = " & n3 & " ( A/B) = " & div & "  "

                ElseIf (n1 < n2) Then
                    n3 = n1 * n2
                    n4 = n1 - n2
                    Resultado.Text = "(A*B) = " & n3 & " ( A-B) = " & n4 & "  "
                End If




            Case "Introducir cinco números y visualizarlos en orden creciente "

                Resultado.Visible = False

                Res.Visible = False

                ListBox1.Items.Clear()

                Dim Num(0 To 5), n, k, reng, temp As Integer
                Num(1) = CInt((num1.Text))
                Num(2) = CInt((num2.Text))
                Num(3) = CInt((num3.Text))
                Num(4) = CInt((num4.Text))
                Num(5) = CInt((num5.Text))

                n = 5
                For k = 1 To n - 1
                    reng = 1
                    Do While reng <= n - k
                        If Num(reng) > Num(reng + 1) Then
                            temp = Num(reng)
                            Num(reng) = Num(reng + 1)
                            Num(reng + 1) = temp

                        End If
                        reng = reng + 1
                    Loop

                Next k



                For x = 1 To 5
                    ListBox1.Items.Add(Num(x) & (", "))
                Next x

            Case "Introducir cinco números y visualizarlos en orden decreciente"

                Resultado.Visible = False

                Res.Visible = False


                ListBox1.Items.Clear()
                Dim Num(0 To 5), n, k, reng, temp As Integer
                Num(1) = CInt((num1.Text))
                Num(2) = CInt((num2.Text))
                Num(3) = CInt((num3.Text))
                Num(4) = CInt((num4.Text))
                Num(5) = CInt((num5.Text))

                n = 5
                For k = 1 To n - 1
                    reng = 1
                    Do While reng <= n - k
                        If Num(reng) < Num(reng + 1) Then
                            temp = Num(reng)
                            Num(reng) = Num(reng + 1)
                            Num(reng + 1) = temp

                        End If
                        reng = reng + 1
                    Loop

                Next k



                For x = 1 To 5
                    ListBox1.Items.Add(Num(x) & (", "))
                Next x

            Case "Visualizar los números entre 10 y 20 que sean pares"

                Resultado.Visible = False

                Res.Visible = False


                ListBox1.Items.Clear()
                ListBox1.Visible = True
                Dim X As Integer
                For X = 10 To 20 Step 2
                    ListBox1.Items.Add(" " & X & (","))
                Next X

            Case "Calculadora"
                Calculadora.Show()
                Button3.Text = "Calcular"
        End Select

    End Sub

    Private Sub num1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num1.TextChanged

    End Sub
End Class
