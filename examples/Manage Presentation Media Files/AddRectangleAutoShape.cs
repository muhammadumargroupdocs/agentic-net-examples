using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define output directory
        string dataDir = "Data";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle AutoShape
        slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50f, 150f, 150f, 50f);

        // Save the presentation
        string outPath = Path.Combine(dataDir, "SimpleRectangle.pptx");
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}