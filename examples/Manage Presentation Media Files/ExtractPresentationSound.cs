using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input presentation path
        string inputPath = "input.pptx";
        // Output audio file path
        string outputAudioPath = "extractedAudio.wav";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Get the slide show transition
        Aspose.Slides.ISlideShowTransition transition = slide.SlideShowTransition;

        // Extract audio binary data
        byte[] audioData = transition.Sound.BinaryData;

        // Write audio to file if present
        if (audioData != null && audioData.Length > 0)
        {
            File.WriteAllBytes(outputAudioPath, audioData);
        }

        // Save the presentation before exiting
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}