using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Clear any default series and categories
        chart.ChartData.Series.Clear();
        chart.ChartData.Categories.Clear();

        // Get the workbook to create cells
        Aspose.Slides.Charts.IChartDataWorkbook wb = chart.ChartData.ChartDataWorkbook;

        // Add categories
        chart.ChartData.Categories.Add(wb.GetCell(0, 0, 0, "Category 1"));
        chart.ChartData.Categories.Add(wb.GetCell(0, 1, 0, "Category 2"));

        // Add two series
        chart.ChartData.Series.Add(wb.GetCell(0, 0, 1, "Series 1"), chart.Type);
        chart.ChartData.Series.Add(wb.GetCell(0, 0, 2, "Series 2"), chart.Type);

        // Add data points for each series
        chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(wb.GetCell(0, 0, 1, 20));
        chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(wb.GetCell(0, 1, 1, 30));
        chart.ChartData.Series[1].DataPoints.AddDataPointForBarSeries(wb.GetCell(0, 0, 2, 40));
        chart.ChartData.Series[1].DataPoints.AddDataPointForBarSeries(wb.GetCell(0, 1, 2, 50));

        // Save the presentation
        presentation.Save("MultipleSeriesChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}