using System;
using Aspose.Slides;
using System.IO;

class Program
{
    static void Main()
    {
        // Source and destination file paths
        System.String sourcePath = "source.pptx";
        System.String copyPath = "copy.pptx";

        // Load options with BLOB management to keep the source locked
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions
        {
            BlobManagementOptions = new Aspose.Slides.BlobManagementOptions
            {
                PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked
            }
        };

        // Open the large presentation using the specified load options
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath, loadOptions))
        {
            // Rename the first slide
            pres.Slides[0].Name = "RenamedSlide";

            // Save a copy of the presentation
            pres.Save(copyPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }

        // Delete the original source file after processing
        System.IO.File.Delete(sourcePath);
    }
}