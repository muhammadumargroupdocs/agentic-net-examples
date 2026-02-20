using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Output directory and file path
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);
        string outPath = Path.Combine(outDir, "NoAutofit.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape with some text
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 100);
        shape.AddTextFrame("This is a sample text that might need autofit.");

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame txtFrame = shape.TextFrame;

        // Disable autofit (set to None)
        txtFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.None;

        // Save the presentation as PPTX
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}