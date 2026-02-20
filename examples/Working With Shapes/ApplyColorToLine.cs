using System;
using Aspose.Slides;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a line shape to the slide
        Aspose.Slides.IAutoShape line = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Line, 50, 150, 300, 0);

        // Set line style properties
        line.LineFormat.Style = Aspose.Slides.LineStyle.ThickBetweenThin;
        line.LineFormat.Width = 10;
        line.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;
        line.LineFormat.BeginArrowheadLength = Aspose.Slides.LineArrowheadLength.Short;
        line.LineFormat.BeginArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Oval;
        line.LineFormat.EndArrowheadLength = Aspose.Slides.LineArrowheadLength.Long;
        line.LineFormat.EndArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Triangle;

        // Apply solid color to the line
        line.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        line.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Maroon;

        // Save the presentation
        string outputPath = "LineColorExample.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}