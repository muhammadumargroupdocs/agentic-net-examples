using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle shape to the slide
        Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, // shape type
            50,    // X position
            50,    // Y position
            200,   // Width
            100);  // Height

        // Set the fill type to solid and assign a color
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;

        // Save the presentation
        pres.Save("ShapeFillSolid.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        pres.Dispose();
    }
}