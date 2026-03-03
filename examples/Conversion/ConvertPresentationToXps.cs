using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the source PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Convert and save to XPS using default options
        presentation.Save("output.xps", Aspose.Slides.Export.SaveFormat.Xps);

        // Convert and save to XPS using custom options (e.g., save metafiles as PNG)
        Aspose.Slides.Export.XpsOptions options = new Aspose.Slides.Export.XpsOptions();
        options.SaveMetafilesAsPng = true;
        presentation.Save("output_custom.xps", Aspose.Slides.Export.SaveFormat.Xps, options);

        // Release resources
        presentation.Dispose();
    }
}