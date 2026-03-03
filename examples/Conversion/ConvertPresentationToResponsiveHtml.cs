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

        // Create SVG export options (default options)
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();

        // Configure slide image format to use SVG with the specified options
        Aspose.Slides.Export.SlideImageFormat slideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

        // Set up HTML export options for responsive layout
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SvgResponsiveLayout = true;               // Enable responsive SVG
        htmlOptions.SlideImageFormat = slideImageFormat;      // Use SVG for slide images

        // Save the presentation as a single responsive HTML file
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
    }
}