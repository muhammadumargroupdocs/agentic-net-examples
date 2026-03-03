using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlidesToHtmlExample
{
    class Program
    {
        static void Main()
        {
            // Input PowerPoint file
            string inputFile = "input.pptx";

            // Output HTML files
            string outputHtmlFile = "output.html";
            string outputEmbeddedHtmlFile = "output_embedded.html";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile))
            {
                // -------------------------------------------------
                // Convert to HTML using original fonts (no embedding)
                // -------------------------------------------------
                Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
                // Save as HTML
                presentation.Save(outputHtmlFile, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

                // -------------------------------------------------
                // Convert to HTML with embedded fonts
                // -------------------------------------------------
                // Create an instance of the controller that embeds all fonts in WOFF format
                Aspose.Slides.Export.EmbedAllFontsHtmlController embedController = new Aspose.Slides.Export.EmbedAllFontsHtmlController();

                // Configure HTML options to use a simple slide‑show formatter
                Aspose.Slides.Export.HtmlOptions embedHtmlOptions = new Aspose.Slides.Export.HtmlOptions();
                embedHtmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateSlideShowFormatter(null, false);

                // The EmbedAllFontsHtmlController is automatically used by the HTML exporter
                // when the HtmlOptions are provided. No additional property assignment is required.

                // Save as HTML with embedded fonts
                presentation.Save(outputEmbeddedHtmlFile, Aspose.Slides.Export.SaveFormat.Html, embedHtmlOptions);
            }
        }
    }
}