using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input ODP file
        string inputPath = "sample.odp";
        // Format string for output SVG files (e.g., slide_1.svg, slide_2.svg, ...)
        string formatString = "slide_{0}.svg";

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Export each slide to an individual SVG file
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation (required before exiting)
        pres.Save("output.odp", Aspose.Slides.Export.SaveFormat.Odp);
        pres.Dispose();
    }
}