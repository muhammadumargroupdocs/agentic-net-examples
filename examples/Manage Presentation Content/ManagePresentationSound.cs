using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide (a new presentation always contains one empty slide)
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Load audio data from a file
        string audioFilePath = "sample.wav";
        byte[] audioBytes = File.ReadAllBytes(audioFilePath);

        // Add the audio to the presentation's audio collection
        Aspose.Slides.IAudio audio = presentation.Audios.AddAudio(audioBytes);

        // Add an embedded audio frame to the slide
        // Parameters: X, Y, Width, Height, IAudio object
        Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(100f, 100f, 100f, 50f, audio);

        // Configure playback options
        audioFrame.PlayAcrossSlides = true;                                   // Play on all slides
        audioFrame.PlayMode = Aspose.Slides.AudioPlayModePreset.Auto;        // Play automatically
        audioFrame.VolumeValue = 100f;                                        // Set volume to 100%

        // Save the presentation in PPT format
        string outputPath = "ManagedSoundPresentation.ppt";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up resources
        presentation.Dispose();
    }
}