using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Presentation presentation = new Presentation();

        // Define output path
        string outputPath = "ChartWorkbookDataLabel.pptx";

        // Add a bubble chart
        IChart chart = (IChart)presentation.Slides[0].Shapes.AddChart(ChartType.Bubble, 50f, 50f, 600f, 400f, true);

        // Get the first series
        IChartSeries series = chart.ChartData.Series[0];

        // Enable data label values from cells
        series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

        // Access the chart's data workbook
        IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Populate cells with label values
        workbook.GetCell(0, "A10", "First");
        workbook.GetCell(0, "A11", "Second");
        workbook.GetCell(0, "A12", "Third");

        // Assign cell values to data labels
        series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "First");
        series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Second");
        series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Third");

        // Save the presentation
        presentation.Save(outputPath, SaveFormat.Pptx);
    }
}