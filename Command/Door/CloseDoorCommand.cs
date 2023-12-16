namespace Command.Door;

public class CloseDoorCommand : ICommand
{
    private readonly Door _door;

    public CloseDoorCommand(Door door)
    {
        ArgumentNullException.ThrowIfNull(door);
        _door = door;
    }

    public void Execute()
    {
        _door.Close();
    }
}