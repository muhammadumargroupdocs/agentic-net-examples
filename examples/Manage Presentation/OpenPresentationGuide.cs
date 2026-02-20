using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Output directory
        string outDir = "Output";
        if (!Directory.Exists(outDir))
            Directory.CreateDirectory(outDir);

        // Input and output file paths
        string inputPath = "sample.pptx";
        string outputPath = Path.Combine(outDir, "opened.pptx");

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Access document properties
        Aspose.Slides.IDocumentProperties docProps = presentation.DocumentProperties;
        // Read a property
        string author = docProps.Author;
        // Modify a writable property
        docProps.Author = "New Author";

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}