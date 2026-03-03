using System;
using System.IO;
using Aspose.Slides;

namespace ExportSlidesToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            System.String inputPath = "input.pptx";
            // Output file name pattern, {0} will be replaced by slide index
            System.String formatString = "slide_{0}.svg";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and export as SVG
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (System.IO.FileStream stream = new System.IO.FileStream(
                    System.String.Format(formatString, index + 1), // slide numbers start at 1
                    System.IO.FileMode.Create,
                    System.IO.FileAccess.Write))
                {
                    slide.WriteAsSvg(stream);
                }
            }

            // Dispose the presentation (required by authoring rules)
            pres.Dispose();
        }
    }
}