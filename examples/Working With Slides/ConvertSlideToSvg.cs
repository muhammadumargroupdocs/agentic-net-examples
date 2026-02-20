using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output SVG file name pattern (e.g., slide_1.svg)
        string formatString = "slide_{0}.svg";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert each slide to SVG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (System.IO.FileStream stream = new System.IO.FileStream(string.Format(formatString, index + 1), System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation before exiting
        string outputPath = "output.pptx";
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}