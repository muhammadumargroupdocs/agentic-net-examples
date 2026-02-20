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

        // Add additional slides to have three slides total
        Aspose.Slides.ISlide slide1 = presentation.Slides[0];
        Aspose.Slides.ISlide slide2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        Aspose.Slides.ISlide slide3 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

        // Set slide transitions and advance timings for the first slide
        presentation.Slides[0].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;
        presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 2000U;

        // Set slide transitions and advance timings for the second slide
        presentation.Slides[1].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Push;
        presentation.Slides[1].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[1].SlideShowTransition.AdvanceAfterTime = 3000U;

        // Set slide transitions and advance timings for the third slide
        presentation.Slides[2].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Wipe;
        presentation.Slides[2].SlideShowTransition.AdvanceOnClick = true;
        presentation.Slides[2].SlideShowTransition.AdvanceAfterTime = 4000U;

        // Save the presentation
        string outputPath = "AdvancedSlides.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}