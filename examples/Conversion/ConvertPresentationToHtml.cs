using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PowerPoint file
        string inputPath = "input.pptx";
        // Output HTML file
        string outputPath = "output.html";

        // List of fonts to exclude from embedding (empty in this example)
        string[] fontExcludeList = new string[0];

        // Create a controller that embeds all fonts in WOFF format
        Aspose.Slides.Export.EmbedAllFontsHtmlController embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController(fontExcludeList);

        // Configure HTML export options with the custom formatter
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions
        {
            HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(embedController)
        };

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as HTML with embedded fonts
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}