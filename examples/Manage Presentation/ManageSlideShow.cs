using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Configure slide show settings
        presentation.SlideShowSettings.ShowMediaControls = true;
        presentation.SlideShowSettings.Loop = true;
        presentation.SlideShowSettings.ShowAnimation = false;
        presentation.SlideShowSettings.UseTimings = true;

        // Save the presentation
        string outputPath = "ManagedSlideShow.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}