using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source presentation
        string inputPath = "DemoFile.pptx";
        // Path for the output TIFF file
        string outputPath = "Tiff_With_Custom_Image_Pixel_Format_out.tiff";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Create TIFF export options
            Aspose.Slides.Export.TiffOptions options = new Aspose.Slides.Export.TiffOptions();
            // Set custom pixel format (8 bits per pixel indexed)
            options.PixelFormat = Aspose.Slides.Export.ImagePixelFormat.Format8bppIndexed;

            // Save the presentation as a multi‑page TIFF using the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, options);
        }
    }
}