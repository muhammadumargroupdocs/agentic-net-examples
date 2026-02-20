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

        // Add a rectangle AutoShape with specified position and size
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 200);

        // Add a text frame with initial text
        shape.AddTextFrame("Initial text");

        // Get the text frame
        Aspose.Slides.ITextFrame txtFrame = shape.TextFrame;

        // Set autofit type to Shape (shape will resize to fit text)
        txtFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Shape;

        // Access first paragraph and portion
        Aspose.Slides.IParagraph paragraph = txtFrame.Paragraphs[0];
        Aspose.Slides.IPortion portion = paragraph.Portions[0];

        // Set the portion text
        portion.Text = "This is a sample text that demonstrates AutoFit functionality in Aspose.Slides.";

        // Set text color to black
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Black;

        // Save the presentation as PPTX
        presentation.Save("AutoFitDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}