using System;
using System.Net;

class Program
{
    static void Main()
    {
        // YouTube video identifier
        string videoId = "dQw4w9WgXcQ";

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add a video frame that references the video from the web
        Aspose.Slides.IVideoFrame videoFrame = pres.Slides[0].Shapes.AddVideoFrame(
            10, 10, 427, 240,
            "https://www.youtube.com/embed/" + videoId);

        // Set the video to play automatically
        videoFrame.PlayMode = Aspose.Slides.VideoPlayModePreset.Auto;

        // Download thumbnail image for the video
        WebClient client = new WebClient();
        string thumbnailUri = "https://img.youtube.com/vi/" + videoId + "/hqdefault.jpg";
        byte[] imageData = client.DownloadData(thumbnailUri);
        client.Dispose();

        // Set the thumbnail as the picture for the video frame
        videoFrame.PictureFormat.Picture.Image = pres.Images.AddImage(imageData);

        // Save the presentation
        string outputFileName = "VideoFromWeb.pptx";
        pres.Save(outputFileName, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}