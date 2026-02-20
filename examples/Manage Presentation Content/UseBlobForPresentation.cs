using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "input.pptx");
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.ppt");

        // Configure load options with BLOB management to reduce memory usage
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.BlobManagementOptions = new Aspose.Slides.BlobManagementOptions();
        loadOptions.BlobManagementOptions.IsTemporaryFilesAllowed = true;
        loadOptions.BlobManagementOptions.MaxBlobsBytesInMemory = 10 * 1024 * 1024; // 10 MB limit
        loadOptions.BlobManagementOptions.PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked;

        // Load the presentation using the configured options
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up resources
        presentation.Dispose();
    }
}