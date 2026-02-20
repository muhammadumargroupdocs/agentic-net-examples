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

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Get the chart's data workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Set cell values and a formula (A1=10, B1=20, C1=A1+B1)
        workbook.GetCell(0, 0, 0).Value = 10;
        workbook.GetCell(0, 0, 1).Value = 20;
        workbook.GetCell(0, 0, 2).Formula = "A1+B1";

        // Calculate all formulas in the workbook
        workbook.CalculateFormulas();

        // Retrieve and display the result of the formula
        object result = workbook.GetCell(0, 0, 2).Value;
        Console.WriteLine("Result of formula A1+B1: " + result);

        // Save the presentation
        string outPath = Path.Combine(Directory.GetCurrentDirectory(), "FormulaResult.pptx");
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}