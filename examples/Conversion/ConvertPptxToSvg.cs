using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the input PPTX file
        string inputPath = "input.pptx";

        // Directory where SVG files will be generated
        string outputFolder = "output_svg";
        Directory.CreateDirectory(outputFolder);

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create default SVG options
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();

        // Configure HTML export to use SVG for slide images
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

        // Save the presentation as HTML (generates SVG files in the output folder)
        string htmlOutputPath = Path.Combine(outputFolder, "presentation.html");
        presentation.Save(htmlOutputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Remove the intermediate HTML file if only SVG files are needed
        File.Delete(htmlOutputPath);
    }
}