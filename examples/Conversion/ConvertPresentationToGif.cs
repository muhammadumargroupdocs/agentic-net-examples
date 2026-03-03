using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesGifExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file (PPTX)
            string inputPath = "input.pptx";

            // Output GIF file
            string outputPath = "output.gif";

            // Load the presentation
            using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
            {
                // Create GIF export options (optional customization)
                Aspose.Slides.Export.GifOptions options = new Aspose.Slides.Export.GifOptions
                {
                    // Example: set default delay between frames to 1500 ms
                    DefaultDelay = 1500,
                    // Example: export hidden slides as well
                    ExportHiddenSlides = true,
                    // Example: set transition frames per second
                    TransitionFps = 30
                };

                // Save the presentation as an animated GIF
                pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, options);
            }

            // Indicate completion
            Console.WriteLine("Presentation converted to GIF successfully.");
        }
    }
}