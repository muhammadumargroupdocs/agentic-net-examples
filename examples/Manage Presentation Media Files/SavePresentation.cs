using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load an existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
        // Enable media controls in slide show settings
        presentation.SlideShowSettings.ShowMediaControls = true;
        // Save the modified presentation as PPTX
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        // Clean up resources
        presentation.Dispose();
    }
}