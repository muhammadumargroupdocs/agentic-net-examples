using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input PowerPoint file
        string inputPath = "input.pptx";
        // Path to the output HTML file
        string outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Configure slide image format to use SVG
        Aspose.Slides.Export.SlideImageFormat slideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(new Aspose.Slides.Export.SVGOptions());
        htmlOptions.SlideImageFormat = slideImageFormat;

        // Save the presentation as HTML with SVG images
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation object
        pres.Dispose();
    }
}