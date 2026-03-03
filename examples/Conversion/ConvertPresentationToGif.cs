using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the presentation from a file
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Convert the presentation to an animated GIF using default settings
            pres.Save("output.gif", Aspose.Slides.Export.SaveFormat.Gif, new Aspose.Slides.Export.GifOptions());
        }
    }
}