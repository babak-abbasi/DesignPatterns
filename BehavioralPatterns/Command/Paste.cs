using System;

namespace DesignPatterns.BehavioralPatterns;

public class Paste : ICommand
{
    private Editor _editor;

    public Paste(Editor editor)
    {
        _editor = editor;
    }

    public bool Execute()
    {
        if(!string.IsNullOrEmpty(_editor.ClipBoard))
        {
            //Does the paste work
            Console.WriteLine("Alice in wonderland");
            _editor.CommandHistory.Pop();
            
            return true;
        }

        return false;
    }
}