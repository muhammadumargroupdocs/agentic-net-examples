using System;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        System.String inputPath = "input.pptx";
        // Path where the responsive HTML will be saved
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Configure HTML export options for responsive layout
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.SvgResponsiveLayout = true;

        // Save the presentation as responsive HTML
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}