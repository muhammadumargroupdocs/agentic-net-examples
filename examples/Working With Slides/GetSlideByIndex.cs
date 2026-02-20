using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        System.String inputFile = "input.pptx";
        System.String outputFile = "output.pptx";
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Example operation on the accessed slide
        slide.Name = "First Slide";
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}