using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Access the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape
            Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

            // Get the text frame of the shape
            Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

            // Create a new paragraph with some text
            Aspose.Slides.Paragraph paragraph = new Aspose.Slides.Paragraph();
            paragraph.Text = "Welcome to Aspose.Slides!";
            paragraph.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.None;

            // Add the paragraph to the text frame
            textFrame.Paragraphs.Add(paragraph);

            // Set footer text for all slides
            presentation.HeaderFooterManager.SetAllFootersText("Confidential");
            presentation.HeaderFooterManager.SetAllFootersVisibility(true);

            // Save the presentation in PPTX format
            presentation.Save(Path.Combine(outDir, "output.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);

            // Save the presentation in PPT format
            presentation.Save(Path.Combine(outDir, "output.ppt"), Aspose.Slides.Export.SaveFormat.Ppt);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}