using System;

class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        currentState = new LockedState();
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.DisplayState();
    }
}

interface State
{
    void DisplayState();
}

class LockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu terkunci");
    }
}

class UnlockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.SetState(new UnlockedState());
        doorMachine.SetState(new LockedState());
    }
}