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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a title shape
        Aspose.Slides.IAutoShape titleShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 20, 600, 50);
        titleShape.TextFrame.Text = "Presentation Overview";

        // Add a shape for bullet points
        Aspose.Slides.IAutoShape bulletShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 80, 600, 300);
        bulletShape.TextFrame.Text = "Agenda";

        // First bullet
        Aspose.Slides.Paragraph para1 = new Aspose.Slides.Paragraph();
        para1.Text = "Introduction";
        para1.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        bulletShape.TextFrame.Paragraphs.Add(para1);

        // Second bullet
        Aspose.Slides.Paragraph para2 = new Aspose.Slides.Paragraph();
        para2.Text = "Main Content";
        para2.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        bulletShape.TextFrame.Paragraphs.Add(para2);

        // Third bullet
        Aspose.Slides.Paragraph para3 = new Aspose.Slides.Paragraph();
        para3.Text = "Conclusion";
        para3.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Symbol;
        bulletShape.TextFrame.Paragraphs.Add(para3);

        // Save the presentation in PPTX and PPT formats
        presentation.Save(Path.Combine(outDir, "Overview.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Save(Path.Combine(outDir, "Overview.ppt"), Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation
        presentation.Dispose();
    }
}