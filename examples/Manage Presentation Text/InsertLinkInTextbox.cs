using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Define output directory and file
        string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "Output");
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);
        string outputPath = Path.Combine(outputDir, "HyperlinkDemo.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape with a text box
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);
        shape.AddTextFrame("Click here");

        // Insert a hyperlink into the text
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick =
            new Aspose.Slides.Hyperlink("https://www.example.com");

        // Save the presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}