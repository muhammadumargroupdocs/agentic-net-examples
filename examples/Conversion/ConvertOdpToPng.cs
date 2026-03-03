using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        System.String inputPath = "input.odp";
        // Output file name pattern for PNG images
        System.String outputPattern = "slide_{0}.png";

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through all slides and save each as PNG
        for (System.Int32 index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                System.String outputPath = System.String.Format(outputPattern, index);
                image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Save the presentation (required before exit)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}