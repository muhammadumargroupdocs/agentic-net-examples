using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory and ensure it exists
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Path to the picture used for bullet
            string imagePath = "bullet.png";

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Access the first slide
            ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape to hold the text
            IAutoShape autoShape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 400, 200);

            // Get the text frame of the shape
            ITextFrame textFrame = autoShape.TextFrame;

            // Remove the default paragraph
            textFrame.Paragraphs.RemoveAt(0);

            // Load image from file using a stream to avoid System.Drawing dependency
            FileStream imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            IPPImage ippImage = presentation.Images.AddImage(imageStream);
            imageStream.Close();

            // Create a new paragraph with picture bullet
            Paragraph paragraph = new Paragraph();
            paragraph.Text = "Welcome to Aspose.Slides!";
            paragraph.ParagraphFormat.Bullet.Type = BulletType.Picture;
            paragraph.ParagraphFormat.Bullet.Picture.Image = ippImage;
            paragraph.ParagraphFormat.Bullet.Height = 12f; // Bullet height in points

            // Add the paragraph to the text frame
            textFrame.Paragraphs.Add(paragraph);

            // Save the presentation as PPTX
            presentation.Save(Path.Combine(outDir, "PictureBulletPresentation.pptx"), SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}