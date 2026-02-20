using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define the path to the presentation file
        string inputFile = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "sample.pptx");

        // Get information about the presentation without loading the full file
        Aspose.Slides.IPresentationInfo presentationInfo = Aspose.Slides.PresentationFactory.Instance.GetPresentationInfo(inputFile);

        // Retrieve the format in which the presentation was loaded
        Aspose.Slides.LoadFormat loadFormat = presentationInfo.LoadFormat;

        // Output the detected format
        Console.WriteLine("Presentation format: " + loadFormat);
    }
}