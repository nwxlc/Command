namespace Command.Door;

public class OpenDoorCommand : ICommand
{
    private readonly Door _door;

    public OpenDoorCommand(Door door)
    {
        ArgumentNullException.ThrowIfNull(door);
        _door = door;
    }

    public void Execute()
    {
        _door.Close();
    }
}