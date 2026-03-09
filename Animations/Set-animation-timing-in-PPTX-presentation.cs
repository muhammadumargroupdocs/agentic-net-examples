using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Animation;

namespace AnimationTimingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

            // Set slide transition duration for the first slide (2 seconds)
            presentation.Slides[0].SlideShowTransition.Duration = 2000;

            // Access the first animation effect on the first slide and modify its timing
            Aspose.Slides.Animation.IEffect effect = presentation.Slides[0].Timeline.MainSequence[0];
            Aspose.Slides.Animation.ITiming timing = effect.Timing;
            timing.Duration = 3.0f;          // Effect duration: 3 seconds
            timing.TriggerDelayTime = 1.0f; // Delay after trigger: 1 second

            // Use PresentationAnimationsGenerator to set a default delay for all effects
            using (Aspose.Slides.Export.PresentationAnimationsGenerator animationsGenerator = new Aspose.Slides.Export.PresentationAnimationsGenerator(presentation))
            {
                animationsGenerator.DefaultDelay = 500; // Default delay: 0.5 seconds
                animationsGenerator.Run(presentation.Slides);
            }

            // Save the modified presentation
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}