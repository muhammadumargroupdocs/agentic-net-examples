using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationLinksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file names
            string inputFile = "input.pptx";
            string outputFile = "output.pptx";

            // Build full paths for input and output
            string inputPath = Path.Combine(Directory.GetCurrentDirectory(), inputFile);
            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), outputFile);

            // Load the presentation from the input file
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create PPTX save options and configure to include JavaScript links
            Aspose.Slides.Export.PptxOptions options = new Aspose.Slides.Export.PptxOptions();
            options.SkipJavaScriptLinks = false; // Include JavaScript links for examination

            // Save the presentation with the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx, options);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}