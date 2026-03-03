using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation path
        string inputPath = "input.pptx";
        // Output HTML file path
        string outputHtml = "output.html";
        // CSS file path
        string cssPath = "styles.css";

        // CSS content to be saved
        string cssContent = "body { font-family: Arial; }";

        // Write CSS file to disk
        File.WriteAllText(cssPath, cssContent);

        // Load the presentation
        Presentation pres = new Presentation(inputPath);

        // Configure HTML export options with external CSS
        HtmlOptions options = new HtmlOptions();
        options.HtmlFormatter = HtmlFormatter.CreateSlideShowFormatter(cssPath, true);

        // Export presentation to HTML (images will be saved alongside the HTML file)
        pres.Save(outputHtml, SaveFormat.Html, options);

        // Clean up resources
        pres.Dispose();
    }
}