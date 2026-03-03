using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
        // Set a custom slide size (width: 800 points, height: 600 points) without scaling existing content
        presentation.SlideSize.SetSize(800f, 600f, Aspose.Slides.SlideSizeScaleType.DoNotScale);
        // Save the presentation as a PDF file
        presentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf);
        // Release resources
        presentation.Dispose();
    }
}