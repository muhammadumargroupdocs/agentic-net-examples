using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 400, 100);

        // Add a text frame with sample text
        autoShape.AddTextFrame("Rotated Text");

        // Get the text frame
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Set custom rotation angle for the text (e.g., 45 degrees)
        textFrame.TextFrameFormat.RotationAngle = 45f;

        // Save the presentation as PPTX
        presentation.Save("RotatedText.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}