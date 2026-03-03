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
        // Custom CSS file URL or path
        string cssPath = "custom.css";

        // Load the presentation
        using (Presentation presentation = new Presentation(inputPath))
        {
            // Create an HTML formatter with custom CSS and slide titles enabled
            HtmlFormatter formatter = HtmlFormatter.CreateDocumentFormatter(cssPath, true);

            // Set up HTML export options and assign the custom formatter
            HtmlOptions options = new HtmlOptions();
            options.HtmlFormatter = formatter;

            // Save the presentation as HTML using the specified options
            presentation.Save(outputPath, SaveFormat.Html, options);
        }
    }
}