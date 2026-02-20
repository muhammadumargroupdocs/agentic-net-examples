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

        // Access the first slide (already present in a new presentation)
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Set the transition type for the slide
        presentation.Slides[0].SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.Fade;

        // Configure the slide to advance on mouse click
        presentation.Slides[0].SlideShowTransition.AdvanceOnClick = true;

        // Enable auto-advance after a specified time (2 seconds)
        presentation.Slides[0].SlideShowTransition.AdvanceAfter = true;
        presentation.Slides[0].SlideShowTransition.AdvanceAfterTime = 2000U;

        // Save the presentation to a PPTX file
        string outputPath = "TransitionDemo.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}