using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation files (PPT and PPTX)
        string[] inputFiles = new string[] { "presentation1.ppt", "presentation2.pptx" };
        // Output folder for TIFF files
        string outputFolder = "OutputTiff";

        // Ensure output directory exists
        System.IO.Directory.CreateDirectory(outputFolder);

        // Loop through each input file and convert to TIFF
        for (int i = 0; i < inputFiles.Length; i++)
        {
            string inputPath = inputFiles[i];
            // Derive output file name with same base name and .tiff extension
            string outputPath = System.IO.Path.Combine(outputFolder, System.IO.Path.GetFileNameWithoutExtension(inputPath) + ".tiff");

            // Load presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Create TIFF save options (optional configuration)
            Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
            tiffOptions.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.LZW;
            tiffOptions.DpiX = 300;
            tiffOptions.DpiY = 300;

            // Save as multi-page TIFF
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

            // Dispose presentation
            pres.Dispose();
        }
    }
}