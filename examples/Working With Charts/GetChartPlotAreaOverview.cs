using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Create a new presentation
        Presentation presentation = new Presentation();

        // Add a clustered column chart to the first slide
        Chart chart = (Chart)presentation.Slides[0].Shapes.AddChart(
            ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Validate layout to obtain actual plot area dimensions
        chart.ValidateChartLayout();

        // Retrieve actual plot area coordinates and size
        double actualX = chart.PlotArea.ActualX;
        double actualY = chart.PlotArea.ActualY;
        double actualWidth = chart.PlotArea.ActualWidth;
        double actualHeight = chart.PlotArea.ActualHeight;

        // Example usage: output the values to the console
        Console.WriteLine($"Plot Area - X: {actualX}, Y: {actualY}, Width: {actualWidth}, Height: {actualHeight}");

        // Save the presentation
        presentation.Save(outputPath, SaveFormat.Pptx);
    }
}