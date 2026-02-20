using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output file path
        string outputPath = "AddDataChart.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a bubble chart to the first slide
        Aspose.Slides.Charts.IChart chart = (Aspose.Slides.Charts.IChart)presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f, true);

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Enable data labels to be taken from workbook cells
        series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

        // Access the chart's embedded workbook
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Populate cells with label text
        workbook.GetCell(0, "A10", "Label A");
        workbook.GetCell(0, "A11", "Label B");
        workbook.GetCell(0, "A12", "Label C");

        // Assign the cells to the data labels
        series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "Label A");
        series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Label B");
        series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Label C");

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}