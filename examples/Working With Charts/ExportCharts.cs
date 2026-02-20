using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output file path
        System.String outputPath = "ExportChart.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a pie chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 500);

        // Access the chart's data workbook (optional)
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}