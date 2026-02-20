using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.xps";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create XPS options with custom settings
        Aspose.Slides.Export.XpsOptions xpsOptions = new Aspose.Slides.Export.XpsOptions();
        xpsOptions.DrawSlidesFrame = true;          // Draw a frame around each slide
        xpsOptions.ShowHiddenSlides = true;         // Include hidden slides
        xpsOptions.SaveMetafilesAsPng = true;       // Convert metafiles to PNG

        // Save the presentation to XPS using the custom options
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps, xpsOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}