using System;

class Program
{
    static void Main()
    {
        // Input PowerPoint file and output HTML file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();
        // Use a simple document formatter (slides one below another)
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("template.html", false);

        // Configure layout options to include comments
        Aspose.Slides.Export.HandoutLayoutingOptions handoutOptions = new Aspose.Slides.Export.HandoutLayoutingOptions();
        handoutOptions.PrintComments = true; // Enable comments in the exported HTML
        htmlOpt.SlidesLayoutOptions = handoutOptions;

        // Save the presentation as HTML with comments
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}