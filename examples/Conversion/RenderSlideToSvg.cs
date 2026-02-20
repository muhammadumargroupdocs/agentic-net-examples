using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input presentation file
        string inputPath = "input.pptx";
        // Output SVG file for the first slide
        string outputSvgPath = "slide1.svg";
        // Output presentation file (saved before exit)
        string outputPresPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Render the slide as SVG and save to file
        using (FileStream svgStream = new FileStream(outputSvgPath, FileMode.Create))
        {
            slide.WriteAsSvg(svgStream);
        }

        // Save the presentation before exiting
        pres.Save(outputPresPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}