using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Path where the rendered GIF will be saved
        string gifOutputPath = "slide1.gif";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide (index 0)
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Render the slide to an image and save it as GIF
        using (Aspose.Slides.IImage image = slide.GetImage())
        {
            image.Save(gifOutputPath, Aspose.Slides.ImageFormat.Gif);
        }

        // Save the (unchanged) presentation before exiting
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}