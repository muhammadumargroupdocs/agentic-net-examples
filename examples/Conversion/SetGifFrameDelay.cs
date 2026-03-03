using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create GifOptions and set the default delay (in milliseconds)
        Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
        gifOptions.DefaultDelay = 2000; // 2 seconds per slide

        // Save the presentation as GIF with the specified options
        presentation.Save("output.gif", Aspose.Slides.Export.SaveFormat.Gif, gifOptions);
    }
}