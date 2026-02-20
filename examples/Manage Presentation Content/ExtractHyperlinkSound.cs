using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExtractHyperlinkSound
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation path
            string inputPath = "input.pptx";
            // Output audio file path
            string outputPath = "hyperlink_sound.wav";

            // Load presentation
            Presentation pres = new Presentation(inputPath);

            // Get first slide
            ISlide slide = pres.Slides[0];
            // Get first shape on the slide
            IShape shape = slide.Shapes[0];
            // Get hyperlink associated with click action
            IHyperlink hyperlink = shape.HyperlinkClick;

            // Extract sound from hyperlink
            IAudio audio = hyperlink.Sound;
            if (audio != null && audio.BinaryData != null)
            {
                File.WriteAllBytes(outputPath, audio.BinaryData);
            }

            // Save presentation before exit
            pres.Save("output.pptx", SaveFormat.Pptx);
        }
    }
}