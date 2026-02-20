using System;
using System.IO;
using System.Drawing;
using Aspose.Slides.Export;

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

        // Add a rectangle shape to hold the text
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 500, 300);

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Remove the default empty paragraph
        textFrame.Paragraphs.RemoveAt(0);

        // First bullet point
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
        para1.Text = "Clarity";
        para1.ParagraphFormat.Indent = 20;
        textFrame.Paragraphs.Add(para1);

        // Second bullet point
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para2.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
        para2.Text = "Organization";
        para2.ParagraphFormat.Indent = 20;
        textFrame.Paragraphs.Add(para2);

        // Third bullet point
        Aspose.Slides.Paragraph para3 = new Aspose.Slides.Paragraph();
        para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para3.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // •
        para3.Text = "Emphasis";
        para3.ParagraphFormat.Indent = 20;
        textFrame.Paragraphs.Add(para3);

        // Save the presentation as PPTX
        string outputPath = Path.Combine(outDir, "BulletList.pptx");
        presentation.Save(outputPath, SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}