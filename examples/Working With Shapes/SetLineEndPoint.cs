using System;
using Aspose.Slides;
using Aspose.Slides.Export;
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
        Aspose.Slides.IAutoShape line = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Line, 50, 150, 300, 0);

        // Configure line formatting
        line.LineFormat.Style = Aspose.Slides.LineStyle.ThickBetweenThin;
        line.LineFormat.Width = 10;
        line.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;
        line.LineFormat.BeginArrowheadLength = Aspose.Slides.LineArrowheadLength.Short;
        line.LineFormat.BeginArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Oval;
        line.LineFormat.EndArrowheadLength = Aspose.Slides.LineArrowheadLength.Long;
        line.LineFormat.EndArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Triangle;
        line.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        line.LineFormat.FillFormat.SolidFillColor.Color = Color.Maroon;

        // Set the end point of the line by adjusting its width (and height if needed)
        line.Width = 400; // new length of the line
        line.Height = 0;  // keep the line horizontal

        // Save the presentation
        string outputPath = "SetLineEndPoint.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}