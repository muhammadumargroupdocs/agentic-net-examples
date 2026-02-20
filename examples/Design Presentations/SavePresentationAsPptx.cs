using System;

class Program
{
    static void Main()
    {
        // Create a new presentation (contains one empty slide by default)
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide (optional, just to demonstrate slide handling)
        Aspose.Slides.ISlide firstSlide = presentation.Slides[0];

        // Save the presentation as PPTX
        presentation.Save("DesignPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}