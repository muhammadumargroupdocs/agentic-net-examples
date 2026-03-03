using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";

        // Path to the output HTML file
        string outputPath = "output.html";

        // Load the presentation from the file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

        // Create HTML export options (optional, can be customized)
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Save the presentation as HTML, converting all media (images, videos, etc.) to HTML resources
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}