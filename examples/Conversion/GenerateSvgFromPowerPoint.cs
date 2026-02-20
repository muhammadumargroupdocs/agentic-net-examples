using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Use WYSIWYG SVG options for high‑fidelity conversion
        Aspose.Slides.Export.SVGOptions svgOptions = Aspose.Slides.Export.SVGOptions.WYSIWYG;

        // Export each slide as an individual SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            string svgFileName = $"slide_{i + 1}.svg";
            using (FileStream svgStream = new FileStream(svgFileName, FileMode.Create, FileAccess.Write))
            {
                presentation.Slides[i].WriteAsSvg(svgStream, svgOptions);
            }
        }

        // Save the (potentially unchanged) presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}