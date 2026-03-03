using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Presentation presentation = new Presentation("input.pptx");

        // Create HTML export options (default does not embed fonts)
        HtmlOptions htmlOptions = new HtmlOptions();

        // Save the presentation as a single HTML file without embedding fonts
        presentation.Save("output.html", SaveFormat.Html, htmlOptions);
    }
}