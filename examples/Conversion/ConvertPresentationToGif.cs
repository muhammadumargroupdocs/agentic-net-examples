using System;

namespace SlidesGifConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file path (PPT or PPTX)
            System.String inputPath = "example.pptx";
            // Output GIF file path
            System.String outputPath = "example.gif";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Create GIF export options
            Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
            // Example: set default delay between frames (in milliseconds)
            gifOptions.DefaultDelay = 500;

            // Save the presentation as an animated GIF
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, gifOptions);

            // Dispose the presentation object
            pres.Dispose();
        }
    }
}