Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value * 0.01
        Label4.Text = TextBox1.Text
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        TextBox2.Text = TrackBar2.Value * 0.01
        Label5.Text = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Double = TrackBar1.Value * 0.01
        Dim y As Double = TrackBar2.Value * 0.01
        TextBox3.Text = Suma_Fuzzy(x, y)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim x As Double = TrackBar1.Value * 0.01
        Dim y As Double = TrackBar2.Value * 0.01
        TextBox4.Text = Multiplica_Fuzzy(x, y)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim x As Double = TrackBar1.Value * 0.01
        Dim y As Double = TrackBar2.Value * 0.01
        TextBox5.Text = Resta_Fuzzy(x, y)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim x As Double = TrackBar1.Value * 0.01
        Dim y As Double = TrackBar2.Value * 0.01
        TextBox6.Text = Divide_Fuzzy(x, y)
    End Sub

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

End Class
