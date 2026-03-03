using System;

class Program
{
    static void Main(string[] args)
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.tiff";

        // Configure TIFF options for black-and-white conversion
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
        tiffOptions.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.CCITT4;
        tiffOptions.BwConversionMode = Aspose.Slides.Export.BlackWhiteConversionMode.Dithering;

        // Load the presentation and save it as a multi-page black-and-white TIFF
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);
        }
    }
}