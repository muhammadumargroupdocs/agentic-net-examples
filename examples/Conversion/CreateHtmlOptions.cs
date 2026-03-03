using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Create HtmlOptions for conversion
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Set an example option (default font)
        htmlOptions.DefaultRegularFont = "Arial";

        // Save the presentation as HTML using the options
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
    }
}