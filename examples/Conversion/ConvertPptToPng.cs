using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPT/PPTX file path
            string inputPath = "input.pptx";

            // Output folder for PNG images
            string outputFolder = "output";
            Directory.CreateDirectory(outputFolder);

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Scale factors for image conversion
            int scaleX = 2;
            int scaleY = scaleX;

            // Iterate through each slide and save as PNG
            foreach (ISlide slide in presentation.Slides)
            {
                using (IImage image = slide.GetImage(scaleX, scaleY))
                {
                    string imagePath = String.Format("{0}{1}Slide_{2}.png", outputFolder, Path.DirectorySeparatorChar, slide.SlideNumber);
                    image.Save(imagePath, ImageFormat.Png);
                }
            }

            // Save the presentation (required before exit)
            string savedPresentationPath = "output.pptx";
            presentation.Save(savedPresentationPath, SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}