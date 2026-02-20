using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the large source presentation (PPT format)
        System.String sourcePath = "largePresentation.ppt";
        // Path where the copy will be saved
        System.String copyPath = "largePresentation_copy.ppt";

        // Configure load options with BlobManagementOptions to keep the source locked
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions
        {
            BlobManagementOptions = new Aspose.Slides.BlobManagementOptions
            {
                PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked
            }
        };

        // Load the large presentation using the specified options
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath, loadOptions);

        // Rename the first slide (optional demonstration)
        presentation.Slides[0].Name = "RenamedSlide";

        // Save the presentation copy in PPT format
        presentation.Save(copyPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Delete the original large file
        System.IO.File.Delete(sourcePath);
    }
}