using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Apply transition type and duration to each slide
        foreach (Aspose.Slides.ISlide slide in pres.Slides)
        {
            // Set transition type (e.g., Fade)
            slide.SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;
            // Set transition duration in milliseconds (e.g., 2000 ms)
            slide.SlideShowTransition.Duration = 2000;
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}