namespace Command.Light;

public class OffLight : ICommand
{
    private Light _light;

    public OffLight(Light light)
    {
        ArgumentNullException.ThrowIfNull(light);
        _light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
}