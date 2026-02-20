using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle shape at initial position (50, 50) with size 100x100
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 100, 100);

        // Move the shape to new coordinates (200, 150)
        shape.X = 200;
        shape.Y = 150;

        // Save the presentation before exiting
        string outPath = "MoveShape.pptx";
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}