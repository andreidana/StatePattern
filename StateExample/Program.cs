using StateExample.State;

namespace StateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appContext = new AppContext(new StillState());

            appContext.Request();
            appContext.Request();
            appContext.Request();
            appContext.Request();
        }
    }
}
