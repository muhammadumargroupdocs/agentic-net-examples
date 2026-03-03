using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Instantiate a Presentation object that represents a presentation file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation())
        {
            // Save the presentation before exiting
            presentation.Save("NewPresentation_out.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}