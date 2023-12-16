using Command;
using Command.Conditioner;
using Command.Door;
using Command.Light;

Remote remote = new Remote();
Light light = new Light();
Conditioner conditioner = new Conditioner();
Door door = new Door();

remote.AddCommand(0, new OpenDoorCommand(door), new CloseDoorCommand(door));
remote.Execute(0);

remote.AddCommand(1, new OnLight(light), new OffLight(light));
remote.Execute(1);

remote.Undo();
remote.Undo();