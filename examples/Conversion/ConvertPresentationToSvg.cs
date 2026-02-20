using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";
        // Path where the SVG output (as HTML with SVG images) will be saved
        string outputPath = "output.html";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Configure HTML export options to use SVG for slide images
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(new Aspose.Slides.Export.SVGOptions());

            // Save the presentation as HTML; each slide will be rendered as an SVG image
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
        }
    }
}