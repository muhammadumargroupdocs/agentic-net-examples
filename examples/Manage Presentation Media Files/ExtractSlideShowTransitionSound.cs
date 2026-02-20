using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideShowAudioExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output audio file path
            string outputPath = "transition_audio.wav";

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // Get the slide show transition of the slide
            ISlideShowTransition transition = slide.SlideShowTransition;

            // Extract the embedded audio binary data
            byte[] audioData = transition.Sound?.BinaryData;

            // Save the audio data to a file if it exists
            if (audioData != null && audioData.Length > 0)
            {
                File.WriteAllBytes(outputPath, audioData);
            }

            // Save the presentation before exiting (no changes made, but required by authoring rules)
            pres.Save(inputPath, SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}