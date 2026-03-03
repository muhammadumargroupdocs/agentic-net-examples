using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the presentation and ensure it is disposed after use
        using (var presentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Save the presentation to XPS format using default settings
            presentation.Save("output.xps", Aspose.Slides.Export.SaveFormat.Xps);
        }
    }
}