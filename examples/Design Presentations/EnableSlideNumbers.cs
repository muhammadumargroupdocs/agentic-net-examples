using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Define output path
        string dataDir = "Data";
        string outputPath = System.IO.Path.Combine(dataDir, "SlideNumbers.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide's header/footer manager
        Aspose.Slides.IBaseSlideHeaderFooterManager headerFooterManager = presentation.Slides[0].HeaderFooterManager;

        // Enable slide number visibility if it is not already visible
        if (!headerFooterManager.IsSlideNumberVisible)
        {
            headerFooterManager.SetSlideNumberVisibility(true);
        }

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}