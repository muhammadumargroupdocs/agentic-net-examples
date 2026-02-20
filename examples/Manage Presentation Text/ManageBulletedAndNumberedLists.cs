using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape for a numbered list
        Aspose.Slides.IAutoShape shapeNumbered = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 200);
        Aspose.Slides.ITextFrame textFrameNumbered = shapeNumbered.TextFrame;
        textFrameNumbered.Paragraphs.RemoveAt(0);

        // First numbered paragraph
        Aspose.Slides.Paragraph paragraph1 = new Aspose.Slides.Paragraph();
        paragraph1.Text = "First numbered item";
        paragraph1.ParagraphFormat.Depth = 0;
        paragraph1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph1.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)1;
        textFrameNumbered.Paragraphs.Add(paragraph1);

        // Second numbered paragraph
        Aspose.Slides.Paragraph paragraph2 = new Aspose.Slides.Paragraph();
        paragraph2.Text = "Second numbered item";
        paragraph2.ParagraphFormat.Depth = 0;
        paragraph2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph2.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)2;
        textFrameNumbered.Paragraphs.Add(paragraph2);

        // Third numbered paragraph
        Aspose.Slides.Paragraph paragraph3 = new Aspose.Slides.Paragraph();
        paragraph3.Text = "Third numbered item";
        paragraph3.ParagraphFormat.Depth = 0;
        paragraph3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        paragraph3.ParagraphFormat.Bullet.NumberedBulletStartWith = (short)3;
        textFrameNumbered.Paragraphs.Add(paragraph3);

        // Add a rectangle shape for a bulleted list
        Aspose.Slides.IAutoShape shapeBullet = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 300, 400, 200);
        Aspose.Slides.ITextFrame textFrameBullet = shapeBullet.TextFrame;
        textFrameBullet.Paragraphs.RemoveAt(0);

        // Symbol bullet paragraph
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        para1.ParagraphFormat.Bullet.Char = System.Convert.ToChar(8226); // bullet character
        para1.Text = "First bullet item";
        para1.ParagraphFormat.Indent = 20f;
        para1.ParagraphFormat.Bullet.Color.ColorType = Aspose.Slides.ColorType.RGB;
        para1.ParagraphFormat.Bullet.Color.Color = System.Drawing.Color.Black;
        para1.ParagraphFormat.Bullet.IsBulletHardColor = Aspose.Slides.NullableBool.True;
        textFrameBullet.Paragraphs.Add(para1);

        // Numbered bullet paragraph
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Numbered;
        para2.ParagraphFormat.Bullet.NumberedBulletStyle = Aspose.Slides.NumberedBulletStyle.BulletCircleNumWDBlackPlain;
        para2.Text = "First numbered bullet item";
        para2.ParagraphFormat.Indent = 20f;
        para2.ParagraphFormat.Bullet.Color.ColorType = Aspose.Slides.ColorType.RGB;
        para2.ParagraphFormat.Bullet.Color.Color = System.Drawing.Color.Black;
        para2.ParagraphFormat.Bullet.IsBulletHardColor = Aspose.Slides.NullableBool.True;
        textFrameBullet.Paragraphs.Add(para2);

        // Save the presentation
        string outputPath = "ManagedBullets.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}