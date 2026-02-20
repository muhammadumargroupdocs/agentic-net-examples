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
        // CSS content
        string cssContent = "body { font-family: Arial; }";

        // Load presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Write CSS file
        File.WriteAllText(cssPath, cssContent);

        // Create HTML options and set formatter
        Aspose.Slides.Export.HtmlOptions options = new Aspose.Slides.Export.HtmlOptions();
        options.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateSlideShowFormatter(cssPath, true);

        // Save presentation as HTML with external CSS and images
        pres.Save(outputHtml, Aspose.Slides.Export.SaveFormat.Html, options);

        // Save presentation before exit (optional, e.g., as PPTX)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}