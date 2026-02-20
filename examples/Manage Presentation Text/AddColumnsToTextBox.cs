using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Output directory
        string dataDir = "Output";
        if (!Directory.Exists(dataDir))
            Directory.CreateDirectory(dataDir);

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape as a text box
        Aspose.Slides.IAutoShape autoShape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 150, 75, 300, 200);
        autoShape.AddTextFrame("Sample text for multiple columns.");

        // Configure text frame to have columns
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;
        textFrame.TextFrameFormat.ColumnCount = 2;
        textFrame.TextFrameFormat.ColumnSpacing = 10.0;

        // Save the presentation
        presentation.Save(Path.Combine(dataDir, "TextBoxWithColumns.pptx"), Aspose.Slides.Export.SaveFormat.Pptx);
    }
}