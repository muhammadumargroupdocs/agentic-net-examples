using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptxToPdfWithNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output PDF file path
            string outputPath = "output.pdf";

            // Load the source presentation
            using (Presentation presentation = new Presentation(inputPath))
            {
                // Create an auxiliary presentation to hold cloned slides
                using (Presentation auxPresentation = new Presentation())
                {
                    // Clone each slide from the source presentation into the auxiliary presentation
                    for (int i = 0; i < presentation.Slides.Count; i++)
                    {
                        ISlide sourceSlide = presentation.Slides[i];
                        auxPresentation.Slides.InsertClone(i, sourceSlide);
                    }

                    // Configure PDF options to include notes
                    PdfOptions pdfOptions = new PdfOptions();
                    pdfOptions.SlidesLayoutOptions = new NotesCommentsLayoutingOptions()
                    {
                        NotesPosition = NotesPositions.BottomFull
                    };

                    // Save the auxiliary presentation as PDF with notes
                    auxPresentation.Save(outputPath, SaveFormat.Pdf, pdfOptions);
                }
            }
        }
    }
}