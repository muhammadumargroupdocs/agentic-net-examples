using System;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Set footer text for all slides
            presentation.HeaderFooterManager.SetAllFootersText("Company Confidential");
            // Make footers visible
            presentation.HeaderFooterManager.SetAllFootersVisibility(true);

            // Set header text for all slides
            presentation.HeaderFooterManager.SetAllHeadersText("Annual Report 2026");
            // Make headers visible
            presentation.HeaderFooterManager.SetAllHeadersVisibility(true);

            // Show slide numbers on all slides
            presentation.HeaderFooterManager.SetAllSlideNumbersVisibility(true);

            // Set document properties for accessibility
            Aspose.Slides.IDocumentProperties docProps = presentation.DocumentProperties;
            docProps.Title = "Annual Report 2026";
            docProps.Subject = "Financial Overview";
            docProps.Keywords = "Finance,Report,2026";

            // Save the presentation in PPT format
            presentation.Save("output.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
        }
    }
}