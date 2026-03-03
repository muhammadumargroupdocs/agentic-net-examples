using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output paths
            string inputPath = Path.Combine("input-folder", "presentation.pptx");
            string outputPath = Path.Combine("output-folder", "presentation.html");

            // Ensure output directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HTML export options
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

            // Configure SVG export options
            Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();

            // Set slide image format to SVG with the specified options
            htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

            // Save the presentation as HTML with SVG images
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}