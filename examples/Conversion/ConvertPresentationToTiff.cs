using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create TIFF options and set a custom image size
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
        tiffOptions.ImageSize = new System.Drawing.Size(1600, 1200); // custom size in pixels

        // Save the presentation as a multi-page TIFF using the specified options
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Clean up resources
        presentation.Dispose();
    }
}