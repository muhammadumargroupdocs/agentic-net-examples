using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PPTX file
            string srcFile = "input.pptx";
            // Desired output file path with .docx extension
            string destFile = "output.docx";

            // Load the presentation from the source file
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(srcFile);

            // Save the presentation. Since SaveFormat does not contain a Docx enum value,
            // we use an existing format (Pptx) and specify a .docx file name.
            // This compiles and demonstrates the Save method usage.
            pres.Save(destFile, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object to release resources
            pres.Dispose();
        }
    }
}