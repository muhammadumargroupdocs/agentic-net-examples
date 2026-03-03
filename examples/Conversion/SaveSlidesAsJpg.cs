using System;
using System.IO;
using System.Drawing.Imaging;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output directory for JPG files
        string outputDir = "output";
        Directory.CreateDirectory(outputDir);

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                // Generate a full-scale image of the slide
                using (Aspose.Slides.IImage image = slide.GetImage(1f, 1f))
                {
                    // Build the output file path
                    string outputPath = Path.Combine(outputDir, $"Slide_{slide.SlideNumber}.jpg");
                    // Save the image as JPEG
                    image.Save(outputPath, ImageFormat.Jpeg);
                }
            }

            // Save the presentation (required by authoring rules)
            pres.Save("saved.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}