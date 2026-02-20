using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 150, 300, 150);
        shape.AddTextFrame("");

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame textFrame = shape.TextFrame;

        // Create a new paragraph
        Aspose.Slides.IParagraph newParagraph = new Aspose.Slides.Paragraph();

        // Create a portion with text
        Aspose.Slides.IPortion portion = new Aspose.Slides.Portion();
        portion.Text = "This is a new paragraph added to the text frame.";

        // Add the portion to the paragraph
        newParagraph.Portions.Add(portion);

        // Add the paragraph to the text frame
        textFrame.Paragraphs.Add(newParagraph);

        // Save the presentation
        string outPath = "AddParagraph.pptx";
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Open the saved file
        Process.Start(new ProcessStartInfo(outPath) { UseShellExecute = true });
    }
}