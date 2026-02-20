using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for the output presentation and source media files
        string dataDir = "Data";
        string presentationPath = Path.Combine(dataDir, "EmbeddedMedia.ppt");
        string audioPath = Path.Combine(dataDir, "sample.wav");
        string videoPath = Path.Combine(dataDir, "sample.mp4");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first (default) slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Embed an audio file into the presentation
        Aspose.Slides.IAudio embeddedAudio = pres.Audios.AddAudio(File.ReadAllBytes(audioPath));

        // Add an audio frame shape to the slide using the embedded audio
        Aspose.Slides.IAudioFrame audioFrame = slide.Shapes.AddAudioFrameEmbedded(100, 100, 200, 50, embeddedAudio);

        // Embed a video file into the presentation
        Aspose.Slides.IVideo embeddedVideo = pres.Videos.AddVideo(File.ReadAllBytes(videoPath));

        // Add a video frame shape to the slide using the embedded video
        Aspose.Slides.IVideoFrame videoFrame = slide.Shapes.AddVideoFrame(100, 200, 300, 200, embeddedVideo);

        // Save the presentation in PPT format
        pres.Save(presentationPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up
        pres.Dispose();
    }
}