using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = Path.Combine(Environment.CurrentDirectory, "input.pptx");
        // Output PDF file path
        string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pdf");

        // Load the presentation from the PPTX file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Export the presentation (or a specific slide) to PDF format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);

        // Release resources
        presentation.Dispose();
    }
}