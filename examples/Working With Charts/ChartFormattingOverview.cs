using System;

class Program
{
    static void Main(string[] args)
    {
        // Output file path
        string outputPath = "ChartFormattingOverview.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a Bubble chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f, true);

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Example of formatting the series via its parent series group
        series.ParentSeriesGroup.Overlap = 20;      // Bars overlap
        series.ParentSeriesGroup.GapWidth = 150;    // Gap width between bars

        // Enable data labels to show values from workbook cells
        series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

        // Access the embedded workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Create cells with label text
        workbook.GetCell(0, "A10", "First label");
        workbook.GetCell(0, "A11", "Second label");
        workbook.GetCell(0, "A12", "Third label");

        // Assign the cells to the data labels
        series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "First label");
        series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Second label");
        series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Third label");

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}