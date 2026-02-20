using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create default SVG options
        Aspose.Slides.Export.SVGOptions svgOptions = Aspose.Slides.Export.SVGOptions.Default;

        // Obtain SVG image format (demonstrates usage of SlideImageFormat.Svg)
        Aspose.Slides.Export.SlideImageFormat svgFormat = Aspose.Slides.Export.SlideImageFormat.Svg(svgOptions);

        // Export each slide as an HTML file that contains SVG images
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            string htmlPath = $"slide_{i + 1}.html";
            presentation.Save(htmlPath, Aspose.Slides.Export.SaveFormat.Html);
        }

        // Save the presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}