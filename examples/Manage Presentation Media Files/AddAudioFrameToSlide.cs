using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add an embedded audio file to the presentation
        Aspose.Slides.IAudio audio = pres.Audios.AddAudio(File.ReadAllBytes("sample.mp3"));

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add an audio frame to the slide
        Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(50f, 150f, 100f, 100f, audio);
        audioFrame.PlayAcrossSlides = true;
        audioFrame.RewindAudio = true;
        audioFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;
        audioFrame.PlayMode = Aspose.Slides.AudioPlayModePreset.Auto;

        // Save the presentation
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}