using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Input presentation file
        System.String inputPath = "input.pptx";
        // Output animated GIF file
        System.String outputPath = "output.gif";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Configure GIF export options
        Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
        gifOptions.FrameSize = new System.Drawing.Size(800, 600);
        gifOptions.DefaultDelay = 500; // delay per frame in milliseconds
        gifOptions.TransitionFps = 25; // frames per second for transitions

        // Save the presentation as an animated GIF
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, gifOptions);

        // Release resources
        presentation.Dispose();
    }
}