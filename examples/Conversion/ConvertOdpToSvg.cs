using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input ODP file
        string inputPath = "input.odp";
        // Format string for output SVG files (slide numbers start from 1)
        string formatString = "slide_{0}.svg";

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert each slide to SVG and save to a separate file
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation (required by authoring rules)
        pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);
        pres.Dispose();
    }
}