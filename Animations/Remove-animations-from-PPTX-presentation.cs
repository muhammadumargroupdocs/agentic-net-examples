using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Animation;

namespace RemoveAnimationsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through all slides and clear their animation sequences
            for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
            {
                // Get the animation timeline of the current slide
                Aspose.Slides.IAnimationTimeLine timeline = presentation.Slides[slideIndex].Timeline;

                // Clear the main sequence which holds all animation effects
                Aspose.Slides.Animation.ISequence mainSequence = timeline.MainSequence;
                mainSequence.Clear();
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Release resources
            presentation.Dispose();
        }
    }
}