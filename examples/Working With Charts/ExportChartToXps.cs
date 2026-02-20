using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a pie chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, 50f, 50f, 400f, 300f);

        // Configure XPS export options
        Aspose.Slides.Export.XpsOptions xpsOptions = new Aspose.Slides.Export.XpsOptions();
        xpsOptions.DrawSlidesFrame = true; // Draw a frame around each slide

        // Save the presentation as XPS
        presentation.Save("ChartOutput.xps", Aspose.Slides.Export.SaveFormat.Xps, xpsOptions);
    }
}