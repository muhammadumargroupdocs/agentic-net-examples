using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output directory for PNG images
        string outputDir = "output";
        // Ensure output directory exists
        Directory.CreateDirectory(outputDir);
        // Load presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Scale for image export
        int scaleX = 1;
        int scaleY = scaleX;
        // Iterate through slides and save each as PNG
        foreach (Aspose.Slides.ISlide slide in pres.Slides)
        {
            using (Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY))
            {
                string imagePath = String.Format("{0}\\slide_{1}.png", outputDir, slide.SlideNumber);
                image.Save(imagePath, Aspose.Slides.ImageFormat.Png);
            }
        }
        // Save presentation before exit
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose presentation
        pres.Dispose();
    }
}