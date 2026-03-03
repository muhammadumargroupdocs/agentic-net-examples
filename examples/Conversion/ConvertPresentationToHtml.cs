using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path (can be .ppt or .pptx)
            string inputPath = "input.pptx";

            // Output HTML file path
            string outputPath = "output.html";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Save the presentation as HTML
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html);
            }

            // Indicate completion
            Console.WriteLine("Conversion to HTML completed.");
        }
    }
}