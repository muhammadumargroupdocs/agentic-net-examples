using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        System.String inputPath = "input.pptx";
        // Output SVG file name format, {0} will be slide index
        System.String formatString = "slide_{0}.svg";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and export it as SVG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (System.IO.FileStream stream = new System.IO.FileStream(System.String.Format(formatString, index), System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation before exiting
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}