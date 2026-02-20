using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        string inputPath = "input.odp";

        // Format string for output PNG files (e.g., slide_1.png)
        string fileNameFormat = "slide_{0}.png";

        // Load the ODP presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Scale factors for image export (1 = original size)
        int scaleX = 1;
        int scaleY = scaleX;

        // Export each slide as a PNG image
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            using (Aspose.Slides.IImage thumbnail = slide.GetImage(scaleX, scaleY))
            {
                string imageFileName = string.Format(fileNameFormat, slide.SlideNumber);
                thumbnail.Save(imageFileName, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Save the presentation before exiting (no modifications made)
        presentation.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);
    }
}