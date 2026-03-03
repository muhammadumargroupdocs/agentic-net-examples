using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // List of source presentation files (PPT and PPTX)
        string[] sourceFiles = new string[] { "sample.ppt", "sample.pptx" };

        foreach (string sourceFile in sourceFiles)
        {
            // Load the presentation using fully-qualified Aspose.Slides type
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourceFile))
            {
                // Determine output XPS file name
                string outputFile = Path.ChangeExtension(sourceFile, ".xps");

                // Save the presentation to XPS format
                presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Xps);
            }
        }
    }
}