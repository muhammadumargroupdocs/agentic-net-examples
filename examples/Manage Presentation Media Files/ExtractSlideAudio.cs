using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExtractAudioExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the input presentation
            string inputPath = "input.pptx";
            // Path to save the extracted audio
            string outputAudioPath = "slideAudio.wav";
            // Path to save the presentation after processing
            string outputPresentationPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Get the slide show transition of the slide
            Aspose.Slides.ISlideShowTransition transition = slide.SlideShowTransition;

            // Extract audio data from the transition if present
            if (transition.Sound != null && transition.Sound.BinaryData != null)
            {
                File.WriteAllBytes(outputAudioPath, transition.Sound.BinaryData);
            }

            // Save the presentation (required before exit)
            pres.Save(outputPresentationPath, SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}