using System;
using Aspose.Slides;
using System.IO;

class Program
{
    static void Main()
    {
        // Input ODP file path
        System.String inputPath = "input.odp";
        // Output SVG file name format (e.g., slide_0.svg, slide_1.svg, ...)
        System.String formatString = "slide_{0}.svg";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert each slide to SVG and save to a file
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (System.IO.FileStream stream = new System.IO.FileStream(System.String.Format(formatString, index), System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation before exiting (rewriting the original ODP)
        pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);
    }
}