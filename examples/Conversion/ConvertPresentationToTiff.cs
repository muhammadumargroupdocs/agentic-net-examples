using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";
        // Path for the resulting TIFF file
        string outputPath = "output.tiff";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Create TIFF export options
            Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
            // Example: set image resolution
            tiffOptions.DpiX = 200;
            tiffOptions.DpiY = 200;

            // Save the presentation as a multi‑page TIFF image
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);
        }
    }
}