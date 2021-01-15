Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msg As String = ""
        If CheckBox1.Checked = True Then
            msg = " net-informations.com "
        End If
        If CheckBox2.Checked = True Then
            msg = msg & " vb.net-informations.com "
        End If
        If CheckBox3.Checked = True Then
            msg = msg & " csharp.net-informations.com "
        End If

        If msg.Length > 0 Then
            MessageBox.Show(msg & " seleccionado", "Hola")
        Else
            MessageBox.Show("Sin casilla de verificación seleccionada", "Hola")
        End If
        CheckBox1.ThreeState = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value = "31/12/2010"
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        For i = 0 To 200
            ProgressBar1.Value = i
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Multiline = True
        TextBox1.ScrollBars = ScrollBars.Both
    End Sub
End Class
