using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.IO;

namespace RotateShapeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Define output file path
            System.String outPath = "RotatedShape.pptx";

            // Ensure output directory exists
            System.String outDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(outPath));
            if (!System.IO.Directory.Exists(outDir))
                System.IO.Directory.CreateDirectory(outDir);

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Add a rectangle shape
            Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);

            // Set rotation angle (degrees)
            shape.Rotation = 45;

            // Save the presentation
            pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}