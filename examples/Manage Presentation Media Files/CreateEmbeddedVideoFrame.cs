using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input video file and output presentation paths
        string inputVideo = "sample.mp4";
        string outputPptx = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Open the video file stream
        FileStream videoStream = new FileStream(inputVideo, FileMode.Open, FileAccess.Read, FileShare.Read);

        // Add the video to the presentation
        Aspose.Slides.IVideo video = presentation.Videos.AddVideo(videoStream, Aspose.Slides.LoadingStreamBehavior.ReadStreamAndRelease);

        // Close the video stream
        videoStream.Close();

        // Add a video frame to the slide
        Aspose.Slides.IVideoFrame videoFrame = slide.Shapes.AddVideoFrame(50, 150, 300, 350, video);

        // Set play mode and volume for the video frame
        videoFrame.PlayMode = Aspose.Slides.VideoPlayModePreset.Auto;
        videoFrame.Volume = Aspose.Slides.AudioVolumeMode.Loud;

        // Save the presentation
        presentation.Save(outputPptx, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}