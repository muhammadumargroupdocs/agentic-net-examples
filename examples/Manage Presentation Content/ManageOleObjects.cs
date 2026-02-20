using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input and output file paths
        var inputPath = "input.ppt";
        var outputPath = "output.ppt";

        // Load options to delete embedded OLE objects
        var loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.DeleteEmbeddedBinaryObjects = true;

        // Load the presentation with the specified options
        var presentation = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Save the modified presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}