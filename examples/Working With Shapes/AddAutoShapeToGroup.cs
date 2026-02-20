using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create output directory
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

        // Add initial auto shapes to the group
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 100, 100);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 200, 50, 100, 100);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 350, 50, 100, 100);
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 500, 50, 100, 100);

        // Add another auto shape to the same group
        group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 650, 50, 100, 100);

        // Set the frame of the group shape
        group.Frame = new Aspose.Slides.ShapeFrame(0, 0, 800, 200, Aspose.Slides.NullableBool.False, Aspose.Slides.NullableBool.False, 0);

        // Save the presentation
        pres.Save(outDir + "GroupShapeExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}