using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output presentation paths
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "input.pptx");
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.pptx");

        // Create load options and configure external resource handling
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.BlobManagementOptions.PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked;
        loadOptions.BlobManagementOptions.IsTemporaryFilesAllowed = true;

        // Load the presentation with the specified options
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Retrieve presentation info to demonstrate protection checks (optional)
        Aspose.Slides.IPresentationInfo presInfo = Aspose.Slides.PresentationFactory.Instance.GetPresentationInfo(inputPath);
        bool isWriteProtected = presInfo.IsWriteProtected == Aspose.Slides.NullableBool.True;
        if (isWriteProtected)
        {
            // Example: verify write protection password
            bool canModify = presInfo.CheckWriteProtection("writePassword");
        }

        // Save the presentation before exiting
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}