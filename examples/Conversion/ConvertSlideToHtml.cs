using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output HTML file path
            string outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Specify the slide index to convert (0‑based)
            int[] slides = new int[] { 0 };

            // Save the specified slide as HTML
            presentation.Save(outputPath, slides, Aspose.Slides.Export.SaveFormat.Html);

            // Clean up resources
            presentation.Dispose();
        }
    }
}