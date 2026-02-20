using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace LargePresentationExport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the original large presentation
            System.String sourcePath = "large.pptx";
            // Path for the exported PPT file
            System.String exportPath = "large_exported.ppt";

            // Configure load options with BLOB management to keep the source locked
            Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions
            {
                BlobManagementOptions = new Aspose.Slides.BlobManagementOptions
                {
                    PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked
                }
            };

            // Load the presentation using the specified load options
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath, loadOptions);

            // Optionally rename the first slide
            presentation.Slides[0].Name = "RenamedSlide";

            // Save the presentation in PPT format
            presentation.Save(exportPath, Aspose.Slides.Export.SaveFormat.Ppt);

            // Clean up: delete the original large file if no longer needed
            System.IO.File.Delete(sourcePath);
        }
    }
}