Public Class MainForm
    Dim images As New List(Of Image)
    Dim imageIndex As Integer

    Private Sub btnSetUp_Click(sender As Object, e As EventArgs) Handles btnSetUp.Click
        Settings.ShowDialog()
        Debug.WriteLine("Using " + Settings.imageDir)

        images.Clear()

        For Each foundFile In My.Computer.FileSystem.GetFiles(Settings.imageDir)

            If foundFile.EndsWith(".jpg") Or foundFile.EndsWith(".jpeg") Or foundFile.EndsWith(".png") Then
                images.Add(Image.FromFile(foundFile))
                Debug.WriteLine("Adding " + foundFile)
            End If
        Next

        imageIndex = 0

    End Sub

    Private Sub tmrSlideshow_Tick(sender As Object, e As EventArgs) Handles tmrSlideshow.Tick
        picSlideshow.Image = images.Item(imageIndex)
        imageIndex += 1
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        picSlideshow.Image = images.Item(imageIndex)
        imageIndex += 1
        tmrSlideshow.Start()
    End Sub
End Class
