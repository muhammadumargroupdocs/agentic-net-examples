using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace RemoveChartSeriesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a clustered column chart to the slide
            Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn,
                50f, 50f, 600f, 400f);

            // Clear any default series and categories
            chart.ChartData.Series.Clear();
            chart.ChartData.Categories.Clear();

            // Get the chart data workbook
            Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Add categories
            chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 0, "Category 1"));
            chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 1, "Category 2"));
            chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 2, "Category 3"));

            // Add first series
            chart.ChartData.Series.Add(workbook.GetCell(0, 1, 0, "Series 1"), chart.Type);
            chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 0, 20));
            chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 1, 50));
            chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 2, 30));

            // Add second series
            chart.ChartData.Series.Add(workbook.GetCell(0, 2, 0, "Series 2"), chart.Type);
            chart.ChartData.Series[1].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 2, 0, 40));
            chart.ChartData.Series[1].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 2, 1, 60));
            chart.ChartData.Series[1].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 2, 2, 35));

            // Remove the first series from the chart
            chart.ChartData.Series.RemoveAt(0);

            // Save the presentation
            presentation.Save("RemovedSeries.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}