using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Set transition duration (in milliseconds) for each slide
        int duration = 2000;
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            slide.SlideShowTransition.Duration = duration;
        }

        // Save the presentation
        string outputPath = "TransitionDuration.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}