﻿


namespace OpenAI.Assistants;

public class TextAnnotation
{
    private readonly MessageContentTextAnnotationsFileCitationObject _fileSearchCitation;
    private readonly MessageContentTextAnnotationsFilePathObject _codeCitation;

    /// <summary>
    /// The specific quote cited from the file identified by <see cref="InputFileId"/>, as generated by the
    /// <c>file_search</c> tool.
    /// </summary>
    public string InputQuote => _fileSearchCitation?.FileCitation?.Quote;

    /// <summary>
    /// The ID of the file cited by the <c>file_search</c> tool for this annotation.
    /// </summary>
    public string InputFileId => _fileSearchCitation?.FileCitation?.FileId;

    /// <summary>
    /// The ID of the file that was generated by the <c>code_interpreter</c> tool for this citation.
    /// </summary>
    public string OutputFileId => _codeCitation?.FilePath?.FileId;

    /// <summary>
    /// The index in the message content at which the citation begins.
    /// </summary>
    public int StartIndex => _fileSearchCitation?.StartIndex ?? _codeCitation?.StartIndex ?? -1;

    /// <summary>
    /// The index in the message content at which the citation ends.
    /// </summary>
    public int EndIndex => _fileSearchCitation?.EndIndex ?? _codeCitation?.EndIndex ?? -1;

    /// <summary>
    /// The text in the message content that should be replaced.
    /// </summary>
    public string TextToReplace => _fileSearchCitation?.Text ?? _codeCitation?.Text;

    internal TextAnnotation(MessageContentTextObjectAnnotation internalAnnotation)
    {
        _fileSearchCitation = internalAnnotation as MessageContentTextAnnotationsFileCitationObject;
        _codeCitation = internalAnnotation as MessageContentTextAnnotationsFilePathObject; ;
    }
}