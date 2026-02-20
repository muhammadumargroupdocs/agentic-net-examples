using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // File names
        string mediaFileName = "sample.mp3";
        string trackFileName = "sample.vtt";
        string outAddFileName = "AudioWithCaption.pptx";
        string outCaptionFileName = "extractedCaption.vtt";
        string outRemoveFileName = "AudioWithoutCaption.pptx";
        string trackName = "English";

        // Full paths
        string mediaFile = Path.Combine(Environment.CurrentDirectory, mediaFileName);
        string trackFile = Path.Combine(Environment.CurrentDirectory, trackFileName);
        string outAddPath = Path.Combine(Environment.CurrentDirectory, outAddFileName);
        string outCaption = Path.Combine(Environment.CurrentDirectory, outCaptionFileName);
        string outRemovePath = Path.Combine(Environment.CurrentDirectory, outRemoveFileName);

        // Create presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add audio to presentation
        Aspose.Slides.IAudio audio = pres.Audios.AddAudio(File.ReadAllBytes(mediaFile));

        // Add audio frame to first slide
        Aspose.Slides.IAudioFrame audioFrame = pres.Slides[0].Shapes.AddAudioFrameEmbedded(10, 10, 50, 50, audio);

        // Add caption track
        audioFrame.CaptionTracks.Add(trackName, trackFile);

        // Save presentation with caption
        pres.Save(outAddPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Retrieve the audio frame
        Aspose.Slides.IAudioFrame audioFrame2 = pres.Slides[0].Shapes[0] as Aspose.Slides.IAudioFrame;
        if (audioFrame2 != null)
        {
            // Extract caption data
            foreach (Aspose.Slides.ICaptions captionTrack in audioFrame2.CaptionTracks)
            {
                File.WriteAllBytes(outCaption, captionTrack.BinaryData);
            }

            // Clear caption tracks
            audioFrame2.CaptionTracks.Clear();

            // Save presentation without caption
            pres.Save(outRemovePath, Aspose.Slides.Export.SaveFormat.Pptx);
        }

        // Dispose presentation
        pres.Dispose();
    }
}