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
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 500f, 400f);

        // Remove default series and categories
        chart.ChartData.Series.Clear();
        chart.ChartData.Categories.Clear();

        // Get the workbook for creating cells
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Add categories
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 0, "Category 1"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 1, "Category 2"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 2, "Category 3"));

        // Add a new series
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series.Add(
            workbook.GetCell(0, 1, 0, "Series 1"),
            chart.Type);

        // Add data points to the series
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 0, 20));
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 1, 50));
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 2, 30));

        // Modify some writable properties of the series
        series.Order = 1;                     // Change the order of the series
        series.InvertIfNegative = true;       // Invert colors for negative values

        // Save the presentation
        presentation.Save("ModifiedSeries.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}