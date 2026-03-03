using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";
        // Output file name pattern
        string outputFormat = "slide_{0}.png";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and save as PNG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                string outputPath = string.Format(outputFormat, index);
                image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Release resources
        pres.Dispose();
    }
}