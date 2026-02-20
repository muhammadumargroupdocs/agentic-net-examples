using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the header/footer manager for the first master slide
        Aspose.Slides.IMasterSlideHeaderFooterManager headerFooterManager = presentation.Masters[0].HeaderFooterManager;

        // Enable slide numbers visibility for master and child slides
        headerFooterManager.SetSlideNumberAndChildSlideNumbersVisibility(true);

        // Save the presentation as PPTX
        presentation.Save("NumbersPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}