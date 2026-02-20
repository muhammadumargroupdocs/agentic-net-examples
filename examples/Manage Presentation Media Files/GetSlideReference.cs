using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        System.String inputPath = "input.pptx";
        // Path for the output PPTX file
        System.String outputPath = "output.pptx";

        // Load the presentation from the file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide by its index (0‑based)
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Example operation: ensure the slide is not hidden
        slide.Hidden = false;

        // Save the presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}