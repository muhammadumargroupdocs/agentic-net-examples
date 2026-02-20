using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Access the tag collection
        Aspose.Slides.ITagCollection tags = pres.CustomData.Tags;

        // Iterate through all tags and display their names and values
        for (int i = 0; i < tags.Count; i++)
        {
            string tagName = tags.GetNameByIndex(i);
            string tagValue = tags.GetValueByIndex(i);
            Console.WriteLine("Tag: {0} = {1}", tagName, tagValue);
        }

        // Save the presentation (no modifications made)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}