using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define data directory and file names
        string dataDir = "path_to_data_dir\\";
        string inputFile = "input.pptx";
        string outputFile = "output.pptx";

        // Load presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(dataDir + inputFile);

        // List of slide indices to remove
        List<int> indicesToRemove = new List<int> { 2, 4, 5 };

        // Sort indices in descending order to avoid shifting issues
        indicesToRemove.Sort();
        indicesToRemove.Reverse();

        foreach (int index in indicesToRemove)
        {
            if (index >= 0 && index < presentation.Slides.Count)
            {
                presentation.Slides.RemoveAt(index);
            }
        }

        // Save the modified presentation
        presentation.Save(dataDir + outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}