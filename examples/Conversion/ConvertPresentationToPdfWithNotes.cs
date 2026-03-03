using System;

class Program
{
    static void Main(string[] args)
    {
        // Load the source presentation
        using (Aspose.Slides.Presentation sourcePresentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Create an auxiliary presentation to hold the slide with notes
            using (Aspose.Slides.Presentation auxPresentation = new Aspose.Slides.Presentation())
            {
                // Clone the first slide from the source presentation
                Aspose.Slides.ISlide slide = sourcePresentation.Slides[0];
                auxPresentation.Slides.InsertClone(0, slide);

                // Set the slide size for the auxiliary presentation
                auxPresentation.SlideSize.SetSize(612f, 792f, Aspose.Slides.SlideSizeScaleType.EnsureFit);

                // Configure PDF options to include notes at the bottom
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions()
                {
                    NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull
                };

                // Save the auxiliary presentation as a PDF with notes
                auxPresentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
        }
    }
}