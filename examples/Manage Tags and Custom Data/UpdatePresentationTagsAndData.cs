using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        var pres = new Aspose.Slides.Presentation();

        // Access the tag collection
        var tags = pres.CustomData.Tags;

        // Add tags to the presentation
        tags["Author"] = "John Doe";
        tags.Add("Project", "AsposeDemo");

        // Display tag values
        Console.WriteLine("Author tag: " + tags["Author"]);
        Console.WriteLine("Project tag: " + tags["Project"]);

        // Save the presentation
        pres.Save("ManagedTags.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}