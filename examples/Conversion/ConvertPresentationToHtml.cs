using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the source PowerPoint file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Configure HTML export options to remove cropped picture areas
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
        htmlOptions.DeletePicturesCroppedAreas = true;

        // Save the presentation as HTML using the configured options
        presentation.Save("output.html", Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}