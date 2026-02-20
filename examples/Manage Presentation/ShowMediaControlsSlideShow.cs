using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Show media controls during the slide show
        presentation.SlideShowSettings.ShowMediaControls = true;

        // Save the presentation
        presentation.Save("ShowMediaControls.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}