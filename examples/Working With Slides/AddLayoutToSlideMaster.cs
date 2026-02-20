using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the layout slides collection from the first master slide
        Aspose.Slides.IMasterLayoutSlideCollection layoutSlides = presentation.Masters[0].LayoutSlides;

        // Add a new blank layout slide with a custom name
        Aspose.Slides.ILayoutSlide layoutSlide = layoutSlides.Add(Aspose.Slides.SlideLayoutType.Blank, "MyCustomLayout");

        // Insert an empty slide at the beginning using the new layout
        presentation.Slides.InsertEmptySlide(0, layoutSlide);

        // Save the presentation
        string outputPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "output.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}