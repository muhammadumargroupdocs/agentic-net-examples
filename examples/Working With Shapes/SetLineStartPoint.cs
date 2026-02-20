using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load an existing presentation
        System.String filePath = "input.pptx";
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(filePath);

        // Get the shape collection of the first slide
        Aspose.Slides.IShapeCollection shapes = presentation.Slides[0].Shapes;

        // Add a line shape (initially at (100,100) with length 200)
        Aspose.Slides.IAutoShape line = (Aspose.Slides.IAutoShape)shapes.AddAutoShape(Aspose.Slides.ShapeType.Line, 100, 100, 200, 0);

        // Set the start point of the line
        line.X = 150; // new X coordinate
        line.Y = 150; // new Y coordinate

        // Save the presentation
        System.String outputPath = "output.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}