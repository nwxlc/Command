namespace Command.Light;

public class OnLight : ICommand
{
    private Light _light;

    public OnLight(Light light)
    {
        ArgumentNullException.ThrowIfNull(light);
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }
}