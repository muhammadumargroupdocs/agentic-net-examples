using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Add a rectangle shape (custom shape) at position (100,100) with size 400x200
        Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 400, 200);
        // Apply solid fill to the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        // Set the fill color to Blue
        shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
        // Save the presentation
        presentation.Save("CustomShapeFill.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        // Clean up resources
        presentation.Dispose();
    }
}