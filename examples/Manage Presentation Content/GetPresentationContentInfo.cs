using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define directories and file names
        string dataDir = "Data";
        string inputFile = System.IO.Path.Combine(dataDir, "input.ppt");
        string outputFile = System.IO.Path.Combine(dataDir, "output.ppt");

        // Get presentation information
        Aspose.Slides.IPresentationInfo presentationInfo = Aspose.Slides.PresentationFactory.Instance.GetPresentationInfo(inputFile);
        Aspose.Slides.LoadFormat loadFormat = presentationInfo.LoadFormat;

        // Verify that the file is a PPT format
        bool isPpt = loadFormat == Aspose.Slides.LoadFormat.Ppt;

        if (isPpt)
        {
            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

            // Update document properties
            presentation.DocumentProperties.Title = "Managed Presentation Title";
            presentation.DocumentProperties.Author = "John Doe";
            presentation.DocumentProperties.Subject = "Demo of content info management";

            // Save the presentation in PPT format
            presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Ppt);
            presentation.Dispose();
        }
        else
        {
            Console.WriteLine("The provided file is not a PPT presentation.");
        }
    }
}