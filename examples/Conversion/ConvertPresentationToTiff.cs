using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Configure TIFF options for black-and-white conversion
        Aspose.Slides.Export.TiffOptions options = new Aspose.Slides.Export.TiffOptions();
        options.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.CCITT4;
        options.BwConversionMode = Aspose.Slides.Export.BlackWhiteConversionMode.Dithering;

        // Save the presentation as a black-and-white TIFF image
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, options);

        // Dispose the presentation object
        pres.Dispose();
    }
}