using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Ensure the output directory exists
        string outputDir = "Output";
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle auto shape to the slide
        Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50,   // X position
            150,  // Y position
            150,  // Width
            50    // Height
        );

        // Save the presentation
        string outputPath = Path.Combine(outputDir, "AddRectangle.pptx");
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}