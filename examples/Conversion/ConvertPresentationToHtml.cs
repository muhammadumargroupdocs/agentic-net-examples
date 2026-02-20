using System;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.html";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options and enable responsive SVG layout
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SvgResponsiveLayout = true;

        // Save the presentation as an HTML file using the specified options
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}