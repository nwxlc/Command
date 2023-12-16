namespace Command.Conditioner;

public class OnConditionerCommand : ICommand
{
    private readonly Conditioner _conditioner;

    public OnConditionerCommand(Conditioner conditioner)
    {
        ArgumentNullException.ThrowIfNull(conditioner);
        _conditioner = conditioner;
    }

    public void Execute()
    {
        _conditioner.On();
    }
}