using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output SVG file name format, {0} will be replaced by slide index
            string formatString = "slide_{0}.svg";

            // Load the presentation
            using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through each slide and save as SVG
                for (int index = 0; index < pres.Slides.Count; index++)
                {
                    Aspose.Slides.ISlide slide = pres.Slides[index];
                    using (FileStream stream = new FileStream(string.Format(formatString, index), FileMode.Create, FileAccess.Write))
                    {
                        slide.WriteAsSvg(stream);
                    }
                }

                // Save the presentation before exiting (optional, can be same as input)
                pres.Save("output.pptx", SaveFormat.Pptx);
            }
        }
    }
}