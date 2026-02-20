using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideToSvgConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file path (PPT or PPTX)
            string inputPath = args.Length > 0 ? args[0] : "input.pptx";

            // Format string for SVG output files
            string formatString = "slide_{0}.svg";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Export each slide to an individual SVG file
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                using (FileStream stream = new FileStream(string.Format(formatString, index), FileMode.Create, FileAccess.Write))
                {
                    slide.WriteAsSvg(stream);
                }
            }

            // Save the presentation (required before exit)
            pres.Save("converted_output.pptx", SaveFormat.Pptx);

            // Dispose the presentation object
            pres.Dispose();
        }
    }
}