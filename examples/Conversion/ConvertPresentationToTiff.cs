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

        // Load the presentation from the file system
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create TIFF save options
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
        // Example: set compression type to LZW
        tiffOptions.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.LZW;
        // Example: set DPI for higher resolution
        tiffOptions.DpiX = 300;
        tiffOptions.DpiY = 300;

        // Save the presentation as a multi-page TIFF image
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Release resources
        presentation.Dispose();
    }
}