using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input video file path
            string inputVideoPath = "sample.mp4";
            // Output presentation file path
            string outputPresentationPath = "output.pptx";

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Open video file stream
            System.IO.FileStream videoStream = new System.IO.FileStream(
                inputVideoPath,
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read,
                System.IO.FileShare.Read);

            // Add video to the presentation from the stream
            Aspose.Slides.IVideo video = presentation.Videos.AddVideo(
                videoStream,
                Aspose.Slides.LoadingStreamBehavior.ReadStreamAndRelease);

            // Close the stream as it's no longer needed
            videoStream.Close();

            // Add a video frame to the slide
            Aspose.Slides.IVideoFrame videoFrame = slide.Shapes.AddVideoFrame(
                50,   // X position
                150,  // Y position
                300,  // Width
                350,  // Height
                video);

            // Set playback mode and volume
            videoFrame.PlayMode = Aspose.Slides.VideoPlayModePreset.Auto;
            videoFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;

            // Save the presentation
            presentation.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();

            Console.WriteLine("Presentation saved to " + outputPresentationPath);
        }
    }
}