using System.Collections.Generic;

namespace DesignPatterns.BehavioralPatterns;

public class CommandHistory
{
    private IList<ICommand> commands = new List<ICommand>(); 

    public ICommand Pop()
    {
        var returnCommand = commands[commands.Count - 1];
        if(commands.Count > 0)
        {
            commands.RemoveAt(commands.Count - 1);
            return returnCommand;
        }
        
        return null;
    }

    public bool Push(ICommand command)
    {
        commands.Add(command);

        return true;
    }
}