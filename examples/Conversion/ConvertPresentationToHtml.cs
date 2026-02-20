using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define input PPT/PPTX file path and output HTML file path
        string inputPath = "presentation.pptx";
        string outputHtmlPath = "presentation.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create a video player controller (empty base URL)
        Aspose.Slides.Export.VideoPlayerHtmlController controller = new Aspose.Slides.Export.VideoPlayerHtmlController(string.Empty, outputHtmlPath, string.Empty);

        // Initialize HTML options with the controller
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions(controller);

        // Initialize SVG options with the same controller
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions(controller);

        // Set custom HTML formatter and slide image format (SVG)
        htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(controller);
        htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

        // Save the presentation as HTML with media files
        presentation.Save(outputHtmlPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}