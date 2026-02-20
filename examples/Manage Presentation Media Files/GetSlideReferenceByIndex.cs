using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        System.String inputPath = "input.pptx";
        // Output PPTX file path
        System.String outputPath = "output.pptx";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Get the slide at index 0 (first slide)
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Access presentation media collections (e.g., images) – demonstration only
            Aspose.Slides.IImageCollection images = presentation.Images;

            // Save the presentation (required before exit)
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}