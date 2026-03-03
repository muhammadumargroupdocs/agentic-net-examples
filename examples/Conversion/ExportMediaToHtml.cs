using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExportMediaToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string sourcePath = "input.pptx";

            // Path for the generated HTML file
            string htmlPath = "output.html";

            // Folder where external media (images, audio, video) will be saved
            string mediaFolder = "output_media";

            // Ensure the media folder exists
            if (!Directory.Exists(mediaFolder))
            {
                Directory.CreateDirectory(mediaFolder);
            }

            // Load the presentation
            using (Presentation presentation = new Presentation(sourcePath))
            {
                // Configure HTML5 export options
                Html5Options options = new Html5Options();
                options.OutputPath = mediaFolder; // Export media files to this folder

                // Save the presentation as HTML5, which extracts media files
                presentation.Save(htmlPath, SaveFormat.Html5, options);
            }

            // Indicate completion
            Console.WriteLine("Presentation exported to HTML with media files.");
        }
    }
}