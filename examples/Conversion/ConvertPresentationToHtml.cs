using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesHtmlExport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.html";

            // List of fonts to exclude from embedding (optional)
            string[] excludeFonts = new string[] { "Arial", "Times New Roman" };

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create a controller that embeds all fonts except the excluded ones
            Aspose.Slides.Export.EmbedAllFontsHtmlController embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController(excludeFonts);

            // Set up HTML export options with the custom formatter
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions
            {
                HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(embedController)
            };

            // Save the presentation as HTML preserving original fonts
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}