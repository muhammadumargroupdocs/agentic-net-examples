using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Access the first section (index 0)
        Aspose.Slides.ISection section = presentation.Sections[0];

        // Rename the section
        section.Name = "Renamed Section";

        // Save the presentation with the updated section name
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}