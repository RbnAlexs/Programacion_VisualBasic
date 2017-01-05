Option Explicit On

' -- Vector para los datos  
Dim Vector() As Object

' --------------------------------------------------------------------------------  
' \\ -- Inicio  
' --------------------------------------------------------------------------------  
Private Sub Form_Load()
    Command1.Caption = " Ordenar Vector "
    Command2.Caption = " Cargar Vector "
    Command1.Enabled = False
End Sub

' --------------------------------------------------------------------------------  
' \\ -- Botón para Ordenar el array y cargar los valores en el List2  
' --------------------------------------------------------------------------------  
Private Sub Command1_Click()
    Dim i As Integer

    Call Ordenar()
    List2.Clear()

    For i = 0 To UBound(Vector)
        List2.AddItem(Vector(i))
    Next i
    Command1.Enabled = False
End Sub

' --------------------------------------------------------------------------------  
' \\ -- Cargar valores en el List1  
' --------------------------------------------------------------------------------  
Private Sub Command2_Click()
    Command2.Enabled = False
    Command1.Enabled = True

    Call Cargar_Array()
End Sub
' --------------------------------------------------------------------------------  
' \\ -- BubbleSort - Sub para ordenar el vector  
' --------------------------------------------------------------------------------  
Private Sub Ordenar()

    Dim iMin As Long
    Dim iMax As Long
    Dim Vectemp As String                   ' -- variable temporal  
    Dim Pos As Long
    Dim i As Long

    iMin = LBound(Vector)
    iMax = UBound(Vector)

    While iMax > iMin
        Pos = iMin
        For i = iMin To iMax - 1
            If Vector(i) > Vector(i + 1) Then
                Vectemp = Vector(i + 1)
                Vector(i + 1) = Vector(i)
                Vector(i) = Vectemp
                Pos = i
            End If
        Next i
        iMax = Pos
    End While
End Sub

' ---------------------------------------------------------------------------------  
' \\ -- Sub cargar valores de ejemplo en el array y en el control de lista  
' ---------------------------------------------------------------------------------  
Private Sub Cargar_Array()
    Dim i As Integer

    ' -- Listbox  
    With List1
        .AddItem("A")
        .AddItem("H")
        .AddItem("B")
        .AddItem("G")
        .AddItem("C")
        .AddItem("F")
        .AddItem("D")
    End With

    ' -- Array  
    ReDim Vector(List1.ListCount - 1)
    For i = 0 To List1.ListCount - 1
        Vector(i) = List1.List(i)
    Next i
End Sub
