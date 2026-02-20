using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output file path
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "CustomNumberedList.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape to hold the text
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300);
        Aspose.Slides.ITextFrame textFrame = shape.TextFrame;

        // Remove the default empty paragraph
        textFrame.Paragraphs.RemoveAt(0);

        // First numbered paragraph
        Aspose.Slides.Paragraph paragraph1 = new Aspose.Slides.Paragraph();
        paragraph1.Text = "First item";
        paragraph1.ParagraphFormat.Depth = 0;
        paragraph1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph1.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)1;
        textFrame.Paragraphs.Add(paragraph1);

        // Second numbered paragraph
        Aspose.Slides.Paragraph paragraph2 = new Aspose.Slides.Paragraph();
        paragraph2.Text = "Second item";
        paragraph2.ParagraphFormat.Depth = 0;
        paragraph2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph2.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)2;
        textFrame.Paragraphs.Add(paragraph2);

        // Third numbered paragraph
        Aspose.Slides.Paragraph paragraph3 = new Aspose.Slides.Paragraph();
        paragraph3.Text = "Third item";
        paragraph3.ParagraphFormat.Depth = 0;
        paragraph3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph3.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)3;
        textFrame.Paragraphs.Add(paragraph3);

        // Save the presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}