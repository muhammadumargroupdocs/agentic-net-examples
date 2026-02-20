using System;
using System.IO;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            string dataDir = "Data";
            string outDir = "Output";
            string inputPath = Path.Combine(dataDir, "input.pptx");
            string outputPath = Path.Combine(outDir, "output.html");

            // Ensure output directory exists
            if (!Directory.Exists(outDir))
            {
                Directory.CreateDirectory(outDir);
            }

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HTML export options
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

            // Save the presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html5, htmlOptions);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}