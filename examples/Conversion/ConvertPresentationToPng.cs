using System;

class Program
{
    static void Main()
    {
        // Input PowerPoint file
        System.String inputPath = "presentation.pptx";
        // Output file name pattern (e.g., slide_0.png, slide_1.png, ...)
        System.String outputFormat = "slide_{0}.png";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through all slides and save each as PNG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                System.String outputPath = System.String.Format(outputFormat, index);
                image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Dispose the presentation
        pres.Dispose();
    }
}