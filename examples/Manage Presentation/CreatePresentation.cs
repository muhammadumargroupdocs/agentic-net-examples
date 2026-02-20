using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a line shape to the slide
        slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Line, 50, 150, 300, 0);

        // Prepare output directory and file path
        string outDir = "Output";
        if (!Directory.Exists(outDir))
        {
            Directory.CreateDirectory(outDir);
        }
        string pptxPath = Path.Combine(outDir, "CreatedPresentation.pptx");

        // Save the presentation in PPTX format
        presentation.Save(pptxPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}