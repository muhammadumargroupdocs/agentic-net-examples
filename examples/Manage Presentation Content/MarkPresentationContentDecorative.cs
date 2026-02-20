using System;
using System.IO;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 150);

        // Mark the shape as decorative
        autoShape.IsDecorative = true;

        // Save the presentation in PPT format
        presentation.Save(Path.Combine(outDir, "DecorativeShape.ppt"), Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation
        presentation.Dispose();
    }
}