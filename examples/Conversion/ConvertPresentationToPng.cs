using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output directory for PNG images
            string outputDir = "output";

            // Ensure output directory exists
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Set custom slide size (e.g., 800x600 points) without scaling existing content
            float customWidth = 800f;
            float customHeight = 600f;
            presentation.SlideSize.SetSize(customWidth, customHeight, Aspose.Slides.SlideSizeScaleType.DoNotScale);

            // Scale factors for image generation (1 = original size)
            int scaleX = 1;
            int scaleY = 1;

            // Iterate through each slide and save as PNG
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                using (Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY))
                {
                    string outputPath = Path.Combine(outputDir, $"slide_{slide.SlideNumber}.png");
                    image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the (potentially modified) presentation before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}