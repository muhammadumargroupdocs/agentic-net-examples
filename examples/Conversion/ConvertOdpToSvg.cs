using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Determine input ODP file path
        System.String inputPath;
        if (args.Length > 0 && !System.String.IsNullOrEmpty(args[0]))
        {
            inputPath = args[0];
        }
        else
        {
            inputPath = "input.odp"; // default path if none provided
        }

        // Format string for SVG output files
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

        // Save the presentation before exiting (no modifications made)
        pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);
    }
}