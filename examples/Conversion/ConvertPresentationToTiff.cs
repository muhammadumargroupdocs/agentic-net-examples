using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";

        // Path for the generated TIFF file
        string outputPath = "output.tiff";

        // Load the presentation from the specified file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as a multi‑page TIFF image
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff);

        // Release resources
        presentation.Dispose();
    }
}