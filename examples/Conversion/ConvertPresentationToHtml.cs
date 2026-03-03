using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";
        // Path to the output HTML file
        string outputPath = "output.html";
        // Path to the custom CSS file
        string cssPath = "style.css";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Create HTML options and set a custom HTML formatter with CSS
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter(cssPath, true);

            // Save the presentation as HTML using the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
        }
    }
}