using System;

namespace PresentationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape
            Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

            // Add a text frame with the word "Overview"
            autoShape.AddTextFrame("Overview");

            // Define output path
            string outputPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "OverviewPresentation.pptx");

            // Save the presentation as PPTX
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}