using System;
using Aspose.Slides;

namespace SlideToPngExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            System.String inputPath = "input.pptx";
            // Output file name format (e.g., slide_0.png, slide_1.png, ...)
            System.String outputFormat = "slide_{0}.png";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and export it as PNG
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (Aspose.Slides.IImage image = slide.GetImage())
                {
                    System.String outputPath = System.String.Format(outputFormat, index);
                    image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the presentation before exiting (optional, can be the same file or a new one)
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}