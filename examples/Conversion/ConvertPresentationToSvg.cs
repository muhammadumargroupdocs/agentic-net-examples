using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PowerPointToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string inputPath = "input.pptx";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through all slides and save each as an SVG file
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    Aspose.Slides.ISlide slide = presentation.Slides[index];
                    string svgPath = $"slide_{index + 1}.svg";

                    using (FileStream svgStream = File.Create(svgPath))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation (no modifications made) before exiting
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}