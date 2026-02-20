using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";
        // Path where the HTML output will be saved
        string outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Configure HTML export options to preserve original slide dimensions
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SvgResponsiveLayout = false; // keep width and height attributes

        // Save the presentation as HTML
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}