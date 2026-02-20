using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace ChartCustomizationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Define output file path
            string outputPath = "ChartDataLabel.pptx";

            // Add a Bubble chart to the first slide
            Aspose.Slides.Charts.IChart chart = (Aspose.Slides.Charts.IChart)presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f, true);

            // Access the first series of the chart
            Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

            // Enable data labels to show values from workbook cells
            series.Labels.DefaultDataLabelFormat.ShowLabelValueFromCell = true;

            // Get the workbook associated with the chart
            Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Populate cells with label text
            workbook.GetCell(0, "A10", "First");
            workbook.GetCell(0, "A11", "Second");
            workbook.GetCell(0, "A12", "Third");

            // Assign cells to data labels
            series.Labels[0].ValueFromCell = workbook.GetCell(0, "A10", "First");
            series.Labels[1].ValueFromCell = workbook.GetCell(0, "A11", "Second");
            series.Labels[2].ValueFromCell = workbook.GetCell(0, "A12", "Third");

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}