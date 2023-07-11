Imports System
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.XtraReports.UI

' ...
Namespace WpfXtraReports

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        ' Create a report instance.
        Private ReadOnly report As XtraReport1 = New XtraReport1()

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        ' Implement the RaiseIdle method for the application.
        Shared Sub New()
            Call InvokeOnIdle()
        End Sub

        Private Shared Sub InvokeOnIdle()
            Call Dispatcher.CurrentDispatcher.BeginInvoke(New Action(AddressOf WpfXtraReports.MainWindow.OnIdle), DispatcherPriority.ApplicationIdle)
        End Sub

        Private Shared Sub OnIdle()
            Call InvokeOnIdle()
            Forms.Application.RaiseIdle(EventArgs.Empty)
        End Sub

        ' Invoke the Print Preview and End-User Report Designer windows.
        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Using printTool As ReportPrintTool = New ReportPrintTool(report)
                printTool.ShowPreviewDialog()
            End Using
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Using printTool As ReportDesignTool = New ReportDesignTool(report)
                printTool.ShowDesignerDialog()
            End Using
        End Sub
    End Class
End Namespace
