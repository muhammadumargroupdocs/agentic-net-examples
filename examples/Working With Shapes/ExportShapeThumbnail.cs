using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";
        // Path for the exported PNG thumbnail
        string outputImagePath = "slide1.png";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Export the slide thumbnail as PNG
        using (Aspose.Slides.IImage thumbnail = slide.GetImage())
        {
            thumbnail.Save(outputImagePath, Aspose.Slides.ImageFormat.Png);
        }

        // Save the presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}