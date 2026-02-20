using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input presentation file (any supported format)
        string inputPath = "input.pptx";
        // Output PDF file
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Export to PDF
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);

        // Clean up resources
        presentation.Dispose();
    }
}