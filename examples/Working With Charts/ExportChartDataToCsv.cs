using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a pie chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, 50f, 50f, 400f, 300f);

        // Access the embedded workbook for the chart
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Clear any existing data
        workbook.Clear(0);
        chart.ChartData.Categories.Clear();
        chart.ChartData.Series.Clear();

        // Add categories
        Aspose.Slides.Charts.IChartCategory category1 = chart.ChartData.Categories.Add(
            workbook.GetCell(0, "A1", "Category 1"));
        Aspose.Slides.Charts.IChartCategory category2 = chart.ChartData.Categories.Add(
            workbook.GetCell(0, "A2", "Category 2"));

        // Add a series and data points
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series.Add(
            Aspose.Slides.Charts.ChartType.Pie);
        series.DataPoints.AddDataPointForPieSeries(workbook.GetCell(0, "B1", 30));
        series.DataPoints.AddDataPointForPieSeries(workbook.GetCell(0, "B2", 70));

        // Export chart data to CSV
        string csvPath = "ChartData.csv";
        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(csvPath))
        {
            // Write CSV header
            writer.WriteLine("Category,Value");

            // Write each category and its corresponding value
            for (int i = 0; i < chart.ChartData.Categories.Count; i++)
            {
                string category = chart.ChartData.Categories[i].Value.ToString();
                object value = series.DataPoints[i].Value.Data;
                writer.WriteLine($"{category},{value}");
            }
        }

        // Save the presentation
        presentation.Save("ChartPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}