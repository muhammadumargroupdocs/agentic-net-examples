using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPT file
        string sourcePath = "input.ppt";

        // Convert using default XPS options
        string outputPathDefault = "output_default.xps";
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath))
        {
            // Save the presentation to XPS format with default settings
            pres.Save(outputPathDefault, Aspose.Slides.Export.SaveFormat.Xps);
        }

        // Convert using custom XPS options
        string outputPathCustom = "output_custom.xps";
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath))
        {
            // Create and configure XpsOptions
            Aspose.Slides.Export.XpsOptions options = new Aspose.Slides.Export.XpsOptions();
            options.SaveMetafilesAsPng = true;   // Convert metafiles to PNG
            options.DrawSlidesFrame = true;      // Draw a frame around each slide

            // Save the presentation to XPS format with custom options
            pres.Save(outputPathCustom, Aspose.Slides.Export.SaveFormat.Xps, options);
        }
    }
}