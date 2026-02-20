using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the HTML file
        string htmlPath = "input.html";
        // Path to save the generated PowerPoint file
        string outputPath = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Open the HTML file as a stream
        System.IO.Stream htmlStream = System.IO.File.OpenRead(htmlPath);

        // Insert slides from HTML at the beginning of the presentation
        presentation.Slides.InsertFromHtml(0, htmlStream, true);

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        htmlStream.Close();
        presentation.Dispose();
    }
}