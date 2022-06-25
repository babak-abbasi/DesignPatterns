namespace DesignPatterns.BehavioralPatterns;

public class HighlightText : ICommand
{
    private Editor _editor;
    private string _highlightText;

    public HighlightText(Editor editor, string highlightText)
    {
        _editor = editor;
        _highlightText = highlightText;
    }

    public bool Execute()
    {
        if(!string.IsNullOrEmpty(_highlightText))
        {
            _editor.HighlightedText = _highlightText;
            _editor.CommandHistory.Push(this);

            return true;
        }
        
        return false;
    }
}