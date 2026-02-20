using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace LargePresentationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the original large PPT presentation
            string sourcePath = "largePresentation.ppt";

            // Path where the copy will be saved
            string copyPath = "largePresentation_copy.pptx";

            // Configure load options to keep the source locked for the lifetime of the presentation
            Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions
            {
                BlobManagementOptions = new Aspose.Slides.BlobManagementOptions
                {
                    PresentationLockingBehavior = Aspose.Slides.PresentationLockingBehavior.KeepLocked
                }
            };

            // Load the large presentation with the specified options
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath, loadOptions);

            // Rename the first slide (example of modifying content)
            presentation.Slides[0].Name = "RenamedSlide";

            // Save the presentation copy in PPTX format
            presentation.Save(copyPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation to release the lock on the source file
            presentation.Dispose();

            // Delete the original source file
            File.Delete(sourcePath);
        }
    }
}