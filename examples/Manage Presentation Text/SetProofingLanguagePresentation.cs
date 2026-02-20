using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationLanguageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Set the proofing language for the presentation (e.g., English - United States)
            presentation.DefaultTextStyle.DefaultParagraphFormat.DefaultPortionFormat.LanguageId = "en-US";

            // Save the modified presentation as PPTX
            string outputPath = "ProofingLanguageDemo.pptx";
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}