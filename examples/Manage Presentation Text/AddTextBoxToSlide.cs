using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define output directory
        string dataDir = "Output";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape autoShape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 150, 75, 150, 50);

        // Add an empty text frame
        autoShape.AddTextFrame("");

        // Get the text frame
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Get the first paragraph
        Aspose.Slides.IParagraph paragraph = textFrame.Paragraphs[0];

        // Get the first portion
        Aspose.Slides.IPortion portion = paragraph.Portions[0];

        // Set the text
        portion.Text = "Hello Aspose!";

        // Save the presentation
        presentation.Save(Path.Combine(dataDir, "TextBoxDemo.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);
    }
}