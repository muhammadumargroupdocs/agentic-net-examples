using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input ODP file path
        System.String inputPath = "input.odp";
        // Output file name format for each SVG slide
        System.String formatString = "slide_{0}.svg";

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Export each slide to an individual SVG file
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
    }
}