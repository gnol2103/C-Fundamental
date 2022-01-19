using C__fundamental_3.Business;
using C__fundamental_3.Events;

namespace C__fundamental_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock displayClock = new DisplayClock();
            displayClock.Subscribe(clock);
            LogClockToFile logClockToFile = new LogClockToFile();
            logClockToFile.Subscribe(clock);
            clock.Run();
        }
    }
}
