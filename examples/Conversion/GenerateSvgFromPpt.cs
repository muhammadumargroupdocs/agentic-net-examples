using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesSvgExport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            string srcFile = "input.pptx";
            // Output PowerPoint file (saved after processing)
            string destFile = "output.pptx";

            // Load presentation
            using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(srcFile))
            {
                // Iterate through each slide and export as SVG
                for (int i = 0; i < pres.Slides.Count; i++)
                {
                    Aspose.Slides.ISlide slide = pres.Slides[i];
                    string svgPath = $"Slide_{i + 1}.svg";

                    using (System.IO.FileStream svgStream = new System.IO.FileStream(svgPath, System.IO.FileMode.Create))
                    {
                        // Export slide to SVG using default options
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation before exiting
                pres.Save(destFile, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}