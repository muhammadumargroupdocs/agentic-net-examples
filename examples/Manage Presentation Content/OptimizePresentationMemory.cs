using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for the source and the copy
        System.String sourcePath = "largePresentation.ppt";
        System.String copyPath = "largePresentation_copy.ppt";

        // Load options with BlobManagementOptions to handle large files efficiently
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions
        {
            BlobManagementOptions = new Aspose.Slides.BlobManagementOptions
            {
                PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked,
                IsTemporaryFilesAllowed = true
            }
        };

        // Open the large presentation with the specified load options
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath, loadOptions);

        // Rename the first slide
        presentation.Slides[0].Name = "RenamedSlide";

        // Save the presentation as a copy in PPT format
        presentation.Save(copyPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Delete the original large presentation file
        System.IO.File.Delete(sourcePath);
    }
}