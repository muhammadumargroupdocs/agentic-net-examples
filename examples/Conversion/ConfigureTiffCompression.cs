using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create TiffOptions and configure compression
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
        tiffOptions.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.LZW; // Use LZW compression
        // Optional: set image resolution
        tiffOptions.DpiX = 200;
        tiffOptions.DpiY = 200;

        // Save the presentation as a TIFF file with the specified options
        presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);
    }
}