using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";
        int targetSlideIndex = 0; // zero‑based index of the slide
        string targetCommentText = "Comment to remove";

        try
        {
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                if (targetSlideIndex < 0 || targetSlideIndex >= presentation.Slides.Count)
                {
                    Console.WriteLine("Invalid slide index.");
                }
                else
                {
                    Aspose.Slides.ISlide targetSlide = presentation.Slides[targetSlideIndex];
                    bool commentRemoved = false;

                    foreach (Aspose.Slides.ICommentAuthor author in presentation.CommentAuthors)
                    {
                        foreach (Aspose.Slides.IComment comment in author.Comments)
                        {
                            if (comment.Slide == targetSlide && comment.Text == targetCommentText)
                            {
                                comment.Remove();
                                commentRemoved = true;
                                break;
                            }
                        }
                        if (commentRemoved)
                        {
                            break;
                        }
                    }

                    if (commentRemoved)
                    {
                        Console.WriteLine("Specified comment removed.");
                    }
                    else
                    {
                        Console.WriteLine("Comment not found on the specified slide.");
                    }
                }

                // Save the presentation before exiting
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}