using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation file path
        string inputPath = "input.pptx";
        // Output HTML file path
        string outputPath = "output.html";

        // No fonts are excluded from embedding
        string[] fontExclude = new string[0];

        // Create a controller that embeds all fonts in WOFF format
        Aspose.Slides.Export.EmbedAllFontsHtmlController embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController(fontExclude);

        // Set HTML export options to use the custom formatter with the embed controller
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions
        {
            HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(embedController)
        };

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as HTML with all fonts embedded
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Dispose the presentation object
        pres.Dispose();
    }
}