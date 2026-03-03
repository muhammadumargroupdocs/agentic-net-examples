using System;

class Program
{
    static void Main()
    {
        // Load the presentation
        var presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create a controller that embeds all fonts in WOFF format
        var embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController();

        // Build a custom HTML formatter using the embed controller
        var formatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(embedController);

        // Configure HTML export options to use the custom formatter
        var htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.HtmlFormatter = formatter;

        // Save the presentation as HTML with all fonts linked/embedded
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Ensure the presentation is saved and resources are released
        presentation.Dispose();
    }
}