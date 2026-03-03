using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Load the source PPTX file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Iterate through all slides and save each as an SVG file
        for (int index = 0; index < presentation.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[index];
            string svgPath = $"slide_{index + 1}.svg";

            using (FileStream fileStream = File.Create(svgPath))
            {
                // Write the current slide to the SVG stream
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the (potentially unchanged) presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}