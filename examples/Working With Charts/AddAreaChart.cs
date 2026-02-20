using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output file path
        string outputPath = "AreaChart.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add an Area chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Area,
            50f, 50f, 600f, 400f, true);

        // Set the horizontal axis major unit scale to None (time unit type)
        chart.Axes.HorizontalAxis.MajorUnitScale = Aspose.Slides.Charts.TimeUnitType.None;

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}