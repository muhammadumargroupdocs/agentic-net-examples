using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get reference to the first slide
        Aspose.Slides.ISlide firstSlide = presentation.Slides[0];

        // Add a new section named "Introduction" starting with the first slide
        Aspose.Slides.ISection introductionSection = presentation.Sections.AddSection("Introduction", firstSlide);

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "IntroductionSection.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}