using System;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");

        // Create XPS save options
        Aspose.Slides.Export.XpsOptions options = new Aspose.Slides.Export.XpsOptions();
        // Example option: convert metafiles to PNG
        options.SaveMetafilesAsPng = true;

        // Save the presentation as XPS using the options
        pres.Save("output.xps", Aspose.Slides.Export.SaveFormat.Xps, options);

        // Release resources
        pres.Dispose();
    }
}