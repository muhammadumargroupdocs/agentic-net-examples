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
            string presentationPath = "input.pptx";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(presentationPath))
            {
                // Iterate through all slides and export each as SVG
                for (int i = 0; i < presentation.Slides.Count; i++)
                {
                    // Get the current slide
                    Aspose.Slides.ISlide slide = presentation.Slides[i];

                    // Create SVG file name
                    string svgPath = $"slide_{i + 1}.svg";

                    // Write slide to SVG file
                    using (FileStream svgStream = File.Create(svgPath))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation (required by authoring rules)
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}