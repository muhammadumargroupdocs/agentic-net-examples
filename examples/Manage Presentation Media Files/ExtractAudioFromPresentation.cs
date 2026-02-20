using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExtractAudioExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation path
            string inputPath = Path.Combine(Environment.CurrentDirectory, "input.pptx");
            // Output audio file path
            string outputAudioPath = Path.Combine(Environment.CurrentDirectory, "extractedAudio.mp3");
            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
            // Iterate through slides and shapes to find an audio frame
            foreach (Aspose.Slides.ISlide slide in pres.Slides)
            {
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    Aspose.Slides.IAudioFrame audioFrame = shape as Aspose.Slides.IAudioFrame;
                    if (audioFrame != null && audioFrame.EmbeddedAudio != null && audioFrame.EmbeddedAudio.BinaryData != null)
                    {
                        // Write the embedded audio data to a file
                        File.WriteAllBytes(outputAudioPath, audioFrame.EmbeddedAudio.BinaryData);
                        // Exit loops after extracting the first audio
                        break;
                    }
                }
            }
            // Save the presentation (required by authoring rules)
            string savedPresentationPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");
            pres.Save(savedPresentationPath, SaveFormat.Pptx);
            // Dispose the presentation
            pres.Dispose();
        }
    }
}