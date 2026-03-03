using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path (first argument or default)
            string inputPath = args.Length > 0 && !String.IsNullOrEmpty(args[0]) ? args[0] : "input.pptx";

            // Output folder for PNG images
            string outputFolder = Path.GetDirectoryName(inputPath) ?? Directory.GetCurrentDirectory();
            string outputPattern = Path.Combine(outputFolder, "slide_{0}.png");

            // Desired resolution in DPI (e.g., 300 DPI)
            float targetDpi = 300f;
            // Aspose.Slides uses 96 DPI as base; calculate scaling factors
            float scaleX = targetDpi / 96f;
            float scaleY = targetDpi / 96f;

            // Load presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Export each slide to PNG with the specified scaling (resolution)
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY))
                {
                    string outputPath = String.Format(outputPattern, index);
                    image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the presentation before exiting (required by lifecycle rules)
            string dummyOutput = Path.Combine(outputFolder, "saved_output.pptx");
            pres.Save(dummyOutput, SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}