using System;
using Aspose.Slides;

namespace PresentationPropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the directory and presentation file path
            string dataDir = @"./";
            string filePath = dataDir + "presentation.pptx";

            // Load options (if needed, e.g., password)
            Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
            loadOptions.Password = null;
            loadOptions.OnlyLoadDocumentProperties = false;

            // Open the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(filePath, loadOptions);

            // Access document properties
            Aspose.Slides.IDocumentProperties docProps = presentation.DocumentProperties;

            // Example: read some standard properties
            Console.WriteLine("Author: " + docProps.Author);
            Console.WriteLine("Title: " + docProps.Title);
            Console.WriteLine("Subject: " + docProps.Subject);
            Console.WriteLine("Created Time (UTC): " + docProps.CreatedTime.ToUniversalTime());

            // Save the presentation before exiting
            presentation.Save(filePath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}