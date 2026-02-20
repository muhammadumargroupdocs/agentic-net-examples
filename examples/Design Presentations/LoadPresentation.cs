using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        System.String filePath = "input.pptx";

        // Load options (no password, load full presentation)
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.Password = null;
        loadOptions.OnlyLoadDocumentProperties = false;

        // Load the presentation with the specified options
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(filePath, loadOptions);

        // Access document properties and modify the title
        Aspose.Slides.IDocumentProperties docProps = presentation.DocumentProperties;
        docProps.Title = "Updated Presentation Title";

        // Save the modified presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}