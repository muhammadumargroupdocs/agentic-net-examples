using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Enable slide show options
        presentation.SlideShowSettings.ShowAnimation = true;
        presentation.SlideShowSettings.ShowNarration = true;
        presentation.SlideShowSettings.ShowMediaControls = true;
        presentation.SlideShowSettings.Loop = true;
        presentation.SlideShowSettings.UseTimings = true;

        // Save the presentation
        presentation.Save("SlideShowOptions.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}