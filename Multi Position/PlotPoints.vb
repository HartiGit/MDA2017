﻿
Public Class PLotPoints



    Private Sub GenPlots_Click(sender As Object, e As EventArgs) Handles BTNGenPlots.Click
        PosGen()

        Me.Chart1.Series("Series1").Points.AddXY(GetX(), GetY())
    End Sub

    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged
        SetCoteA(NumCoteA.Value)
    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged
        SetCoteB(NumCoteB.Value)
    End Sub




End Class
