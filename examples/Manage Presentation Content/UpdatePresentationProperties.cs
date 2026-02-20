using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access document properties
        Aspose.Slides.IDocumentProperties documentProperties = presentation.DocumentProperties;

        // Add custom properties
        documentProperties["CustomInt"] = 123;
        documentProperties["CustomString"] = "Hello";
        documentProperties["AnotherInt"] = 456;

        // Modify custom properties: iterate and update values
        for (int i = 0; i < documentProperties.CountOfCustomProperties; i++)
        {
            string propName = documentProperties.GetCustomPropertyName(i);
            object propValue = documentProperties[propName];
            // Example modification: increment integers, append text to strings
            if (propValue is int)
            {
                documentProperties[propName] = ((int)propValue) + (i + 1);
            }
            else if (propValue is string)
            {
                documentProperties[propName] = ((string)propValue) + "_Modified_" + (i + 1);
            }
        }

        // Remove a custom property by name
        string propertyToRemove = documentProperties.GetCustomPropertyName(0);
        documentProperties.RemoveCustomProperty(propertyToRemove);

        // Save the presentation in PPTX format
        string outputPath = "ModifiedPresentation.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}