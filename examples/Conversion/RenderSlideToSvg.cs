using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";
        // Path where the SVG of the first slide will be saved
        string outputSvgPath = "slide_1.svg";

        // Load the presentation from the specified file
        Presentation pres = new Presentation(inputPath);

        // Access the first slide (index 0)
        ISlide slide = pres.Slides[0];

        // Write the slide content to an SVG file
        using (FileStream svgStream = File.Create(outputSvgPath))
        {
            slide.WriteAsSvg(svgStream);
        }

        // Save the (unchanged) presentation before exiting
        pres.Save("output.pptx", SaveFormat.Pptx);

        // Release resources
        pres.Dispose();
    }
}