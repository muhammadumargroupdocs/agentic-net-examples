using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation from the input file
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Ensure there is at least one section to delete
        if (pres.Sections.Count > 0)
        {
            // Retrieve the first section
            Aspose.Slides.ISection section = pres.Sections[0];

            // Delete the section together with its slides
            pres.Sections.RemoveSectionWithSlides(section);
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}