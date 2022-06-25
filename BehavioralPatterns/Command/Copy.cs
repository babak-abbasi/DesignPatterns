namespace DesignPatterns.BehavioralPatterns;

public class Copy : ICommand
{
    private readonly Editor _editor;

    public Copy(Editor editor)
    {
        _editor = editor;
    }

    public bool Execute()
    {
        if(!string.IsNullOrEmpty(_editor.HighlightedText))
        {
            _editor.ClipBoard = _editor.HighlightedText;
            _editor.CommandHistory.Push(this);

            return true;
        }

        return false;
    }
}