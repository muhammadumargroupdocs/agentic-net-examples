using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first master slide
        Aspose.Slides.IMasterSlide master = presentation.Masters[0];

        // Retrieve a predefined layout slide (TitleAndObject or fallback to Title)
        Aspose.Slides.ILayoutSlide layout = master.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.TitleAndObject);
        if (layout == null)
        {
            layout = master.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Title);
        }

        // Add a new slide based on the selected layout
        Aspose.Slides.ISlide newSlide = presentation.Slides.AddEmptySlide(layout);

        // Save the presentation
        string outPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Output.pptx");
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}