using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Create a controller that embeds all fonts in the HTML output
        Aspose.Slides.Export.EmbedAllFontsHtmlController embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController();

        // Create a custom HTML formatter using the embed controller
        Aspose.Slides.Export.HtmlFormatter customFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(embedController);

        // Assign the custom formatter to the HTML options
        htmlOptions.HtmlFormatter = customFormatter;

        // Save the presentation as HTML with embedded original fonts
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Clean up resources
        presentation.Dispose();
    }
}