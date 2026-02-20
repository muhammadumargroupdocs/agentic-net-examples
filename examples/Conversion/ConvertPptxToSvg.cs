using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        string srcFile = "input.pptx";
        // Path to save the (unchanged) presentation before exiting
        string destFile = "output.pptx";

        // Load the presentation
        Presentation pres = new Presentation(srcFile);

        // Export each slide to an individual SVG file
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            string svgPath = $"slide_{i + 1}.svg";
            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                pres.Slides[i].WriteAsSvg(fs);
            }
        }

        // Save the presentation before exiting
        pres.Save(destFile, SaveFormat.Pptx);
    }
}