using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation path (first argument or default)
            string inputPath;
            if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
                inputPath = args[0];
            else
                inputPath = "presentation.ppt";

            // Output HTML file path (HTML file will reference generated SVG files)
            string outputHtmlPath = Path.ChangeExtension(inputPath, ".html");

            // Controller for handling media files (SVG images) during HTML export
            VideoPlayerHtmlController controller = new VideoPlayerHtmlController(String.Empty, outputHtmlPath, String.Empty);

            // HTML export options
            HtmlOptions htmlOptions = new HtmlOptions(controller);

            // SVG export options
            SVGOptions svgOptions = new SVGOptions(controller);

            // Use custom HTML formatter that works with the controller
            htmlOptions.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(controller);

            // Set slide image format to SVG using the SVG options
            htmlOptions.SlideImageFormat = SlideImageFormat.Svg(svgOptions);

            // Load the presentation and save it as HTML with embedded SVG images
            using (Presentation presentation = new Presentation(inputPath))
            {
                presentation.Save(outputHtmlPath, SaveFormat.Html, htmlOptions);
            }
        }
    }
}