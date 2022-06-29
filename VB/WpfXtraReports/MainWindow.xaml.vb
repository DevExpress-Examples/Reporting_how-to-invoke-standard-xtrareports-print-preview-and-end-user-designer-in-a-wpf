Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Threading
Imports DevExpress.XtraReports.UI
' ...

Namespace WpfXtraReports
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		' Create a report instance.
		Private ReadOnly report As New XtraReport1()

		Public Sub New()
			InitializeComponent()
		End Sub

		' Implement the RaiseIdle method for the application.
		Shared Sub New()
			InvokeOnIdle()
		End Sub
		Private Shared Sub InvokeOnIdle()
            Dispatcher.CurrentDispatcher.BeginInvoke(New Action(AddressOf OnIdle), _
                                                     DispatcherPriority.ApplicationIdle)
		End Sub
		Private Shared Sub OnIdle()
			InvokeOnIdle()
			System.Windows.Forms.Application.RaiseIdle(EventArgs.Empty)
		End Sub

		' Invoke the Print Preview and End-User Report Designer windows.
		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Using printTool As New ReportPrintTool(report)
				printTool.ShowPreviewDialog()
			End Using
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Using printTool As New ReportDesignTool(report)
				printTool.ShowDesignerDialog()
			End Using
		End Sub
	End Class
End Namespace
