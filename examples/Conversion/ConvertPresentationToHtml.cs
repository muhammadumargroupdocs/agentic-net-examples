using System;

class Program
{
    static void Main()
    {
        // Load the PowerPoint file
        var presentation = new Aspose.Slides.Presentation("input.pptx");
        // Convert and save to HTML (default DPI 72)
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html);
        // Release resources
        presentation.Dispose();
    }
}