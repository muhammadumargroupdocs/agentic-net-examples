using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        System.String inputPath = "input.pptx";

        // Path where the animated GIF will be saved
        System.String outputPath = "output.gif";

        // Load the presentation from the specified file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create GIF export options and configure them
        Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
        gifOptions.FrameSize = new System.Drawing.Size(800, 600); // Set frame size
        gifOptions.DefaultDelay = 500; // Default delay between frames in milliseconds
        gifOptions.TransitionFps = 25; // Frames per second for transitions

        // Save the presentation as an animated GIF using the configured options
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, gifOptions);

        // Release resources
        presentation.Dispose();
    }
}