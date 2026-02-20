using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PowerPoint file path
        string inputPath = "input.pptx";
        // Output HTML file path (contains SVG images for each slide)
        string outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Configure HTML export options to use SVG for slide images
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(new Aspose.Slides.Export.SVGOptions());

        // Save the presentation as HTML with embedded SVG images
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}