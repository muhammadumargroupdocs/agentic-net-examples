using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Convert3DEffectsToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string inputPath = "input.pptx";
                string outputPath = "output.pdf";

                using (Presentation pres = new Presentation(inputPath))
                {
                    // Configure PDF options to preserve visual fidelity
                    PdfOptions pdfOptions = new PdfOptions();
                    // Keep metafiles as vector graphics for better 3D effect rendering
                    pdfOptions.SaveMetafilesAsPng = false;

                    pres.Save(outputPath, SaveFormat.Pdf, pdfOptions);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}