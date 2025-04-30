'ChristopherZ
'Spring 2025
'RCET2265
'Etch-A-Sketch
'https://github.com/Christopher-isu/EtchASketchForm.git

Option Strict On
Option Explicit On
Imports System.Threading 'For Thread.Sleep

Public Class EtchASketch
    Private DrawColor As Color = Color.Black 'Default drawing color
    Private ToolTipProvider As New ToolTip() 'ToolTip provider for all controls

    Private Sub EtchASketch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Using functions for load event to keep code organized
        InitializeToolTips() ' Initialize tooltips for controls
        SetupAccessibility() ' Setup accessibility features
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

    Private Sub PresentColorDialog()
        ' Present a color dialog to select a drawing color
        Using colorDialog As New ColorDialog()
            'Preventatively incorporated Using statement for automatic disposal and preventing memory leaks
            If colorDialog.ShowDialog() = DialogResult.OK Then
                DrawColor = colorDialog.Color
            End If
        End Using
    End Sub

    Private Sub ShakeAndClear()
        ' Clear the drawing area with a shaking effect
        Dim offset As Integer = 10
        For i As Integer = 0 To 5 ' Shake effect
            Me.Left += offset ' Move right
            Thread.Sleep(50) ' Pause
            Me.Left -= offset ' Move left
        Next
        DisplayPictureBox.Refresh() ' Clear the drawing area
    End Sub

    Private Sub DrawWaveforms()
        Try
            ' Ensure safe Graphics object usage within a Using block
            Using g As Graphics = DisplayPictureBox.CreateGraphics()
                Dim width As Integer = DisplayPictureBox.Width
                Dim height As Integer = DisplayPictureBox.Height

                ' Clear the picture box and set background color
                g.Clear(Color.White)

                ' Draw graticule
                Dim pen As New Pen(Color.LightGray)
                For x As Integer = 0 To width Step Math.Max(1, width \ 10) ' Ensure step is valid
                    g.DrawLine(pen, x, 0, x, height)
                Next
                For y As Integer = 0 To height Step Math.Max(1, height \ 10) ' Ensure step is valid
                    g.DrawLine(pen, 0, y, width, y)
                Next

                ' Draw sine, cosine, and tangent waves with safeguards
                DrawWave(g, Color.Red, Function(x) Math.Sin(x))
                DrawWave(g, Color.Green, Function(x) Math.Cos(x))
                DrawWave(g, Color.Blue, Function(x) SafeTan(x) / 10) ' Scale tangent for display
            End Using
        Catch ex As Exception
            ' Log or display error message for debugging
            MessageBox.Show($"An error occurred while drawing waveforms: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DrawWave(g As Graphics, color As Color, waveFunc As Func(Of Double, Double))
        ' Draw three waveforms (sine, cosine, tangent) on the PictureBox
        Dim pen As New Pen(color)
        Dim width As Integer = DisplayPictureBox.Width ' Get the width of the PictureBox
        Dim height As Integer = DisplayPictureBox.Height ' Get the height of the PictureBox
        Dim centerY As Integer = height \ 2 ' Center Y position for waveforms

        Dim oldX As Integer = 0 ' Start at the left edge
        Dim oldY As Integer = centerY ' Center Y position

        For x As Integer = 1 To width
            Try
                ' Calculate Y value and ensure it stays within valid bounds
                Dim y As Integer = centerY - CInt(waveFunc(x * 2 * Math.PI / width) * (height \ 3))
                y = Math.Min(Math.Max(0, y), height - 1) ' Clamp Y value within the PictureBox
                g.DrawLine(pen, oldX, oldY, x, y) ' Draw line segment
                oldX = x ' Update oldX to current x
                oldY = y ' Update oldY to current y
            Catch ex As OverflowException
                ' Skip drawing this segment if waveFunc produces invalid results
                oldX = x ' Update oldX to current x
                oldY = centerY ' Reset oldY to centerY
            End Try
        Next
    End Sub

    Private Function SafeTan(x As Double) As Double
        Try
            ' Safely calculate tangent while avoiding extreme values
            Return Math.Tan(x)
        Catch ex As Exception
            Return 0 ' Return a default value if tangent calculation fails
        End Try
    End Function

    Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove
        ' Draw on the PictureBox when the mouse is moved with the left button pressed
        Static oldX As Integer = -1 ' Initialize X to -1 to indicate no previous position
        Static oldY As Integer = -1 ' Initialize Y  to -1 to indicate no previous position

        If e.Button = MouseButtons.Left AndAlso oldX >= 0 AndAlso oldY >= 0 Then
            ' Draw a line from the last position to the current position
            Dim g As Graphics = DisplayPictureBox.CreateGraphics() ' Create a Graphics object
            Dim pen As New Pen(DrawColor, 2) ' Set the pen color and width
            g.DrawLine(pen, oldX, oldY, e.X, e.Y) ' Draw line segment
            g.Dispose() ' Dispose of the Graphics object
        End If
        oldX = e.X ' Update oldX to current X
        oldY = e.Y ' Update oldY to current Y
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsMenuItem.Click
        DrawWaveforms()
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown
        If e.Button = MouseButtons.Middle Then
            PresentColorDialog()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearMenuItem.Click
        ShakeAndClear()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorMenuItem.Click
        PresentColorDialog()
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        ' Show the AboutForm when the menu item is clicked
        Dim about As New AboutForm()
        about.ShowDialog() ' Show as a modal dialog
    End Sub

End Class
