Public Class Calculadora
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles operacion.SelectedIndexChanged

        'declarar 3 variables double por que vamos a

        'usar divicion y tenemos que dominar decimales

        Dim n1, n2, n3 As Double

        'Una variable string para ver como se usa

        Dim signo As String

        'vamos a dar los valores a la variables

        'num1 y 2 es un textbox lo unico que le cambiamos el nombre

        n1 = Num1.Text

        n2 = Num2.Text

        'asigno el valos 0 a n3

        n3 = 0

        'operacion es un comobox pero le cambiamos el nombre

        signo = operacion.Text

        'ahora vamos hacer un pequeña calculadora veamos.

        'SUMA ENTRE LAS COMILLA significa que una cadeda de caracter

        'y estoy comparanod si signo es = a SUMA

        If signo = "SUMA" Then ' si signo = SUMA ejecuta el digo

            n3 = n1 + n2 'para sumar, si no se cumple evalua la siguiente

        ElseIf signo = "RESTA" Then 'esta, si secuple ejecuta el codigo

            n3 = n1 - n2 'para restar, si no se cumple evalua la siguiente

        ElseIf signo = "MULTIPLICACION" Then ' esta,si se cumple ejecuta el codigo

            n3 = n1 * n2 'para MULTIPLICAR, si no se cumple evalua siguiente

        ElseIf signo = "DIVISION" Then ' esta,si se cumple ejecuta el codigo

            n3 = n1 / n2 'para DIVISION, si no se cumple evalua siguiente

        Else ' si no se cumple ninguna de las anteriores

            MsgBox("Operasfion no declarada") ' mostrar ese mensaje

        End If

        ' Asigno el valor a el texbox resultado

        Resultado.Text = n3

    End Sub
End Class
