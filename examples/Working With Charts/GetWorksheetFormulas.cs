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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 400, 300);

        // Access the chart's data workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Set a formula in a cell (B2)
        workbook.GetCell(0, 1, 1).Formula = "=SUM(B3:B5)";

        // Set values in cells that the formula will sum
        workbook.GetCell(0, 2, 1).Value = 10;
        workbook.GetCell(0, 3, 1).Value = 20;
        workbook.GetCell(0, 4, 1).Value = 30;

        // Calculate all formulas in the workbook
        workbook.CalculateFormulas();

        // Save the presentation
        string outPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "ChartFormulas.pptx");
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}