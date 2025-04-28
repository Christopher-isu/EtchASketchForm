Option Strict On
Option Explicit On
Imports System.Threading

Public Class EtchASketch
    Private DrawColor As Color = Color.Black
    Private ToolTipProvider As New ToolTip()

    Private Sub EtchASketch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeToolTips()
        SetupAccessibility()
    End Sub

    Private Sub InitializeToolTips()
        ' Initialize tooltips for all controls
        ToolTipProvider.SetToolTip(DisplayPictureBox, "Draw within this area using the mouse.")
        ToolTipProvider.SetToolTip(SelectColorButton, "Select a new color for drawing.")
        ToolTipProvider.SetToolTip(DrawWaveformsButton, "Plot sine, cosine, and tangent waveforms.")
        ToolTipProvider.SetToolTip(ClearButton, "Clear the drawing area.")
        ToolTipProvider.SetToolTip(ExitButton, "Exit the application.")
    End Sub

    Private Sub SetupAccessibility()
        ' Tab order configuration
        SelectColorButton.TabIndex = 0
        DrawWaveformsButton.TabIndex = 1
        ClearButton.TabIndex = 2
        ExitButton.TabIndex = 3

        ' Accept and cancel buttons
        Me.AcceptButton = DrawWaveformsButton
        Me.CancelButton = ClearButton
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorMenuItem.Click
        PresentColorDialog()
    End Sub

    Private Sub PresentColorDialog()
        Using colorDialog As New ColorDialog()
            If colorDialog.ShowDialog() = DialogResult.OK Then
                DrawColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearMenuItem.Click
        ShakeAndClear()
    End Sub

    Private Sub ShakeAndClear()
        Dim offset As Integer = 10
        For i As Integer = 0 To 5
            Me.Left += offset
            Thread.Sleep(50)
            Me.Left -= offset
        Next
        DisplayPictureBox.Refresh()
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsMenuItem.Click
        DrawWaveforms()
    End Sub

    Private Sub DrawWaveforms()
        Dim g As Graphics = DisplayPictureBox.CreateGraphics()
        Dim width As Integer = DisplayPictureBox.Width
        Dim height As Integer = DisplayPictureBox.Height

        ' Draw graticule
        g.Clear(Color.White)
        Dim pen As New Pen(Color.LightGray)
        For x As Integer = 0 To width Step width \ 10
            g.DrawLine(pen, x, 0, x, height)
        Next
        For y As Integer = 0 To height Step height \ 10
            g.DrawLine(pen, 0, y, width, y)
        Next

        ' Draw sine, cosine, and tangent waves
        DrawWave(g, Color.Red, Function(x) Math.Sin(x))
        DrawWave(g, Color.Green, Function(x) Math.Cos(x))
        DrawWave(g, Color.Blue, Function(x) Math.Tan(x) / 10) ' Scale tangent for display
    End Sub

    Private Sub DrawWave(g As Graphics, color As Color, waveFunc As Func(Of Double, Double))
        Dim pen As New Pen(color)
        Dim width As Integer = DisplayPictureBox.Width
        Dim height As Integer = DisplayPictureBox.Height
        Dim centerY As Integer = height \ 2

        Dim oldX As Integer = 0
        Dim oldY As Integer = centerY
        For x As Integer = 1 To width
            Dim y As Integer = centerY - CInt(waveFunc(x * 2 * Math.PI / width) * (height \ 3))
            g.DrawLine(pen, oldX, oldY, x, y)
            oldX = x
            oldY = y
        Next
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove
        Static oldX As Integer = -1
        Static oldY As Integer = -1

        If e.Button = MouseButtons.Left AndAlso oldX >= 0 AndAlso oldY >= 0 Then
            Dim g As Graphics = DisplayPictureBox.CreateGraphics()
            Dim pen As New Pen(DrawColor, 2)
            g.DrawLine(pen, oldX, oldY, e.X, e.Y)
            g.Dispose()
        End If
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown
        If e.Button = MouseButtons.Middle Then
            PresentColorDialog()
        End If
    End Sub

    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs) Handles EditMenuItem.Click

    End Sub

    Private Sub FileMenuItem_Click(sender As Object, e As EventArgs) Handles FileMenuItem.Click

    End Sub

    Private Sub HelpMenuItem_Click(sender As Object, e As EventArgs) Handles HelpMenuItem.Click

    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click

    End Sub

    Private Sub SelectColorMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorMenuItem.Click

    End Sub

    Private Sub DrawWaveformsMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsMenuItem.Click

    End Sub

    Private Sub ClearMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMenuItem.Click

    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click

    End Sub

    Private Sub SelectColorButton_Click_1(sender As Object, e As EventArgs) Handles SelectColorButton.Click

    End Sub

    Private Sub DrawWaveformsButton_Click_1(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click

    End Sub

    Private Sub ClearButton_Click_1(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub

    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click

    End Sub
End Class
