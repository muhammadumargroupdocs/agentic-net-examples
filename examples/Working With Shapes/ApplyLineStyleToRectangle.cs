using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];
        // Add a rectangle shape
        Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 200, 100);
        // Set shape fill to white
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.White;
        // Apply line style to the rectangle
        shape.LineFormat.Style = Aspose.Slides.LineStyle.ThickThin;
        shape.LineFormat.Width = 5;
        shape.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.Dash;
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
        // Save the presentation
        string outputPath = "FormattedRectangle.pptx";
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}