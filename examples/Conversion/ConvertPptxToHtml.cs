using System;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = "presentation.pptx";
        // Output HTML file path
        string outputHtml = "presentation.html";

        // Create a video player controller for handling media files
        Aspose.Slides.Export.VideoPlayerHtmlController controller = new Aspose.Slides.Export.VideoPlayerHtmlController(string.Empty, outputHtml, string.Empty);

        // Initialize HTML options with the controller
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions(controller);

        // Initialize SVG options with the same controller
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions(controller);

        // Set custom HTML formatter
        htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(controller);

        // Set slide image format to SVG
        htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as HTML with media files
        presentation.Save(outputHtml, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation
        presentation.Dispose();
    }
}