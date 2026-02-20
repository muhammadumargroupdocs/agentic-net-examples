using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape to hold text
        float x = 50f;
        float y = 50f;
        float width = 400f;
        float height = 200f;
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, x, y, width, height);

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Remove the default empty paragraph
        textFrame.Paragraphs.RemoveAt(0);

        // Create first paragraph with a symbol bullet
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = Convert.ToChar(8226); // • character
        para1.Text = "First bullet point";
        para1.ParagraphFormat.Indent = 20f;
        para1.ParagraphFormat.Bullet.Color.ColorType = Aspose.Slides.ColorType.RGB;
        para1.ParagraphFormat.Bullet.Color.Color = System.Drawing.Color.Black;
        para1.ParagraphFormat.Bullet.IsBulletHardColor = Aspose.Slides.NullableBool.True;
        textFrame.Paragraphs.Add(para1);

        // Create second paragraph with a numbered bullet
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        para2.ParagraphFormat.Bullet.NumberedBulletStyle = Aspose.Slides.NumberedBulletStyle.BulletCircleNumWDBlackPlain;
        para2.Text = "Second bullet point";
        para2.ParagraphFormat.Indent = 20f;
        para2.ParagraphFormat.Bullet.Color.ColorType = Aspose.Slides.ColorType.RGB;
        para2.ParagraphFormat.Bullet.Color.Color = System.Drawing.Color.Black;
        para2.ParagraphFormat.Bullet.IsBulletHardColor = Aspose.Slides.NullableBool.True;
        textFrame.Paragraphs.Add(para2);

        // Save the presentation as PPTX
        string outputPath = Path.Combine(outDir, "BulletsPresentation.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}