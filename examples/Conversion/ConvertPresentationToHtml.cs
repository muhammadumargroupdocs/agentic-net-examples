using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        System.String inputPath = "input.pptx";
        // Path for the generated HTML file
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Configure HTML export options for high‑quality images
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.JpegQuality = 100; // Maximum JPEG quality

        // Save the presentation as HTML
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        pres.Dispose();
    }
}