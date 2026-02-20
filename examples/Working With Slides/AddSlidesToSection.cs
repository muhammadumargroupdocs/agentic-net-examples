using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AddSlidesToSection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            string dataDir = Directory.GetCurrentDirectory();
            string inputPath = Path.Combine(dataDir, "input.pptx");
            string outputPath = Path.Combine(dataDir, "output.pptx");

            // Load the existing presentation
            Presentation presentation = new Presentation(inputPath);

            // Ensure there is at least one section; if not, create one starting from the first slide
            ISection targetSection;
            if (presentation.Sections.Count > 0)
            {
                targetSection = presentation.Sections[0];
            }
            else
            {
                // Create a new section named "Section 1" starting from the first slide
                targetSection = presentation.Sections.AddSection("Section 1", presentation.Slides[0]);
            }

            // Clone the first slide and add it to the existing section
            presentation.Slides.AddClone(presentation.Slides[0], targetSection);

            // Optionally, add another slide by cloning the second slide if it exists
            if (presentation.Slides.Count > 1)
            {
                presentation.Slides.AddClone(presentation.Slides[1], targetSection);
            }

            // Save the modified presentation
            presentation.Save(outputPath, SaveFormat.Pptx);
        }
    }
}