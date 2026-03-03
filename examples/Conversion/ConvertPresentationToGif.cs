using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";
        // Path to the output GIF file
        string outputPath = "output.gif";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Create GIF export options (optional custom settings)
            Aspose.Slides.Export.GifOptions gifOptions = new Aspose.Slides.Export.GifOptions();
            // Set default delay between frames (in milliseconds)
            gifOptions.DefaultDelay = 2000;

            // Save the presentation as an animated GIF
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, gifOptions);
        }
    }
}