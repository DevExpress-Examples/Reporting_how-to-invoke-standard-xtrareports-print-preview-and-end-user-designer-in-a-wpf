Imports System.Windows

Namespace WpfXtraReports

    Class Window1
        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
            Dim report As New XtraReport1()
            report.ShowPreviewDialog()
        End Sub

        Private Sub button2_Click(ByVal sender As System.Object, ByVal e As RoutedEventArgs)
            Dim report As New XtraReport1()
            report.ShowDesignerDialog()
        End Sub
    End Class

End Namespace

