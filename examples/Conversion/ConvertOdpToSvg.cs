using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace OdpToSvgConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source ODP file
            string inputPath = "input.odp";

            // Load the ODP presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through all slides and save each as an SVG file
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    Aspose.Slides.ISlide slide = presentation.Slides[index];
                    string svgPath = $"slide_{index}.svg";

                    using (FileStream svgStream = File.Create(svgPath))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation before exiting (optional conversion to another format)
                string outputPath = "output.odp";
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Odp);
            }
        }
    }
}