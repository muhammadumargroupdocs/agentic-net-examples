using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string inputPath = "input.pptx";

            // Path for the generated HTML file
            string outputPath = "output.html";

            // Load the presentation from the file
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Save the entire presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html);

            // Ensure resources are released before exiting
            presentation.Dispose();
        }
    }
}