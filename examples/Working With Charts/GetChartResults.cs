using System;

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

        // Access the chart's workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Set a formula in cell (row 1, column 1) -> A2 (using zero-based indices)
        workbook.GetCell(0, 1, 1).Formula = "=SUM(B2:B3)";

        // Set values in cells B2 and B3 (row 1, column 2) and (row 2, column 2)
        workbook.GetCell(0, 1, 2).Value = 10;
        workbook.GetCell(0, 2, 2).Value = 20;

        // Calculate all formulas in the workbook
        workbook.CalculateFormulas();

        // Retrieve the calculated result from the formula cell
        Aspose.Slides.Charts.IChartDataCell resultCell = workbook.GetCell(0, 1, 1);
        object resultValue = resultCell.Value;

        // Output the result
        Console.WriteLine("Calculated sum: " + resultValue);

        // Save the presentation
        presentation.Save("ChartWithCalculatedFormula.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}