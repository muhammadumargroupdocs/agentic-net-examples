using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Open the audio file stream
            System.IO.FileStream audioStream = new System.IO.FileStream("audio.mp3", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);

            // Add an embedded audio frame to the slide
            Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(50f, 150f, 100f, 100f, audioStream);

            // Configure audio playback settings
            audioFrame.PlayAcrossSlides = true;
            audioFrame.RewindAudio = true;
            audioFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;
            audioFrame.PlayMode = Aspose.Slides.AudioPlayModePreset.Auto;

            // Close the audio stream
            audioStream.Close();

            // Save the presentation
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}