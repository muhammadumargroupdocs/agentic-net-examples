using System;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the presentation from a file
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");

        // Create XPS options with custom settings
        Aspose.Slides.Export.XpsOptions options = new Aspose.Slides.Export.XpsOptions();
        // Convert all metafiles to PNG images
        options.SaveMetafilesAsPng = true;

        // Save the presentation as XPS using the custom options
        pres.Save("output.xps", Aspose.Slides.Export.SaveFormat.Xps, options);

        // Release resources
        pres.Dispose();
    }
}