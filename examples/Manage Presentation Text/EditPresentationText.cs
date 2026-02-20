using System;
using System.Collections.Generic;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create a callback to capture replace results
        FindResultCallback callback = new FindResultCallback();

        // Replace text in the presentation
        presentation.ReplaceText("old text", "new text", new Aspose.Slides.TextSearchOptions(), callback);

        // Save the presentation after replacement
        foreach (WordInfo info in callback.Words)
        {
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }

        // Dispose the presentation
        presentation.Dispose();
    }
}

// Callback class to collect replace results
public class FindResultCallback : Aspose.Slides.IFindResultCallback
{
    public readonly System.Collections.Generic.List<WordInfo> Words = new System.Collections.Generic.List<WordInfo>();

    public System.Int32 Count
    {
        get { return Words.Count; }
    }

    public void FoundResult(Aspose.Slides.ITextFrame textFrame, System.String oldText, System.String foundText, System.Int32 textPosition)
    {
        Words.Add(new WordInfo(textFrame, oldText, foundText, textPosition));
    }
}

// Class representing information about a found word
public class WordInfo
{
    public Aspose.Slides.ITextFrame TextFrame { get; }
    public System.String SourceText { get; }
    public System.String FoundText { get; }
    public System.Int32 TextPosition { get; }

    internal WordInfo(Aspose.Slides.ITextFrame textFrame, System.String sourceText, System.String foundText, System.Int32 textPosition)
    {
        TextFrame = textFrame;
        SourceText = sourceText;
        FoundText = foundText;
        TextPosition = textPosition;
    }
}