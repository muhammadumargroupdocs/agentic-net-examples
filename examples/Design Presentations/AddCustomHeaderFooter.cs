using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output path
        string dataDir = "C:\\Data\\";
        string outputPath = System.IO.Path.Combine(dataDir, "CustomHeaderFooter.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Set custom footer text and make it visible on all slides
        presentation.HeaderFooterManager.SetAllFootersText("My Custom Footer");
        presentation.HeaderFooterManager.SetAllFootersVisibility(true);

        // Set custom header text and make it visible on all slides
        presentation.HeaderFooterManager.SetAllHeadersText("My Custom Header");
        presentation.HeaderFooterManager.SetAllHeadersVisibility(true);

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}