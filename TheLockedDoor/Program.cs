Console.WriteLine("Please Insert the numeric password of your Door");
Door door = new Door(int.Parse(Console.ReadLine()));
while (true)
{
    Console.WriteLine($"Your door is {door.State}\n:Type, Open to open it, Close to Close it, Lock to lock it, and Unlock to unlock it followed with the password?");
    switch (Console.ReadLine())
    {
        case "Open":
            door.Open(); break;
        case "Close":
            door.Close(); break;
        case "Lock":
            door.Lock(); break;
        case "Unlock":
            Console.WriteLine("Please type your numeric password");
            door.Unlock(int.Parse(Console.ReadLine())); break;
    }
}

public class Door
{

    public DoorState State { get; set; }
    private int Password { get; set; }
    public Door( int password)
    {
        State = DoorState.Open;
        Password = password;
    }
    public void Open()
    {
        if (State == DoorState.Closed)
            State = DoorState.Open;
        else
            Console.WriteLine("Wrong state");

    }
    public void Close() 
    {
        if (State == DoorState.Open) State = DoorState.Closed;
        else Console.WriteLine("Wrong State");
    }
    public void Lock()
    {
        if (State == DoorState.Closed) State = DoorState.Locked; else Console.WriteLine("Wrong State");
    }
    public void Unlock(int password) 
    { 
        if(State == DoorState.Locked && password == Password)
        {
            State = DoorState.Closed;
        }
    }
    public void ChangePassword(int oldPassword, int newPassword)
    {
        if(Password== oldPassword) Password = newPassword;
    }
}
public enum DoorState
{
    Open,
    Closed,
    Locked
}

