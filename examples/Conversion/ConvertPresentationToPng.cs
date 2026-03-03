using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing.Imaging;

namespace ConvertPresentationToPng
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input PowerPoint file
            string inputPath = "input.pptx";
            // Output folder for PNG images
            string outputPath = "output";

            // Ensure output directory exists
            Directory.CreateDirectory(outputPath);

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through slides and save each as high‑quality PNG
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                // Use scaling factor 2 for higher resolution
                Aspose.Slides.IImage image = slide.GetImage(2f, 2f);
                string pngPath = Path.Combine(outputPath, $"slide_{index + 1}.png");
                image.Save(pngPath, ImageFormat.Png);
                image.Dispose();
            }

            // Save the presentation (required by authoring rules)
            string presOutPath = Path.Combine(outputPath, "presentation_out.pptx");
            presentation.Save(presOutPath, Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}