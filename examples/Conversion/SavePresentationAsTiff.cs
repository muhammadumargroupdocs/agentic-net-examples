using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlidesToTiffWithNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            string dataDir = "Data";
            string inputPath = Path.Combine(dataDir, "input.pptx");
            string outputPath = Path.Combine(dataDir, "output.tiff");

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Create TIFF save options (you can customize as needed)
            TiffOptions tiffOptions = new TiffOptions();
            tiffOptions.CompressionType = TiffCompressionTypes.LZW;

            // Save the presentation to a multi‑page TIFF file (includes speaker notes)
            presentation.Save(outputPath, SaveFormat.Tiff, tiffOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}