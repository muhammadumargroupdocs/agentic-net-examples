using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input ODP file
        System.String inputPath = "input.odp";
        // Format string for output SVG files (e.g., slide_1.svg, slide_2.svg, ...)
        System.String formatString = "slide_{0}.svg";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and save as SVG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (System.IO.FileStream stream = new System.IO.FileStream(System.String.Format(formatString, index + 1), System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation (required before exit)
        pres.Save("output.odp", Aspose.Slides.Export.SaveFormat.Odp);
        pres.Dispose();
    }
}