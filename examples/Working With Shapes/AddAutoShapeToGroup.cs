using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output directory
        string outDir = "Output" + System.IO.Path.DirectorySeparatorChar;
        if (!System.IO.Directory.Exists(outDir))
            System.IO.Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Get shape collection of the slide
        Aspose.Slides.IShapeCollection shapes = slide.Shapes;

        // Add a group shape to the slide
        Aspose.Slides.IGroupShape group = shapes.AddGroupShape();

        // Add an auto shape (rectangle) to the group
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 150, 100);

        // Set the frame of the group shape
        group.Frame = new Aspose.Slides.ShapeFrame(0, 0, 300, 200, Aspose.Slides.NullableBool.False, Aspose.Slides.NullableBool.False, 0);

        // Save the presentation
        pres.Save(outDir + "GroupShapeExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}