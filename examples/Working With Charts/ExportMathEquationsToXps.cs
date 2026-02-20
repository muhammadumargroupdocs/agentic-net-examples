using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output PPTX path
        string outputPath = "ExportMathEquations.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a bubble chart
        Aspose.Slides.Charts.IChart chart = (Aspose.Slides.Charts.IChart)presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f, true);

        // Access the first series
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];
        series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

        // Get the workbook associated with the chart
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

        // Populate cells with labels
        workbook.GetCell(0, "A10", "Label 1");
        workbook.GetCell(0, "A11", "Label 2");
        workbook.GetCell(0, "A12", "Label 3");

        // Assign data labels from workbook cells
        series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "Label 1");
        series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Label 2");
        series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Label 3");

        // Save the presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Export the presentation to XPS format
        string xpsPath = "ExportMathEquations.xps";
        presentation.Save(xpsPath, Aspose.Slides.Export.SaveFormat.Xps);
    }
}