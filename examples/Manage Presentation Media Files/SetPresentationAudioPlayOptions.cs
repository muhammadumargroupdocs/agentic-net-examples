using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paths for audio file and output presentation
        string dataDir = Directory.GetCurrentDirectory();
        string audioPath = Path.Combine(dataDir, "sample.mp3");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add audio to the presentation
        Aspose.Slides.IAudio audio = pres.Audios.AddAudio(File.ReadAllBytes(audioPath));

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add an embedded audio frame and set play options
        Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(50f, 150f, 100f, 100f, audio);
        audioFrame.PlayAcrossSlides = true;
        audioFrame.RewindAudio = true;
        audioFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;
        audioFrame.PlayMode = Aspose.Slides.AudioPlayModePreset.Auto;

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}