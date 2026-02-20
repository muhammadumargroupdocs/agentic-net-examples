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

        // Add a pie chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 500);

        // Access the embedded workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Iterate through worksheets and display their names
        foreach (Aspose.Slides.Charts.IChartDataWorksheet worksheet in workbook.Worksheets)
        {
            Console.WriteLine("Worksheet name: " + worksheet.Name);
        }

        // Save the presentation
        presentation.Save("EmbeddedWorkbookExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}