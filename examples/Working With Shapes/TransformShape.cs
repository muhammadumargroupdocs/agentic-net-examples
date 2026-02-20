using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide (created by default)
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape to the slide
        Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 200, 100);
        shape.Name = "OriginalShape";
        shape.TextFrame.Text = "Hello";

        // Move the shape to a new position
        shape.X = 150;
        shape.Y = 150;

        // Rotate the shape by 45 degrees
        shape.Rotation = 45;

        // Scale the shape by increasing its width and height by 150%
        shape.Width = shape.Width * 1.5f;
        shape.Height = shape.Height * 1.5f;

        // Clone the shape and place the clone at a different location
        Aspose.Slides.IShape clonedShape = slide.Shapes.AddClone(shape);
        clonedShape.X = 400;
        clonedShape.Y = 150;
        clonedShape.Name = "ClonedShape";

        // Save the presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}