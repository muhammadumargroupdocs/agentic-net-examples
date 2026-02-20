using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

public class Program
{
    public static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
        {
            Directory.CreateDirectory(outDir);
        }

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        Aspose.Slides.ITextFrame txtFrame = rect.TextFrame;

        // Remove the default empty paragraph
        txtFrame.Paragraphs.RemoveAt(0);

        // Add a paragraph with a symbol bullet
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226); // •
        para1.Text = "Symbol bullet paragraph";
        para1.ParagraphFormat.Indent = 20f;
        txtFrame.Paragraphs.Add(para1);

        // Add a paragraph with a numbered bullet
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        para2.ParagraphFormat.Bullet.NumberedBulletStyle = Aspose.Slides.NumberedBulletStyle.BulletCircleNumWDBlackPlain;
        para2.Text = "Numbered bullet paragraph";
        para2.ParagraphFormat.Indent = 20f;
        txtFrame.Paragraphs.Add(para2);

        // Save the presentation as PPTX
        string outputPath = System.IO.Path.Combine(outDir, "ManagedBullets.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}