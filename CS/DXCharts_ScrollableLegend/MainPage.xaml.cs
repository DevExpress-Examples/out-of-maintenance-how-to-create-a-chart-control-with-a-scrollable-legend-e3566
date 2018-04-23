using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Charts;

namespace DXCharts_ScrollableLegend {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Random rnd = new Random();
            DateTime today = DateTime.Today;

            chart.BeginInit();
            for (int i = 0; i < 20; i++) {
                AreaStackedSeries2D areaSeries = new AreaStackedSeries2D();
                areaSeries.ArgumentScaleType = ScaleType.DateTime;
                areaSeries.ActualLabel.Visible = false;
                areaSeries.Transparency = 0.3;
                areaSeries.DisplayName = "Area " + (i + 1).ToString();

                for (int j = 0; j <= 30; j++) {
                    SeriesPoint p = new SeriesPoint(today.AddDays(j), rnd.Next(50, 100));
                    areaSeries.Points.Add(p);
                }

                xyDiagram.Series.Add(areaSeries);
            }
            chart.EndInit();
        }
    }
}