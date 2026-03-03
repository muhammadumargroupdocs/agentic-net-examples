using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToPdfNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the source presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
            {
                // Create an auxiliary presentation to hold notes layout
                using (Aspose.Slides.Presentation auxPresentation = new Aspose.Slides.Presentation())
                {
                    // Clone all slides into the auxiliary presentation
                    for (int i = 0; i < presentation.Slides.Count; i++)
                    {
                        Aspose.Slides.ISlide srcSlide = presentation.Slides[i];
                        auxPresentation.Slides.InsertClone(i, srcSlide);
                    }

                    // Set slide size (standard 8.5 x 11 inches)
                    auxPresentation.SlideSize.SetSize(612f, 792f, Aspose.Slides.SlideSizeScaleType.EnsureFit);

                    // Configure PDF options to include notes at the bottom
                    Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                    pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions()
                    {
                        NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull
                    };

                    // Save the auxiliary presentation as PDF with notes
                    auxPresentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
                }
            }
        }
    }
}