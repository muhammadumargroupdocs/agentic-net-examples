using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file path
        System.String inputPath = "input.pptx";
        // Output HTML file path
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options (default DPI is 72)
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Save the presentation as HTML
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}