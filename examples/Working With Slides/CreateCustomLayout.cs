using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace CustomLayoutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first master slide
            Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];

            // Add a custom layout slide to the global layout collection
            Aspose.Slides.ILayoutSlide customLayout = presentation.LayoutSlides.Add(masterSlide, Aspose.Slides.SlideLayoutType.Custom, "MyCustomLayout");

            // Add a text placeholder to the custom layout
            // Parameters: x, y, width, height (in points)
            customLayout.PlaceholderManager.AddTextPlaceholder(50f, 50f, 400f, 100f);

            // Insert a new slide that uses the custom layout
            presentation.Slides.InsertEmptySlide(0, customLayout);

            // Save the presentation
            presentation.Save("CustomLayoutPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}