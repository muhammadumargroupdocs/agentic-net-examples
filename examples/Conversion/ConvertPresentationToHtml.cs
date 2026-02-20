using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HtmlOptions and set a custom formatter that embeds all fonts (WOFF format)
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            Aspose.Slides.Export.IHtmlFormatter formatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(
                new Aspose.Slides.Export.EmbedAllFontsHtmlController());
            htmlOptions.HtmlFormatter = formatter;

            // Save the presentation as HTML with embedded fonts
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}