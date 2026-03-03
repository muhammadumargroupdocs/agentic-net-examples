using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input files (PPT and PPTX)
        string[] inputFiles = new string[] { "sample.ppt", "sample.pptx" };

        foreach (string inputFile in inputFiles)
        {
            // Load the source presentation
            using (Aspose.Slides.Presentation sourcePresentation = new Aspose.Slides.Presentation(inputFile))
            {
                // Create an auxiliary presentation to hold the slide with notes
                using (Aspose.Slides.Presentation auxPresentation = new Aspose.Slides.Presentation())
                {
                    // Clone the first slide from the source
                    Aspose.Slides.ISlide sourceSlide = sourcePresentation.Slides[0];
                    auxPresentation.Slides.InsertClone(0, sourceSlide);

                    // Set slide size (optional, matches example)
                    auxPresentation.SlideSize.SetSize(612F, 792F, Aspose.Slides.SlideSizeScaleType.EnsureFit);

                    // Configure PDF options to include notes
                    Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                    pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions()
                    {
                        NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull
                    };

                    // Determine output PDF file name
                    string outputFile = Path.ChangeExtension(inputFile, ".pdf");

                    // Save the auxiliary presentation as PDF with notes
                    auxPresentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
                }
            }
        }
    }
}