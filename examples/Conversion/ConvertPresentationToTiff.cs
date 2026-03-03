using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source presentation
        var presentation = new Aspose.Slides.Presentation("input.pptx");

        // Configure TIFF export options with custom image size and DPI
        var tiffOptions = new Aspose.Slides.Export.TiffOptions();
        tiffOptions.ImageSize = new Size(1728, 1078);
        tiffOptions.DpiX = 200;
        tiffOptions.DpiY = 100;
        tiffOptions.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.Default;

        // Save the presentation as a TIFF file using the specified options
        presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Release resources
        presentation.Dispose();
    }
}