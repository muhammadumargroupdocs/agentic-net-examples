using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            string inputPath = "input.pptx";
            string outputPath = "output.pdf";

            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Preserve animations (no modification needed)
                Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
                pdfOptions.ShowHiddenSlides = true; // include hidden slides if any

                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine("Error: " + ex.Message);
        }
    }
}