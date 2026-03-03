using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load an existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create a file stream to write the SVG output
        using (FileStream fileStream = File.Create("slide_1.svg"))
        {
            // Render the first slide as SVG
            presentation.Slides[0].WriteAsSvg(fileStream);
        }

        // Save the presentation (if any modifications were made)
        presentation.Save("output.pptx", SaveFormat.Pptx);
    }
}