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
            // Path to the input ODP file
            System.String inputPath = "presentation.odp";

            // Folder where SVG files will be saved
            System.String outputFolder = "SvgOutput";
            System.IO.Directory.CreateDirectory(outputFolder);

            // Load the ODP presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and save it as an SVG file
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                System.String svgFilePath = System.String.Format(System.IO.Path.Combine(outputFolder, "slide_{0}.svg"), index + 1);
                using (System.IO.FileStream stream = new System.IO.FileStream(svgFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    slide.WriteAsSvg(stream);
                }
            }

            // Save the presentation (required by authoring rules)
            pres.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);

            // Release resources
            pres.Dispose();
        }
    }
}