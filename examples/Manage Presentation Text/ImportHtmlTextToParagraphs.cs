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
        if (!System.IO.Directory.Exists(outDir))
        {
            System.IO.Directory.CreateDirectory(outDir);
        }

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape with a text frame
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50f,   // X position (float)
            50f,   // Y position (float)
            400f,  // Width (float)
            200f   // Height (float)
        );

        // Access the text frame
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Remove the default empty paragraph
        textFrame.Paragraphs.RemoveAt(0);

        // HTML content to import
        string html = "<p>This is <b>bold</b> and <i>italic</i> text.</p><ul><li>Item 1</li><li>Item 2</li></ul>";

        // Import HTML into the paragraph collection
        textFrame.Paragraphs.AddFromHtml(html);

        // Save the presentation before exiting
        presentation.Save(
            System.IO.Path.Combine(outDir, "ImportHtml.pptx"),
            Aspose.Slides.Export.SaveFormat.Pptx
        );

        // Clean up
        presentation.Dispose();
    }
}