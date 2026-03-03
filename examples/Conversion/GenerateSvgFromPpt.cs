using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SvgExportExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            var sourcePath = "input.pptx";

            // Load the presentation
            using (var presentation = new Aspose.Slides.Presentation(sourcePath))
            {
                // Iterate through all slides and export each as SVG
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    var slide = presentation.Slides[index];
                    var svgFileName = $"slide_{index + 1}.svg";

                    using (var svgStream = System.IO.File.Create(svgFileName))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation before exiting
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}