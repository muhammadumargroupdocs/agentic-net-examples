using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationBlobManagementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            string inputPath = Path.Combine(Environment.CurrentDirectory, "input.pptx");
            string outputPath = Path.Combine(Environment.CurrentDirectory, "output.ppt");

            // Configure load options with BLOB management settings
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.BlobManagementOptions = new BlobManagementOptions();
            loadOptions.BlobManagementOptions.IsTemporaryFilesAllowed = true; // Use temporary files to reduce memory usage
            loadOptions.BlobManagementOptions.MaxBlobsBytesInMemory = 10 * 1024 * 1024; // 10 MB limit
            loadOptions.BlobManagementOptions.PresentationLockingBehavior = PresentationLockingBehavior.KeepLocked; // Keep source locked for the lifetime

            // Load the presentation using the configured options
            Presentation pres = new Presentation(inputPath, loadOptions);

            // (Optional) Perform any modifications here, e.g., add a blank slide
            // ISlideCollection slideColl = pres.Slides;
            // slideColl.AddEmptySlide(pres.LayoutSlides[0]);

            // Save the presentation in PPT format
            pres.Save(outputPath, SaveFormat.Ppt);

            // Dispose the presentation to release resources
            pres.Dispose();
        }
    }
}