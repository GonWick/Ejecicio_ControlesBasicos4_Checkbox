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
End Class
