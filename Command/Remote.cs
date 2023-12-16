namespace Command;

public class Remote
{
    private Dictionary<int, (ICommand button, ICommand undo)> _buttons = new();

    private Stack<ICommand> _commandsHistory = new();

    /*public MultiPult()
    {
        buttons = new ICommand[2];
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = new NoCommand();
        }
        commandsHistory = new Stack<ICommand>();
    }
 
    public void SetCommand(int number, ICommand com)
    {
        buttons[number] = com;
    }*/
    
    public void AddCommand(int number, ICommand button, ICommand undo)
    {
        
        _buttons.Add(number, (button, undo));
    }
    
    public void Execute(int number)
    {
        if (_buttons.ContainsKey(number))
        {
            _buttons[number].button.Execute();
            _commandsHistory.Push(_buttons[number].undo);
        }
        else
        {
            throw new ArgumentException("Кнопка не найдена", nameof(number));
        }
    }
    
    public void Undo()
    {
        if(_commandsHistory.Count>0)
        {
            ICommand undoCommand = _commandsHistory.Pop();
            undoCommand.Execute();
        }
    }
}