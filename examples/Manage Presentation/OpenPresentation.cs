using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define source and destination file paths
        System.String sourcePath = "input.pptx";
        System.String destPath = "output.pptx";

        // Open the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

        // Access layout formats (optional demonstration)
        // foreach (Aspose.Slides.ILayoutSlide layoutSlide in presentation.LayoutSlides)
        // {
        //     foreach (Aspose.Slides.IShape shape in layoutSlide.Shapes)
        //     {
        //         Aspose.Slides.IFillFormat fillFormat = shape.FillFormat;
        //         Aspose.Slides.ILineFormat lineFormat = shape.LineFormat;
        //     }
        // }

        // Save the presentation
        presentation.Save(destPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}