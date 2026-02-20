using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ShapeScalingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle shape to the first slide
            Aspose.Slides.IAutoShape rectangle = presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                50f,   // X position
                50f,   // Y position
                100f,  // Width
                50f    // Height
            );

            // Scale the shape's width and height by 150%
            rectangle.Width *= 1.5f;
            rectangle.Height *= 1.5f;

            // Save the presentation
            presentation.Save("ScaledShape.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up resources
            presentation.Dispose();
        }
    }
}