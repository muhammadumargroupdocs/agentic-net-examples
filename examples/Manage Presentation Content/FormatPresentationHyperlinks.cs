using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String inputPath = "input.ppt";
        System.String outputPath = "output.ppt";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape with text
        Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);
        autoShape.TextFrame.Text = "Visit Aspose";

        // Set an external hyperlink on click for the shape
        Aspose.Slides.IHyperlinkContainer hyperlinkContainer = (Aspose.Slides.IHyperlinkContainer)autoShape;
        hyperlinkContainer.HyperlinkManager.SetExternalHyperlinkClick("https://www.aspose.com");

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up resources
        presentation.Dispose();
    }
}