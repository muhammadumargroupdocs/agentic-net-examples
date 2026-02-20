using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define file paths
        string mediaFileName = "audio.mp3";
        string mediaFile = Path.Combine(Environment.CurrentDirectory, mediaFileName);
        string thumbnailFileName = "thumb.jpg";
        string thumbnailFile = Path.Combine(Environment.CurrentDirectory, thumbnailFileName);
        string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add audio to the presentation
        Aspose.Slides.IAudio audio = pres.Audios.AddAudio(File.ReadAllBytes(mediaFile));

        // Add an embedded audio frame to the first slide
        Aspose.Slides.IAudioFrame audioFrame = pres.Slides[0].Shapes.AddAudioFrameEmbedded(10, 10, 50, 50, audio);

        // Load thumbnail image data
        byte[] imageData = File.ReadAllBytes(thumbnailFile);

        // Set the thumbnail image for the audio frame
        audioFrame.PictureFormat.Picture.Image = pres.Images.AddImage(imageData);

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}