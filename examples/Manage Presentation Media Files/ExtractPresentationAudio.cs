using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the input presentation
            string inputPath = "input.pptx";
            // Path to save the extracted audio file
            string outputAudioPath = "extractedAudio.wav";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Access the slide show transition which may contain embedded audio
            Aspose.Slides.ISlideShowTransition transition = slide.SlideShowTransition;

            // Extract the audio binary data
            System.Byte[] audioData = transition.Sound.BinaryData;

            // Write the audio data to a file
            System.IO.File.WriteAllBytes(outputAudioPath, audioData);

            // Save the presentation (even if unchanged) before exiting
            pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up resources
            pres.Dispose();
        }
    }
}