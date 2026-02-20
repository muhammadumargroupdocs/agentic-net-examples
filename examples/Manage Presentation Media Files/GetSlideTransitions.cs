using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.SlideShow;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Ensure there are at least three slides
        while (presentation.Slides.Count < 3)
        {
            presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        }

        // Set transition for slide 0
        presentation.Slides[0].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Circle;
        presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 2000U;

        // Set transition for slide 1
        presentation.Slides[1].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Comb;
        presentation.Slides[1].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[1].SlideShowTransition.AdvanceAfterTime = 3000U;

        // Set transition for slide 2
        presentation.Slides[2].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;
        presentation.Slides[2].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[2].SlideShowTransition.AdvanceAfterTime = 4000U;

        // Save the presentation
        string outputPath = "ManagedTransitions.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}