using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file path (PPT or PPTX)
            string inputPath = "input.pptx";

            // Output file name pattern for PNG images
            string outputPattern = "slide_{0}.png";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Iterate through all slides and export each as PNG
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (Aspose.Slides.IImage image = slide.GetImage(1f, 1f))
                {
                    string outputFile = System.String.Format(outputPattern, slide.SlideNumber);
                    image.Save(outputFile, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the presentation before exiting (preserve original format)
            if (pres.SourceFormat == Aspose.Slides.SourceFormat.Ppt)
            {
                pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Ppt);
            }
            else
            {
                pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}