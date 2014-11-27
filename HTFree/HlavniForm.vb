Public Class HlavniForm
    Private Sub SprávaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SprávaToolStripMenuItem.Click
        clenove.MdiParent = Me
        clenove.Show()
    End Sub
End Class
