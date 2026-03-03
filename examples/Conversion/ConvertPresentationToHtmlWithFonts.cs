using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToHtmlWithFonts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output HTML file path
            string outputPath = "output.html";

            // No fonts are excluded from embedding
            string[] fontExclude = new string[0];

            // Create a controller that embeds all fonts in the HTML output
            EmbedAllFontsHtmlController embedController = new EmbedAllFontsHtmlController(fontExclude);

            // Set up HTML export options with the custom formatter
            HtmlOptions htmlOptions = new HtmlOptions();
            htmlOptions.HtmlFormatter = HtmlFormatter.CreateCustomFormatter(embedController);

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Save the presentation as HTML with linked (embedded) fonts
            presentation.Save(outputPath, SaveFormat.Html, htmlOptions);

            // Dispose the presentation to release resources
            presentation.Dispose();
        }
    }
}