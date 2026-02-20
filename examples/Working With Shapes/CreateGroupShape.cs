using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output" + Path.DirectorySeparatorChar;
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Get the shape collection of the slide
        Aspose.Slides.IShapeCollection shapes = slide.Shapes;

        // Add a group shape to the collection
        Aspose.Slides.IGroupShape group = shapes.AddGroupShape();

        // Add rectangles to the group shape
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 50, 50);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 150, 150, 50, 50);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 250, 250, 50, 50);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 350, 350, 50, 50);

        // Set the frame of the group shape
        group.Frame = new Aspose.Slides.ShapeFrame(100, 100, 400, 400, Aspose.Slides.NullableBool.False, Aspose.Slides.NullableBool.False, 0);

        // Save the presentation
        pres.Save(outDir + "GroupShapeExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}