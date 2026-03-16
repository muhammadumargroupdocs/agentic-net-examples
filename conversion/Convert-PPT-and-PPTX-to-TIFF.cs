using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            string inputPath = "input.pptx";
            string tiffPath = "output.tiff";
            string outputPresPath = "output.pptx";

            using (Presentation presentation = new Presentation(inputPath))
            {
                // Configure TIFF export options
                TiffOptions options = new TiffOptions();
                options.DpiX = 300;
                options.DpiY = 300;

                // Save all slides as a multi‑page TIFF image
                presentation.Save(tiffPath, SaveFormat.Tiff, options);

                // Save the presentation (preserve any changes)
                presentation.Save(outputPresPath, SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}