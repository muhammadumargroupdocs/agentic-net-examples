using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle auto shape to the slide
        Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50,   // X position
            50,   // Y position
            200,  // Width
            100   // Height
        );

        // Set shape properties
        rect.Name = "CustomRectangle";
        rect.AlternativeText = "This is a custom shape";

        // Save the presentation
        string outPath = "CustomShapePresentation.pptx";
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}