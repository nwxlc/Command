namespace Command;

public class MultiCommand : ICommand
{
    private List<ICommand> _commands = new List<ICommand>();

    public MultiCommand(List<ICommand> commands) 
    {
        _commands.AddRange(commands);
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}