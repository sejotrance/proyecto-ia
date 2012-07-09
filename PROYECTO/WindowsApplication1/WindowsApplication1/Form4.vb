﻿Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label7.Text = Me.TrackBar1.Value * 0.01
        Me.Label8.Text = Me.TrackBar2.Value * 0.01
        Me.Label9.Text = Me.TrackBar3.Value * 0.01
        Me.Label10.Text = Me.TrackBar4.Value * 0.01
        Me.Label11.Text = Me.TrackBar5.Value * 0.01
        Me.Label15.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Me.Label7.Text = Me.TrackBar1.Value * 0.01
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        Me.Label8.Text = Me.TrackBar2.Value * 0.01
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''''''Guardamos todos los valores'''''''''
        Dim v0 As Double = Me.TrackBar1.Value * 0.01
        Dim v1 As Double = Me.TrackBar2.Value * 0.01
        Dim v2 As Double = Me.TrackBar3.Value * 0.01
        Dim v3 As Double = Me.TrackBar4.Value * 0.01
        Dim v6 As Double = Me.TrackBar5.Value * 0.01

        '        O3= V6(V0+V1+V2+V3)          '
        Dim suma As Double = Form1.Suma_Fuzzy(Form1.Suma_Fuzzy(Form1.Suma_Fuzzy(v0, v1), v2), v3)
        Dim o3 = Form1.Multiplica_Fuzzy(v6, suma)

        Me.Label15.Text = o3
        Me.Label15.Visible = True

    End Sub
End Class