using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace VideoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the local video file
            string videoPath = "sample.mp4";
            // Path where the presentation will be saved
            string outputPath = "output.pptx";

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Get the first slide
            ISlide slide = presentation.Slides[0];

            // Open a file stream for the video
            FileStream videoStream = new FileStream(videoPath, FileMode.Open, FileAccess.Read, FileShare.Read);

            // Add the video to the presentation from the stream
            IVideo video = presentation.Videos.AddVideo(videoStream, LoadingStreamBehavior.ReadStreamAndRelease);

            // Close the video stream
            videoStream.Close();

            // Add a video frame to the slide using the embedded video
            IVideoFrame videoFrame = slide.Shapes.AddVideoFrame(50, 150, 300, 350, video);

            // Set playback mode and volume
            videoFrame.PlayMode = VideoPlayModePreset.Auto;
            videoFrame.Volume = AudioVolumeMode.Loud;

            // Save the presentation
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}