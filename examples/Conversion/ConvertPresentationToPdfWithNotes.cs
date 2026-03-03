using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the source presentation
        using (Aspose.Slides.Presentation sourcePresentation = new Aspose.Slides.Presentation("SelectedSlides.pptx"))
        {
            // Create an auxiliary presentation
            using (Aspose.Slides.Presentation auxPresentation = new Aspose.Slides.Presentation())
            {
                // Clone the first slide into the auxiliary presentation
                Aspose.Slides.ISlide slide = sourcePresentation.Slides[0];
                auxPresentation.Slides.InsertClone(0, slide);

                // Set slide size
                auxPresentation.SlideSize.SetSize(612F, 792F, Aspose.Slides.SlideSizeScaleType.EnsureFit);

                // Configure PDF options to include notes
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions()
                {
                    NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull
                };

                // Save the auxiliary presentation as PDF with notes
                auxPresentation.Save("PDFnotes_out.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
        }
    }
}