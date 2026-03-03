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

            // Directory where SVG files will be saved
            string outputDirectory = "output_svgs";
            Directory.CreateDirectory(outputDirectory);

            // Load the ODP presentation
            using (Presentation presentation = new Presentation(inputPath))
            {
                // Iterate through all slides and save each as an SVG file
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    ISlide slide = presentation.Slides[index];
                    string svgFilePath = Path.Combine(outputDirectory, $"slide_{index + 1}.svg");

                    using (Stream svgStream = File.Create(svgFilePath))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation before exiting (optional, as no changes are made)
                presentation.Save("output.odp", SaveFormat.Odp);
            }
        }
    }
}