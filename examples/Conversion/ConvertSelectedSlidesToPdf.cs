using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "selected_slides.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Define the indices of slides to convert (zero‑based)
        int[] slides = new int[] { 0, 2, 4 };

        // Save the selected slides as PDF
        presentation.Save(outputPath, slides, Aspose.Slides.Export.SaveFormat.Pdf);

        // Clean up
        presentation.Dispose();
    }
}