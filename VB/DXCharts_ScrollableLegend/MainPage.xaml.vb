Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Charts

Namespace DXCharts_ScrollableLegend
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim rnd As New Random()
			Dim today As DateTime = DateTime.Today

			chart.BeginInit()
			For i As Integer = 0 To 19
				Dim areaSeries As New AreaStackedSeries2D()
				areaSeries.ArgumentScaleType = ScaleType.DateTime
				areaSeries.LabelsVisibility = False
				areaSeries.Transparency = 0.3
				areaSeries.DisplayName = "Area " & (i + 1).ToString()

				For j As Integer = 0 To 30
					Dim p As New SeriesPoint(today.AddDays(j), rnd.Next(50, 100))
					areaSeries.Points.Add(p)
				Next j

				xyDiagram.Series.Add(areaSeries)
			Next i
			chart.EndInit()
		End Sub
	End Class
End Namespace