using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManageAudioThumbnail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paths for media, thumbnail image and output presentation
            string mediaFilePath = Path.Combine(Environment.CurrentDirectory, "audio.mp3");
            string thumbnailFilePath = Path.Combine(Environment.CurrentDirectory, "thumb.jpg");
            string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add audio to the presentation
            Aspose.Slides.IAudio audio = presentation.Audios.AddAudio(File.ReadAllBytes(mediaFilePath));

            // Add an audio frame to the first slide
            Aspose.Slides.IAudioFrame audioFrame = presentation.Slides[0].Shapes.AddAudioFrameEmbedded(10, 10, 50, 50, audio);

            // Load new thumbnail image data
            byte[] thumbnailData = File.ReadAllBytes(thumbnailFilePath);

            // Set the audio frame's picture (thumbnail) to the new image
            audioFrame.PictureFormat.Picture.Image = presentation.Images.AddImage(thumbnailData);

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}