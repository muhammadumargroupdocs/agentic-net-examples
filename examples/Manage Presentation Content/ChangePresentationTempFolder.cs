using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ManagePresentationTempFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation path
            string inputPath = "input.pptx";

            // Output directory and file
            string outputDir = "output";
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);
            string outputPath = Path.Combine(outputDir, "result.ppt");

            // Set temporary files folder for BLOB handling
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.BlobManagementOptions.TempFilesRootPath = Path.Combine(outputDir, "temp");
            if (!Directory.Exists(loadOptions.BlobManagementOptions.TempFilesRootPath))
                Directory.CreateDirectory(loadOptions.BlobManagementOptions.TempFilesRootPath);

            // Load presentation with the specified load options
            Presentation pres = new Presentation(inputPath, loadOptions);

            // Configure PPT save options, including a valid GUID for RootDirectoryClsid
            PptOptions pptOptions = new PptOptions();
            pptOptions.RootDirectoryClsid = new Guid("64818D11-4F9B-11CF-86EA-00AA00B929E8");

            // Save the presentation in PPT format with the custom options
            pres.Save(outputPath, SaveFormat.Ppt, pptOptions);

            // Dispose the presentation
            pres.Dispose();
        }
    }
}