using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        string srcFile = "input.odp";
        // Folder where SVG files will be saved
        string outputFolder = "output";
        Directory.CreateDirectory(outputFolder);

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(srcFile);

        // Iterate through each slide and save as SVG
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgPath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");
            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                // Save slide as SVG using default options
                slide.WriteAsSvg(fs, new Aspose.Slides.Export.SVGOptions());
            }
        }

        // Save the presentation before exiting (as per authoring rules)
        string savedPath = "saved_output.odp";
        pres.Save(savedPath, Aspose.Slides.Export.SaveFormat.Odp);
    }
}