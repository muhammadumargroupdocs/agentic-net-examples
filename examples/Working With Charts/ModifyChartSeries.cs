using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Remove any default series and categories
        chart.ChartData.Series.Clear();
        chart.ChartData.Categories.Clear();

        // Get the chart data workbook to create cells
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Add categories
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 0, "Category 1"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, 1, 0, "Category 2"));

        // Add first series with data points
        Aspose.Slides.Charts.IChartSeries series1 = chart.ChartData.Series.Add(
            workbook.GetCell(0, 0, 1, "Series 1"), chart.Type);
        series1.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 0, 1, 20));
        series1.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 1, 30));

        // Add second series with data points
        Aspose.Slides.Charts.IChartSeries series2 = chart.ChartData.Series.Add(
            workbook.GetCell(0, 0, 2, "Series 2"), chart.Type);
        series2.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 0, 2, 40));
        series2.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 2, 50));

        // Remove the first series from the chart
        chart.ChartData.Series.RemoveAt(0);

        // Save the presentation
        presentation.Save("ChartSeriesDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}