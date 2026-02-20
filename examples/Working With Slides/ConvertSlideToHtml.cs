using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output HTML file path for the specific slide
        string outputPath = "slide1.html";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Index of the slide to convert (zero‑based)
            int[] slides = new int[] { 0 };

            // Save the selected slide as HTML
            presentation.Save(outputPath, slides, Aspose.Slides.Export.SaveFormat.Html);
        }
    }
}