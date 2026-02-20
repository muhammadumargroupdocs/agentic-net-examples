using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Define output file path
        string outPath = "Output/RectanglePosition.pptx";
        string outDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(outPath));
        if (!System.IO.Directory.Exists(outDir))
            System.IO.Directory.CreateDirectory(outDir);

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle shape positioned at (100, 200) with width 300 and height 100
        slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100f, 200f, 300f, 100f);

        // Save the presentation
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}