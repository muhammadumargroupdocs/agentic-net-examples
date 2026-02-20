using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Enable media controls in slide show settings
        presentation.SlideShowSettings.ShowMediaControls = true;

        // Define output file path
        string outputPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "ModifiedPresentation.pptx");

        // Save the presentation as PPTX
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}