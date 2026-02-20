using System;
using Aspose.Slides;

namespace ShapeOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle auto shape to the first slide
            Aspose.Slides.AutoShape rectangle = (Aspose.Slides.AutoShape)presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50f, 50f, 100f, 100f);

            // Move the shape to a new position
            rectangle.X = 150f;
            rectangle.Y = 150f;

            // Rotate the shape by 45 degrees
            rectangle.Rotation = 45f;

            // Scale the shape by 150%
            rectangle.Width = rectangle.Width * 1.5f;
            rectangle.Height = rectangle.Height * 1.5f;

            // Clone the shape to a different location on the same slide
            Aspose.Slides.IShape clonedShape = presentation.Slides[0].Shapes.AddClone(rectangle, 300f, 300f);

            // Save the presentation
            presentation.Save("ShapeOperationsOutput.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}