using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a doughnut chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.Doughnut, 50f, 50f, 400f, 300f);

        // Remove default series and categories
        chart.ChartData.Series.Clear();
        chart.ChartData.Categories.Clear();

        // Access the chart's data workbook
        Aspose.Slides.Charts.IChartDataWorkbook wb = chart.ChartData.ChartDataWorkbook;

        // Add categories
        chart.ChartData.Categories.Add(wb.GetCell(0, 0, 0, "Category 1"));
        chart.ChartData.Categories.Add(wb.GetCell(0, 0, 1, "Category 2"));

        // Add a series
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series.Add(wb.GetCell(0, 1, 0, "Series 1"), chart.Type);

        // Add data points for the series
        series.DataPoints.AddDataPointForDoughnutSeries(wb.GetCell(0, 1, 1, 30));
        series.DataPoints.AddDataPointForDoughnutSeries(wb.GetCell(0, 1, 2, 70));

        // Set the doughnut hole size
        series.ParentSeriesGroup.DoughnutHoleSize = (byte)50;

        // Save the presentation
        pres.Save("ChartDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}