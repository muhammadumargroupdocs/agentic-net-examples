using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManagePresentationContent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory and ensure it exists
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape
            float x = 50f;
            float y = 50f;
            float width = 400f;
            float height = 100f;
            Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, x, y, width, height);

            // Get the text frame of the shape
            Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

            // Remove the first paragraph if it exists
            int index = 0;
            if (textFrame.Paragraphs.Count > index)
                textFrame.Paragraphs.RemoveAt(index);

            // Load image bytes and add to presentation images collection
            string imageFile = "sample.png";
            byte[] imageBytes = File.ReadAllBytes(imageFile);
            Aspose.Slides.IPPImage ippImage = presentation.Images.AddImage(imageBytes);

            // Create a new paragraph with picture bullet
            Aspose.Slides.Paragraph paragraph = new Aspose.Slides.Paragraph();
            paragraph.Text = "Welcome to Aspose.Slides!";
            paragraph.ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.Picture;
            paragraph.ParagraphFormat.Bullet.Picture.Image = ippImage;
            paragraph.ParagraphFormat.Bullet.Height = 12f;

            // Add the paragraph to the text frame
            textFrame.Paragraphs.Add(paragraph);

            // Save the presentation in PPTX and PPT formats
            string pptxFile = "output.pptx";
            string pptFile = "output.ppt";
            presentation.Save(Path.Combine(outDir, pptxFile), Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Save(Path.Combine(outDir, pptFile), Aspose.Slides.Export.SaveFormat.Ppt);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}