Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Label7.Text = Me.TrackBar1.Value * 0.01
        Me.Label8.Text = Me.TrackBar2.Value * 0.01
        Me.Label9.Text = Me.TrackBar3.Value * 0.01
        Me.Label10.Text = Me.TrackBar4.Value * 0.01
        Me.Label11.Text = Me.TrackBar5.Value * 0.01
        Me.Label12.Text = Me.TrackBar6.Value * 0.01
        Me.Label15.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Label7.Text = TrackBar1.Value * 0.01
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        Label8.Text = TrackBar2.Value * 0.01
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Me.Label9.Text = Me.TrackBar3.Value * 0.01
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Me.Label10.Text = Me.TrackBar4.Value * 0.01
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        Me.Label11.Text = Me.TrackBar5.Value * 0.01
    End Sub

    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        Me.Label12.Text = Me.TrackBar6.Value * 0.01

    End Sub

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
    '    Dim x As Double = TrackBar1.Value * 0.01
    '    Dim y As Double = TrackBar2.Value * 0.01
    '    TextBox3.Text = Suma_Fuzzy(x, y)
    'End Sub

    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
    '    Dim x As Double = TrackBar1.Value * 0.01
    '    Dim y As Double = TrackBar2.Value * 0.01
    '    TextBox4.Text = Multiplica_Fuzzy(x, y)
    'End Sub

    'Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
    '    Dim x As Double = TrackBar1.Value * 0.01
    '    Dim y As Double = TrackBar2.Value * 0.01
    '    TextBox5.Text = Resta_Fuzzy(x, y)
    'End Sub

    'Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
    '    Dim x As Double = TrackBar1.Value * 0.01
    '    Dim y As Double = TrackBar2.Value * 0.01
    '    TextBox6.Text = Divide_Fuzzy(x, y)
    'End Sub

    Public Function Suma_Fuzzy(ByVal x As Double, ByVal y As Double) As Double
        Dim aux As Double
        Dim resultado As Double
        aux = y - x
        If (aux < 0) Then 'si la resta es negativa se elige el valor de x
            resultado = x
        Else 'se elige el minimo
            If (aux < x) Then
                resultado = aux
            End If
            If (aux > x) Then
                resultado = x
            End If
        End If
        Return resultado
    End Function

    Public Function Multiplica_Fuzzy(ByVal x As Double, ByVal y As Double) As Double
        Dim aux As Double
        Dim resultado As Double
        aux = y / x
        If (aux < x) Then 'se elige el minimo
            resultado = aux
        Else
            resultado = x
        End If
        Return resultado
    End Function

    Public Function Resta_Fuzzy(ByVal x As Double, ByVal y As Double) As Double
        Dim aux As Double
        Dim resultado As Double
        aux = -y
        resultado = Suma_Fuzzy(x, aux)
        Return resultado
    End Function

    Public Function Divide_Fuzzy(ByVal x As Double, ByVal y As Double) As Double
        Dim aux As Double
        Dim resultado As Double
        aux = (1 / y)
        resultado = Multiplica_Fuzzy(x, aux)
        Return resultado
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''''''Guardamos todos los valores'''''''''
        Dim v0 As Double = Me.TrackBar1.Value * 0.01
        Dim v1 As Double = Me.TrackBar2.Value * 0.01
        Dim v2 As Double = Me.TrackBar3.Value * 0.01
        Dim v3 As Double = Me.TrackBar4.Value * 0.01
        Dim v4 As Double = Me.TrackBar5.Value * 0.01
        Dim v5 As Double = Me.TrackBar6.Value * 0.01

        '        O1= (V0+V1+V2+V3)/(V4+V5)           '
        Dim numerador As Double = Suma_Fuzzy(Suma_Fuzzy(Suma_Fuzzy(v0, v1), v2), v3)
        Dim denominador As Double = Suma_Fuzzy(v4, v5)
        Dim o1 = Divide_Fuzzy(numerador, denominador)

        Me.Label15.Text = o1
        Me.Label15.Visible = True

    End Sub
End Class
