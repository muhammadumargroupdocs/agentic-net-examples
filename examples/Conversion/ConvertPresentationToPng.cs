using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String inputPath = "sample.pptx";
            System.String outputFormat = "slide_{0}.png";

            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (Aspose.Slides.IImage image = slide.GetImage())
                {
                    System.String outputPath = System.String.Format(outputFormat, index);
                    image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the presentation before exiting (optional, as no changes were made)
            pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}