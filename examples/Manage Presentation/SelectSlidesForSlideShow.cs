using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManagePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Define the range of slides to be shown in the slide show (e.g., slides 1 to 3)
            Aspose.Slides.SlidesRange slideRange = new Aspose.Slides.SlidesRange();
            slideRange.Start = 1; // First slide index (1‑based)
            slideRange.End = 3;   // Last slide index

            // Assign the slide range to the slide show settings
            pres.SlideShowSettings.Slides = slideRange;

            // Optionally set the slide show type (e.g., presented by a speaker)
            pres.SlideShowSettings.SlideShowType = new PresentedBySpeaker();

            // Save the presentation
            pres.Save("SelectSlides.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            pres.Dispose();
        }
    }
}