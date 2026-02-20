class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 500, 400);

        // Get the workbook that holds the chart data
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Set a formula in a cell (row 0, column 0)
        workbook.GetCell(0, 0, 0).Formula = "SUM(1,2,3)";

        // Set static values in other cells
        workbook.GetCell(0, 1, 0).Value = 10;
        workbook.GetCell(0, 2, 0).Value = 20;

        // Calculate all formulas in the workbook
        workbook.CalculateFormulas();

        // Save the presentation
        presentation.Save("CalculatedChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}