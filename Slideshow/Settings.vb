Public Class Settings

    Public imageDir As String

    Private Sub btnChooseFolder_Click(sender As Object, e As EventArgs) Handles btnChooseFolder.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            imageDir = FolderBrowserDialog1.SelectedPath
            lblShowImageFolder.Text = imageDir
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
    End Sub
End Class