using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Configure PDF options to control ink visibility
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        pdfOptions.InkOptions.HideInk = true; // Hide ink in the exported PDF
        pdfOptions.InkOptions.InterpretMaskOpAsOpacity = false; // Use ROP operation for brush rendering

        // Save the presentation as PDF with hidden ink
        presentation.Save("output_hidden.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Change ink options to make ink visible
        pdfOptions.InkOptions.HideInk = false; // Show ink in the exported PDF
        pdfOptions.InkOptions.InterpretMaskOpAsOpacity = true; // Use opacity for brush rendering

        // Save the presentation as PDF with visible ink
        presentation.Save("output_visible.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Finally, save the presentation in PPT format (ink options are not applicable for PPT)
        presentation.Save("output.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}