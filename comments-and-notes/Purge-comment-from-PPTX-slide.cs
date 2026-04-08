using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

            // Access the first slide (adjust index as needed)
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Retrieve all comments on the slide
            Aspose.Slides.IComment[] comments = slide.GetSlideComments(null);

            // Find the comment to remove (example: match by text)
            Aspose.Slides.IComment commentToRemove = null;
            foreach (Aspose.Slides.IComment c in comments)
            {
                if (c.Text == "Comment to delete")
                {
                    commentToRemove = c;
                    break;
                }
            }

            // Remove the comment if it was found
            if (commentToRemove != null)
            {
                commentToRemove.Remove();
            }

            // Save the modified presentation
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}