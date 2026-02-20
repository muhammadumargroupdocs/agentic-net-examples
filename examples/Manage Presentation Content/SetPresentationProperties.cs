using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManagePresentationProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the directory containing the presentation files
            string dataDir = @"C:\Data\";
            // Input presentation (can be any supported format)
            string inputPath = dataDir + "input.pptx";
            // Output presentation saved in PPT format
            string outputPath = dataDir + "output.ppt";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Access the document properties
            Aspose.Slides.IDocumentProperties documentProperties = presentation.DocumentProperties;

            // Set built‑in properties
            documentProperties.Author = "John Doe";
            documentProperties.Title = "Sample Presentation Title";
            documentProperties.Subject = "Sample Subject";
            documentProperties.Comments = "Created with Aspose.Slides";

            // Save the presentation in PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

            // Clean up
            presentation.Dispose();
        }
    }
}