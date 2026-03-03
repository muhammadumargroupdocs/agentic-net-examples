using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing.Imaging;

namespace ConvertPresentationToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            System.String inputPath = "input.pptx";
            // Path where the HTML output will be saved
            System.String outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HTML export options
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

            // Enable responsive layout for SVG images
            htmlOptions.SvgResponsiveLayout = true;

            // Set slide image format to high-quality JPEG with a scale factor that approximates 150 DPI
            // (default DPI is 96, so 150/96 ≈ 1.5625)
            htmlOptions.SlideImageFormat = Aspose.Slides.Export.SlideImageFormat.Bitmap(1.5625f, ImageFormat.Jpeg);

            // Save the presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Release resources
            presentation.Dispose();
        }
    }
}