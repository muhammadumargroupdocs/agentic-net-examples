using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 200);

        // Set the fill format to a solid brush with a custom color
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = Color.FromArgb(255, 100, 150, 200);

        // Set the line format to a solid black brush
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = Color.Black;
        shape.LineFormat.Width = 2;

        // Save the presentation in PPT format
        string outPath = "BrushPropertiesDemo.ppt";
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation
        presentation.Dispose();
    }
}