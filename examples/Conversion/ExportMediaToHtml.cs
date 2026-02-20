using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output paths
        string dataDir = "Data";
        string inputFile = Path.Combine(dataDir, "input.pptx");
        string outputDir = "Output";
        Directory.CreateDirectory(outputDir);
        const string htmlFileName = "output.html";
        const string baseUri = "http://example.com/";

        // Load the presentation
        Presentation pres = new Presentation(inputFile);

        // Set up the HTML export controller
        VideoPlayerHtmlController controller = new VideoPlayerHtmlController(outputDir, htmlFileName, baseUri);
        HtmlOptions htmlOptions = new HtmlOptions(controller);
        SVGOptions svgOptions = new SVGOptions(controller);
        htmlOptions.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(controller);
        htmlOptions.SlideImageFormat = SlideImageFormat.Svg(svgOptions);

        // Save the presentation as HTML with media files
        pres.Save(Path.Combine(outputDir, htmlFileName), SaveFormat.Html, htmlOptions);
    }
}