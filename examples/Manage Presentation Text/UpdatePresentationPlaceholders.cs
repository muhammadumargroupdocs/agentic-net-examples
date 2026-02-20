using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Set footer text for all slides
        presentation.HeaderFooterManager.SetAllFootersText("Confidential");

        // Hide all date-time placeholders
        presentation.HeaderFooterManager.SetAllDateTimesVisibility(false);

        // Set header text for all notes and handout slides
        presentation.HeaderFooterManager.SetAllHeadersText("Company Name");

        // Save the presentation as PPTX
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}