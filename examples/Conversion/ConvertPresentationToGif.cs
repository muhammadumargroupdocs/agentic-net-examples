using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Configure GIF export options
        Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
        gifOptions.FrameSize = new Size(960, 720);          // Set the size of the resulting GIF
        gifOptions.DefaultDelay = 2000;                    // Delay for each slide (ms)
        gifOptions.TransitionFps = 35;                     // Frames per second for transitions

        // Save the presentation as an animated GIF
        presentation.Save("output.gif", SaveFormat.Gif, gifOptions);

        // Release resources
        presentation.Dispose();
    }
}