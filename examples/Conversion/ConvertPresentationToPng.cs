using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";

        // Folder where PNG images will be saved
        string outputFolder = "output";
        Directory.CreateDirectory(outputFolder);

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
        {
            // Define custom image size (width x height)
            Size imageSize = new Size(960, 720);

            // Iterate through all slides and export each as PNG
            for (int i = 0; i < pres.Slides.Count; i++)
            {
                ISlide slide = pres.Slides[i];
                IImage image = slide.GetImage(imageSize);
                string outPath = Path.Combine(outputFolder, $"slide_{i}.png");
                image.Save(outPath, ImageFormat.Png);
                image.Dispose();
            }

            // Save the (unchanged) presentation before exiting
            pres.Save("output.pptx", SaveFormat.Pptx);
        }
    }
}