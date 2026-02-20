using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AudioPresentationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Load audio file into a byte array
            string audioFilePath = Path.Combine(Environment.CurrentDirectory, "sample.mp3");
            byte[] audioData = File.ReadAllBytes(audioFilePath);

            // Add the audio to the presentation's audio collection
            Aspose.Slides.IAudio audio = presentation.Audios.AddAudio(audioData);

            // Add an embedded audio frame to the slide
            Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(50f, 150f, 100f, 100f, audio);

            // Configure audio frame properties
            audioFrame.PlayAcrossSlides = true;
            audioFrame.RewindAudio = true;
            audioFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;
            audioFrame.PlayMode = Aspose.Slides.AudioPlayModePreset.Auto;

            // Save the presentation
            string outputPath = Path.Combine(Environment.CurrentDirectory, "AudioPresentation.pptx");
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}