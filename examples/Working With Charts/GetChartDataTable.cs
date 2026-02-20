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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Clear default series and categories
        chart.ChartData.Series.Clear();
        chart.ChartData.Categories.Clear();

        // Get the chart data workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Add categories
        chart.ChartData.Categories.Add(workbook.GetCell(0, "A1", "Category 1"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, "A2", "Category 2"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, "A3", "Category 3"));

        // Add a series and populate data points
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series.Add(workbook.GetCell(0, "B1", "Series 1"), chart.Type);
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, "B2", 20));
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, "B3", 50));
        series.DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, "B4", 30));

        // Enable and configure the data table for the chart
        chart.HasDataTable = true;
        chart.ChartDataTable.HasBorderOutline = true;
        chart.ChartDataTable.HasBorderHorizontal = true;
        chart.ChartDataTable.HasBorderVertical = true;

        // Save the presentation
        presentation.Save("ChartDataTableOverview.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}