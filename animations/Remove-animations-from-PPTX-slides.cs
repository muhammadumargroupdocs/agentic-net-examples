using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            var inputPath = "input.pptx";
            var outputPath = "output_no_animations.pptx";

            using (var presentation = new Presentation(inputPath))
            {
                foreach (var slide in presentation.Slides)
                {
                    // Remove all main sequence animations
                    slide.Timeline.MainSequence.Clear();

                    // Remove all interactive sequence animations
                    foreach (var seq in slide.Timeline.InteractiveSequences)
                    {
                        seq.Clear();
                    }

                    // Remove slide transition (optional)
                    slide.SlideShowTransition.Type = Aspose.Slides.SlideShow.TransitionType.None;
                }

                // Save the modified presentation
                presentation.Save(outputPath, SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}