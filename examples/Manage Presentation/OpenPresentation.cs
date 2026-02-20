using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the password‑protected presentation
        string inputPath = "protected.pptx";
        // Path where the presentation will be saved after opening
        string outputPath = "unprotected.pptx";

        // Create load options and set the password required to open the file
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.Password = "myPassword";

        // Open the presentation using the load options with the password
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Save the presentation (without password) before exiting
        presentation.Save(outputPath, SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}