//publisher and subscriber events
using System;

// publisher
class AlarmClock
{
    // define a delegate for the event
    public delegate void RingEventHandler();

    // declare the event based on the delegate
    public event RingEventHandler Ring;

    public void SetAlarm()
    {
        Console.WriteLine("Alarm is set...");
    }

    public void OnTimeReached()
    {
        Console.WriteLine("Time reached!");

        // trigger the event
        if (Ring != null)
        {
            Ring();  // raise the event
        }
    }
}

// subscriber
class Person
{
    public void WakeUp()
    {
        Console.WriteLine("Person: Waking up because alarm is ringing!");
    }
}

class Program
{
    static void Main()
    {
        AlarmClock alarm = new AlarmClock();
        Person person = new Person();

        // subscriber subscribes to the publisher event
        alarm.Ring += person.WakeUp;

        alarm.SetAlarm();

        // simulate time reached
        alarm.OnTimeReached();
    }
}
