using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define input PPTX file path
        string inputPath = Path.Combine(Environment.CurrentDirectory, "input.pptx");

        // Define output directory
        string outputDir = Path.Combine(Environment.CurrentDirectory, "output");
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        // Load the presentation
        Presentation pres = new Presentation(inputPath);

        // Define output HTML file path
        string outputPath = Path.Combine(outputDir, "slide.html");

        // Save the presentation (or a specific slide) as HTML
        pres.Save(outputPath, SaveFormat.Html);

        // Dispose the presentation object
        pres.Dispose();
    }
}