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
        Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 200);

        // Add a text frame with three paragraphs
        Aspose.Slides.ITextFrame textFrame = rect.AddTextFrame("First paragraph\nSecond paragraph\nThird paragraph");

        // Set autofit type for the text frame
        textFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Shape;

        // Configure first paragraph
        Aspose.Slides.IParagraph para1 = textFrame.Paragraphs[0];
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226); // bullet character
        para1.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para1.ParagraphFormat.Depth = 0;
        para1.ParagraphFormat.Indent = 20f;

        // Configure second paragraph
        Aspose.Slides.IParagraph para2 = textFrame.Paragraphs[1];
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para2.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226);
        para2.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para2.ParagraphFormat.Depth = 0;
        para2.ParagraphFormat.Indent = 30f;

        // Configure third paragraph
        Aspose.Slides.IParagraph para3 = textFrame.Paragraphs[2];
        para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para3.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226);
        para3.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Left;
        para3.ParagraphFormat.Depth = 0;
        para3.ParagraphFormat.Indent = 40f;

        // Save the presentation as PPTX
        presentation.Save("ParagraphIndentDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}