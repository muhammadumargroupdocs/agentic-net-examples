using System;

namespace AsposeSlidesHtmlConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            System.String inputPath = "input.pptx";
            // Output HTML file path
            System.String outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HTML export options
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            // Enable responsive SVG layout
            htmlOptions.SvgResponsiveLayout = true;

            // Save the presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Release resources
            presentation.Dispose();
        }
    }
}