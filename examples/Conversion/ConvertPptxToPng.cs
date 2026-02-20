using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptxToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output folder for PNG images
            string outputFolder = "output";

            // Ensure the output directory exists
            Directory.CreateDirectory(outputFolder);

            // Scale factors for the exported images
            int scaleX = 2;
            int scaleY = scaleX;

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and save as PNG
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                using (Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY))
                {
                    string imageFileName = String.Format("{0}{1}Slide_{2}.png", outputFolder, Path.DirectorySeparatorChar, slide.SlideNumber);
                    image.Save(imageFileName, ImageFormat.Png);
                }
            }

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}