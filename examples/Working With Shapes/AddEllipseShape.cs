using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Access the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add an ellipse shape to the slide
            Aspose.Slides.IShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 100, 100, 300, 150);

            // Set the fill of the ellipse to solid chocolate color
            shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.Chocolate;

            // Set the line format to solid black with a width of 5 points
            shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            shape.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
            shape.LineFormat.Width = 5;

            // Save the presentation to a PPTX file
            string outputPath = "FormattedEllipse.pptx";
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}