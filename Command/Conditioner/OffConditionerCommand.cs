namespace Command.Conditioner;

public class OffConditionerCommand : ICommand
{
    private readonly Conditioner _conditioner;

    public OffConditionerCommand(Conditioner conditioner)
    {
        ArgumentNullException.ThrowIfNull(conditioner);
        _conditioner = conditioner;
    }

    public void Execute()
    {
        _conditioner.Off();
    }
}