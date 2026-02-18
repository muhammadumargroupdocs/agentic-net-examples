using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPT file path
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "input.ppt");

        // Output directory and PPTX file path
        string outputDir = Path.Combine(Directory.GetCurrentDirectory(), "Output");
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);
        string outputPath = Path.Combine(outputDir, "output.pptx");

        // Load the PPT presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation in PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}