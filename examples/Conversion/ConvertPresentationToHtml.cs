using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create HtmlOptions to control HTML export; default settings preserve slide dimensions
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Save the presentation as HTML using the options
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}