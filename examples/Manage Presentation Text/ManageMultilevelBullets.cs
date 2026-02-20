using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManageMultilevelBullets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output directory
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape to hold text
            Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300);

            // Get the text frame of the shape
            Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

            // Remove the default empty paragraph
            textFrame.Paragraphs.RemoveAt(0);

            // First level bullet (symbol)
            Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
            para1.Text = "Level 1 Bullet";
            para1.ParagraphFormat.Depth = 0;
            para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
            para1.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
            para1.ParagraphFormat.Indent = 20;
            textFrame.Paragraphs.Add(para1);

            // Second level bullet (symbol)
            Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
            para2.Text = "Level 2 Bullet";
            para2.ParagraphFormat.Depth = 1;
            para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
            para2.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
            para2.ParagraphFormat.Indent = 40;
            textFrame.Paragraphs.Add(para2);

            // Second level numbered bullet
            Aspose.Slides.Paragraph para3 = new Aspose.Slides.Paragraph();
            para3.Text = "Level 2 Numbered";
            para3.ParagraphFormat.Depth = 1;
            para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
            para3.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)1;
            para3.ParagraphFormat.Indent = 40;
            textFrame.Paragraphs.Add(para3);

            // Save the presentation as PPTX
            presentation.Save(Path.Combine(outDir, "MultilevelBullets.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}