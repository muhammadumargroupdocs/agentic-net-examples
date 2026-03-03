using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the source presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Create a new presentation to hold the slide with notes
            using (Aspose.Slides.Presentation auxPresentation = new Aspose.Slides.Presentation())
            {
                // Clone the first slide from the source
                Aspose.Slides.ISlide sourceSlide = presentation.Slides[0];
                auxPresentation.Slides.InsertClone(0, sourceSlide);
                // Set slide size (optional)
                auxPresentation.SlideSize.SetSize(612F, 792F, Aspose.Slides.SlideSizeScaleType.EnsureFit);
                // Configure PDF options to include speaker notes
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions()
                {
                    NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull
                };
                // Save the auxiliary presentation as PDF with notes
                auxPresentation.Save("output_with_notes.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
            // Save the original presentation before exit (optional)
            presentation.Save("input_saved.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}