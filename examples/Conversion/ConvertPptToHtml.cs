using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPT file path
        string inputPath = "input.pptx";
        // Output HTML file path
        string outputHtml = "output.html";

        // Create a video player HTML controller (required for media handling)
        VideoPlayerHtmlController controller = new VideoPlayerHtmlController("", outputHtml, "");

        // Initialize HTML options with the controller
        HtmlOptions htmlOptions = new HtmlOptions(controller);
        // Initialize SVG options with the same controller
        SVGOptions svgOptions = new SVGOptions(controller);

        // Set custom HTML formatter
        htmlOptions.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(controller);
        // Set slide image format to SVG
        htmlOptions.SlideImageFormat = SlideImageFormat.Svg(svgOptions);

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as HTML with media files
        presentation.Save(outputHtml, SaveFormat.Html, htmlOptions);

        // Dispose the presentation
        presentation.Dispose();
    }
}