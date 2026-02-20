using System;
using System.Net;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Video identifier and base URLs
        string videoId = "dQw4w9WgXcQ";
        string youtubeBaseUrl = "https://www.youtube.com/embed/";
        string thumbnailBaseUrl = "https://img.youtube.com/vi/";

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add a video frame that points to the YouTube video
        Aspose.Slides.IVideoFrame videoFrame = pres.Slides[0].Shapes.AddVideoFrame(
            10, 10, 427, 240, youtubeBaseUrl + videoId);
        videoFrame.PlayMode = Aspose.Slides.VideoPlayModePreset.Auto;

        // Download the video thumbnail and set it as the picture for the video frame
        System.Net.WebClient client = new System.Net.WebClient();
        string thumbnailUri = thumbnailBaseUrl + videoId + "/hqdefault.jpg";
        byte[] imageData = client.DownloadData(thumbnailUri);
        client.Dispose();

        videoFrame.PictureFormat.Picture.Image = pres.Images.AddImage(imageData);

        // Save the presentation
        string outputPath = "VideoFromWeb.pptx";
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}