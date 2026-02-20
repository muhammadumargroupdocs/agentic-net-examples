using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape to hold text
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 500, 300);
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Remove the default empty paragraph
        textFrame.Paragraphs.RemoveAt(0);

        // First level bullet (depth 0)
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
        para1.Text = "First level item";
        para1.ParagraphFormat.Depth = 0;
        textFrame.Paragraphs.Add(para1);

        // Second level bullet (depth 1)
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para2.ParagraphFormat.Bullet.Char = Convert.ToChar(8226);
        para2.Text = "Second level item";
        para2.ParagraphFormat.Depth = 1;
        textFrame.Paragraphs.Add(para2);

        // Third level bullet (depth 2)
        Aspose.Slides.Paragraph para3 = new Aspose.Slides.Paragraph();
        para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para3.ParagraphFormat.Bullet.Char = Convert.ToChar(8226);
        para3.Text = "Third level item";
        para3.ParagraphFormat.Depth = 2;
        textFrame.Paragraphs.Add(para3);

        // Save the presentation as PPTX
        presentation.Save(Path.Combine(outDir, "MultilevelBullets.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}