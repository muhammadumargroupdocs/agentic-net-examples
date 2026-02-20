using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Set the slide show type to PresentedBySpeaker (full screen)
        pres.SlideShowSettings.SlideShowType = new Aspose.Slides.PresentedBySpeaker();

        // Save the presentation
        pres.Save("PresentedBySpeaker.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}