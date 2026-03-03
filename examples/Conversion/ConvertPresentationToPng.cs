using System;

namespace AsposeSlidesPngConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            System.String inputPath = "input.pptx";
            // Output PNG file name pattern (index starts from 1)
            System.String outputFormat = "slide_{0}.png";

            // Load presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Convert each slide to PNG
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (Aspose.Slides.IImage image = slide.GetImage())
                {
                    System.String outputPath = System.String.Format(outputFormat, index + 1);
                    image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save presentation before exiting (no changes made, just to satisfy rule)
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Release resources
            pres.Dispose();
        }
    }
}