using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a presentation (load from an existing file or use a blank one)
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");
        // Configure HTML export options with Arial as the default regular font
        Aspose.Slides.Export.HtmlOptions htmlOpts = new Aspose.Slides.Export.HtmlOptions();
        htmlOpts.DefaultRegularFont = "Arial";
        // Save the presentation as HTML using the configured options
        pres.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOpts);
        // Clean up resources
        pres.Dispose();
    }
}