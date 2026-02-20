using System;
using System.IO;

namespace ChartFormulasExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a clustered column chart at specified position and size
            Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

            // Access the chart's data workbook
            Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Set a formula in cell B1 (sheet 0, row 0, column 1)
            workbook.GetCell(0, 0, 1).Formula = "SUM(C1:D1)";

            // Set values in cells C1 and D1 (sheet 0, row 0, columns 2 and 3)
            workbook.GetCell(0, 0, 2).Value = 30;
            workbook.GetCell(0, 0, 3).Value = 70;

            // Calculate all formulas in the workbook
            workbook.CalculateFormulas();

            // Save the presentation to the current directory
            string outPath = Path.Combine(Directory.GetCurrentDirectory(), "ChartFormulas.pptx");
            presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}