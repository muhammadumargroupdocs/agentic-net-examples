using System;
using Aspose.Slides;

namespace SlideTransitionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Ensure there are at least three slides
            presentation.Slides.AddClone(presentation.Slides[0]);
            presentation.Slides.AddClone(presentation.Slides[0]);

            // Set transition for slide 0
            presentation.Slides[0].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;
            presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;
            presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 2000U;

            // Set transition for slide 1
            presentation.Slides[1].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Push;
            presentation.Slides[1].SlideShowTransition.AdvanceOnClick = true;
            presentation.Slides[1].SlideShowTransition.AdvanceAfterTime = 3000U;

            // Set transition for slide 2
            presentation.Slides[2].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Wipe;
            presentation.Slides[2].SlideShowTransition.AdvanceOnClick = true;
            presentation.Slides[2].SlideShowTransition.AdvanceAfterTime = 4000U;

            // Save the presentation
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}