using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Verify that an input file path is provided
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: Program <input-ppt-file>");
            return;
        }

        string inputPath = args[0];

        // Load the presentation from the specified file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert each slide to an individual SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                string svgFileName = $"slide_{i + 1}.svg";

                using (FileStream svgStream = File.Create(svgFileName))
                {
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the presentation before exiting (no modifications made)
            presentation.Save("saved_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}