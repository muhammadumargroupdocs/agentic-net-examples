using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Remove background from each slide
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            // Set background type to NotDefined to clear any existing background
            presentation.Slides[i].Background.Type = Aspose.Slides.BackgroundType.NotDefined;
        }

        // Save the presentation
        presentation.Save("RemovedBackground.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}