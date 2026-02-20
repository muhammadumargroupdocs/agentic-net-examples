using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the audio file name and construct its full path
            string mediaFileName = "audio.mp3";
            string mediaFilePath = Path.Combine(Environment.CurrentDirectory, mediaFileName);

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Add the audio file to the presentation's shared audio collection
            IAudio audio = presentation.Audios.AddAudio(File.ReadAllBytes(mediaFilePath));

            // Save the presentation to PPTX format
            string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}