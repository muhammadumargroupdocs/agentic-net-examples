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
        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 200);
        // Add a text frame with two paragraphs
        autoShape.AddTextFrame("First paragraph.\nSecond paragraph.");
        // Get the text frame
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;
        // Align the first paragraph to center
        Aspose.Slides.IParagraph paragraph1 = textFrame.Paragraphs[0];
        paragraph1.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Center;
        // Align the second paragraph to justify low (if it exists)
        if (textFrame.Paragraphs.Count > 1)
        {
            Aspose.Slides.IParagraph paragraph2 = textFrame.Paragraphs[1];
            paragraph2.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.JustifyLow;
        }
        // Save the presentation as PPTX
        presentation.Save("AlignedParagraphs.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose the presentation
        presentation.Dispose();
    }
}