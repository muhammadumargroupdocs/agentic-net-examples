using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertSpecificSlideToHtml
{
    class Program
    {
        // Custom HTML formatting controller to add slide header/footer
        private class CustomFormattingController : IHtmlFormattingController
        {
            public void WriteDocumentStart(IHtmlGenerator generator, IPresentation presentation) { }

            public void WriteDocumentEnd(IHtmlGenerator generator, IPresentation presentation) { }

            public void WriteSlideStart(IHtmlGenerator generator, ISlide slide)
            {
                generator.AddHtml(string.Format(SlideHeader, generator.SlideIndex + 1));
            }

            public void WriteSlideEnd(IHtmlGenerator generator, ISlide slide)
            {
                generator.AddHtml(SlideFooter);
            }

            public void WriteShapeStart(IHtmlGenerator generator, IShape shape) { }

            public void WriteShapeEnd(IHtmlGenerator generator, IShape shape) { }
        }

        private const System.String SlideHeader = "<!-- Slide {0} start -->";
        private const System.String SlideFooter = "<!-- Slide {0} end -->";

        static void Main(string[] args)
        {
            // Input PowerPoint file
            System.String inputPath = "input.pptx";

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Configure HTML export options with custom formatter
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();
            htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateCustomFormatter(new CustomFormattingController());

            // Set notes layout (bottom full) via SlidesLayoutOptions
            Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
            notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
            htmlOptions.SlidesLayoutOptions = notesOptions;

            // Specify the slide index to convert (e.g., slide 2 -> index 1)
            System.Int32 targetSlideIndex = 1; // zero‑based index

            // Prepare output HTML file path
            System.String outputPath = "slide2.html";

            // Save only the specified slide as HTML
            int[] slideIndices = new int[] { targetSlideIndex + 1 }; // Save method expects 1‑based indices
            presentation.Save(outputPath, slideIndices, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

            // Clean up
            presentation.Dispose();
        }
    }
}