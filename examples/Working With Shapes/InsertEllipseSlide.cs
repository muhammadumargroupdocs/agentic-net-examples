using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add an ellipse shape to the slide
        Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 100, 100, 200, 100);

        // Format the ellipse
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = Color.Chocolate;
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = Color.Black;
        shape.LineFormat.Width = 5;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "EllipseDemo.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}