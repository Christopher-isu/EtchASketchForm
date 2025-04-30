Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form to be topmost and borderless
        Me.FormBorderStyle = FormBorderStyle.None
        ' Center the AboutForm over the main form
        Dim parentForm As Form = Application.OpenForms("EtchASketch")
        If parentForm IsNot Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(parentForm.Left + (parentForm.Width - Me.Width) \ 2,
                                parentForm.Top + (parentForm.Height - Me.Height) \ 3) ' Adjust for top-center
        End If
        ' Set About text
        AboutLabel.Text = "Etch-A-Sketch" & vbCrLf &
                          "Version 1.0" & vbCrLf &
                          "Created for RCET 2265" & vbCrLf &
                          "Enjoy the waveforms!"
    End Sub

    Private Sub OKbutton_Click(sender As Object, e As EventArgs) Handles OKbutton.Click
        ' Close the AboutForm when the OK button is clicked
        Me.Close()
    End Sub


End Class