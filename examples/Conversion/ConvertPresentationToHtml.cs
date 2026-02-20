using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "presentation.pptx";
        // Path for the generated HTML file
        string outputPath = "presentation.html";

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
        {
            // Configure HTML export options with high-quality images at 150 DPI
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Bitmap(150f, ImageFormat.Png);

            // Save the presentation as HTML
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
        }
    }
}