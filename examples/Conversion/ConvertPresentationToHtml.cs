using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Configure HTML export options for high‑quality images
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.JpegQuality = 100; // maximum JPEG quality
        htmlOptions.SlideImageFormat = new Aspose.Slides.Export.SlideImageFormat(); // default high‑quality image format

        // Save the presentation as a single HTML file
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
    }
}