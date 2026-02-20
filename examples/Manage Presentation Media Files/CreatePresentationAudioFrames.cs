using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManagePresentationMediaFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paths for media and output files
            string mediaFile = Path.Combine(Environment.CurrentDirectory, "audio.mp3");
            string trackFile = Path.Combine(Environment.CurrentDirectory, "captions.vtt");
            string outAddPath = Path.Combine(Environment.CurrentDirectory, "AddCaptions.pptx");
            string outCaption = Path.Combine(Environment.CurrentDirectory, "extractedCaption.vtt");
            string outRemovePath = Path.Combine(Environment.CurrentDirectory, "RemoveCaptions.pptx");

            // Create a new presentation
            Presentation pres = new Presentation();

            // Add audio to the presentation
            IAudio audio = pres.Audios.AddAudio(File.ReadAllBytes(mediaFile));

            // Add an embedded audio frame to the first slide
            IAudioFrame audioFrame = pres.Slides[0].Shapes.AddAudioFrameEmbedded(10, 10, 50, 50, audio);

            // Add a caption track (WebVTT) to the audio frame
            audioFrame.CaptionTracks.Add("en", trackFile);

            // Save presentation with caption track added
            pres.Save(outAddPath, SaveFormat.Pptx);

            // Retrieve the audio frame from the slide
            IAudioFrame retrievedAudioFrame = pres.Slides[0].Shapes[0] as IAudioFrame;

            if (retrievedAudioFrame != null)
            {
                // Extract each caption track to a file
                foreach (ICaptions captionTrack in retrievedAudioFrame.CaptionTracks)
                {
                    File.WriteAllBytes(outCaption, captionTrack.BinaryData);
                }

                // Remove all caption tracks
                retrievedAudioFrame.CaptionTracks.Clear();
            }

            // Save presentation after removing caption tracks
            pres.Save(outRemovePath, SaveFormat.Pptx);

            // Ensure the presentation is saved before exiting
            pres.Dispose();
        }
    }
}