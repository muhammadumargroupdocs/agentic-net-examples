using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace ChartExportDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a Pie chart to the first slide
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 500);

            // Access the chart's data workbook (optional, shown for completeness)
            Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Save the presentation in PPTX format (supported export format)
            presentation.Save("ExportFormatsDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}