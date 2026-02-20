using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesHtmlExport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file path
            System.String inputPath = "input.pptx";
            // Output HTML file path
            System.String outputHtml = "output.html";

            // Create a controller for handling video and audio files during HTML export
            Aspose.Slides.Export.VideoPlayerHtmlController controller = new Aspose.Slides.Export.VideoPlayerHtmlController("", outputHtml, "");

            // Initialize HTML export options with the controller
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions(controller);
            // Initialize SVG options with the same controller
            Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions(controller);

            // Set custom HTML formatter and slide image format (SVG)
            htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(controller);
            htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Save the presentation as HTML with media files
            presentation.Save(outputHtml, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}