using System;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        var presentation = new Aspose.Slides.Presentation("input.pptx");

        // Configure Html5Options with slide layout settings
        var options = new Aspose.Slides.Export.Html5Options
        {
            SlidesLayoutOptions = new Aspose.Slides.Export.HandoutLayoutingOptions
            {
                Handout = Aspose.Slides.Export.HandoutType.Handouts4Horizontal
            }
        };

        // Save the presentation as HTML5
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html5, options);
    }
}