namespace DesignPatterns.BehavioralPatterns;

public class Editor
{
    public string ClipBoard { get; set; }
    public string HighlightedText { get; set; }
    public CommandHistory CommandHistory = new CommandHistory();

    public Editor()
    {

    }
}