using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Path to the input PPTX file
        string inputPath = "input.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and save as SVG
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgPath = $"slide_{i + 1}.svg";

            using (FileStream fileStream = File.Create(svgPath))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation (no modifications made)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}