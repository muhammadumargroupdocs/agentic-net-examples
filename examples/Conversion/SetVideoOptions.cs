using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SetVideoOptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            System.String inputPath = "input.pptx";

            // Output GIF file path
            System.String outputPath = "output.gif";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Create GIF export options
            Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();

            // Set frame rate (frames per second)
            gifOptions.TransitionFps = 30;

            // Set output frame size (optional, defines GIF dimensions)
            gifOptions.FrameSize = new System.Drawing.Size(960, 720);

            // Save the presentation as GIF with the specified options
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, gifOptions);

            // Dispose the presentation object
            pres.Dispose();
        }
    }
}