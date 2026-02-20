using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

        // Add a text frame to the shape
        shape.AddTextFrame("Sample text for autofit demonstration.");

        // Get the text frame
        Aspose.Slides.ITextFrame txtFrame = shape.TextFrame;

        // Set autofit type to Shape
        txtFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Shape;

        // Set text color to black
        Aspose.Slides.IParagraph para = txtFrame.Paragraphs[0];
        Aspose.Slides.IPortion portion = para.Portions[0];
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Black;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "AutofitDemo.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}