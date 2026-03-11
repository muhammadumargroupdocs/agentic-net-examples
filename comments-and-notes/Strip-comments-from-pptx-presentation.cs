using System;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the existing PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Iterate through each slide in the presentation
        for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

            // Retrieve all comments on the current slide
            Aspose.Slides.IComment[] comments = slide.GetSlideComments(null);

            // Remove each comment (and its replies) from the slide
            for (int commentIndex = 0; commentIndex < comments.Length; commentIndex++)
            {
                comments[commentIndex].Remove();
            }
        }

        // Save the modified presentation without any comments
        presentation.Save("output.pptx", SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}