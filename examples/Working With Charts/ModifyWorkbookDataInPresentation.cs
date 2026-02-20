using System;

class Program
{
    static void Main(string[] args)
    {
        // Define output file path
        string outputPath = "ModifiedChart.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a Bubble chart to the first slide
        Aspose.Slides.Charts.IChart chart = (Aspose.Slides.Charts.IChart)presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f, true);

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Enable data labels to show values from workbook cells
        series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

        // Access the embedded workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Populate cells with label text
        workbook.GetCell(0, "A10", "First Label");
        workbook.GetCell(0, "A11", "Second Label");
        workbook.GetCell(0, "A12", "Third Label");

        // Assign cell values to data labels
        series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "First Label");
        series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Second Label");
        series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Third Label");

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}