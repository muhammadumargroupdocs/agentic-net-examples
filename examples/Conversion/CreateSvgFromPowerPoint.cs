using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";
        // Path where the SVG of the first slide will be saved
        string svgOutputPath = "slide1.svg";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Create SVG options (default settings)
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();

        // Write the slide as SVG to a file
        using (FileStream svgStream = new FileStream(svgOutputPath, FileMode.Create, FileAccess.Write))
        {
            slide.WriteAsSvg(svgStream, svgOptions);
        }

        // Save the presentation (required by authoring rules)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}