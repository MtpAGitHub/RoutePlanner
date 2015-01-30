Class MainWindow 

    Private Sub btnMapBuild_Click(sender As Object, e As RoutedEventArgs) Handles btnMapBuild.Click

    End Sub

    Private Sub btnLoader_Click(sender As Object, e As RoutedEventArgs) Handles btnLoader.Click
        Dim stationLoader As Loader = New Loader()
        stationLoader.Show()
    End Sub
End Class
