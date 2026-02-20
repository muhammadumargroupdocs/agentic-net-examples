using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output file path
            string outputPath = "CustomPropertiesPresentation.pptx";

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Access document properties
            Aspose.Slides.IDocumentProperties documentProperties = presentation.DocumentProperties;

            // Add custom properties
            documentProperties["CustomInt"] = 123;
            documentProperties["CustomString"] = "Hello World";
            documentProperties["AnotherInt"] = 456;

            // Retrieve the name of the first custom property and remove it
            string firstPropertyName = documentProperties.GetCustomPropertyName(0);
            documentProperties.RemoveCustomProperty(firstPropertyName);

            // Save the presentation (PPTX format)
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Optional: inform the user
            Console.WriteLine("Presentation saved to " + outputPath);
        }
    }
}