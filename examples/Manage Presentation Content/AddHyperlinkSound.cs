using System;
using System.IO;

namespace MyPresentationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle shape with text
            Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50, 50, 200, 50);
            shape.AddTextFrame("Click me");

            // Create a hyperlink and assign it to the text portion
            Aspose.Slides.Hyperlink hyperlink = new Aspose.Slides.Hyperlink("https://example.com");
            shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick = hyperlink;

            // Load audio data and add it to the presentation
            byte[] audioBytes = File.ReadAllBytes("sound.wav");
            Aspose.Slides.IAudio audio = presentation.Audios.AddAudio(audioBytes);

            // Assign the audio to the hyperlink
            hyperlink.Sound = audio;

            // Save the presentation
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}