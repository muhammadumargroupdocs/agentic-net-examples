using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Ensure the presentation has at least three slides
        while (presentation.Slides.Count < 3)
        {
            presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        }

        // Apply transition to the first slide
        presentation.Slides[0].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;
        presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 2000U;

        // Apply transition to the second slide
        presentation.Slides[1].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Wipe;
        presentation.Slides[1].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[1].SlideShowTransition.AdvanceAfterTime = 3000U;

        // Apply transition to the third slide
        presentation.Slides[2].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Zoom;
        presentation.Slides[2].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[2].SlideShowTransition.AdvanceAfterTime = 4000U;

        // Save the presentation
        string outputPath = "output.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}