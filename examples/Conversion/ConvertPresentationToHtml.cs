using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "sample.pptx";
            string outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Set HTML export options with a custom formatter
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(new CustomFormattingController());

            // Save the presentation as HTML
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
        }
    }

    // Custom HTML formatting controller to inject custom CSS and structure
    public class CustomFormattingController : Aspose.Slides.Export.IHtmlFormattingController
    {
        public void WriteDocumentStart(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.IPresentation presentation)
        {
            generator.AddHtml("<!DOCTYPE html><html><head><meta charset=\"UTF-8\"><title>Presentation</title><style>body{font-family:Arial;}</style></head><body>");
        }

        public void WriteDocumentEnd(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.IPresentation presentation)
        {
            generator.AddHtml("</body></html>");
        }

        public void WriteSlideStart(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.ISlide slide)
        {
            generator.AddHtml(string.Format("<div class=\"slide\" id=\"slide{0}\">", generator.SlideIndex + 1));
        }

        public void WriteSlideEnd(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.ISlide slide)
        {
            generator.AddHtml("</div>");
        }

        public void WriteShapeStart(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.IShape shape) { }

        public void WriteShapeEnd(Aspose.Slides.Export.IHtmlGenerator generator, Aspose.Slides.IShape shape) { }
    }
}