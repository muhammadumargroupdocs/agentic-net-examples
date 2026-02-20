using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50f,   // X position
            50f,   // Y position
            400f,  // Width
            200f   // Height
        );

        // Add a text frame with three paragraphs (separated by line breaks)
        Aspose.Slides.ITextFrame textFrame = rect.AddTextFrame("Paragraph 1\r\nParagraph 2\r\nParagraph 3");
        textFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Shape;

        // First paragraph
        Aspose.Slides.IParagraph para1 = textFrame.Paragraphs[0];
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226); // bullet character
        para1.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para1.ParagraphFormat.Depth = (short)0;
        para1.ParagraphFormat.Indent = 20f;

        // Second paragraph
        Aspose.Slides.IParagraph para2 = textFrame.Paragraphs[1];
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para2.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226);
        para2.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para2.ParagraphFormat.Depth = (short)0;
        para2.ParagraphFormat.Indent = 40f;

        // Third paragraph
        Aspose.Slides.IParagraph para3 = textFrame.Paragraphs[2];
        para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para3.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226);
        para3.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para3.ParagraphFormat.Depth = (short)0;
        para3.ParagraphFormat.Indent = 60f;

        // Save the presentation
        presentation.Save("ParagraphIndent.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}