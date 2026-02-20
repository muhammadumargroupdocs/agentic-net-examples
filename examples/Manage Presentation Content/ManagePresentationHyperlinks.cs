using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.ppt";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape with some text
        Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);
        shape.TextFrame.Text = "Click here";

        // Set an external hyperlink on click for the shape
        shape.HyperlinkManager.SetExternalHyperlinkClick("https://www.example.com");

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up
        presentation.Dispose();
    }
}