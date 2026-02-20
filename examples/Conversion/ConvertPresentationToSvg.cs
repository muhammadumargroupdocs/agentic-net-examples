using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string srcFile = "input.pptx";
        // Path to save the (unchanged) presentation before exiting
        string destFile = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(srcFile);

        // Export each slide to an individual SVG file
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgPath = $"slide_{i + 1}.svg";

            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                slide.WriteAsSvg(fs);
            }
        }

        // Save the presentation before exiting (as required)
        pres.Save(destFile, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}