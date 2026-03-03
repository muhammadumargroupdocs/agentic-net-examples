using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source presentation file
        string inputPath = "input.pptx";
        // Path for the generated HTML file
        string outputPath = "output.html";

        // Load the presentation from the file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Create HTML export options (optional configuration)
            Aspose.Slides.Export.HtmlOptions options = new Aspose.Slides.Export.HtmlOptions();

            // Save the presentation as HTML using the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, options);
        }
    }
}