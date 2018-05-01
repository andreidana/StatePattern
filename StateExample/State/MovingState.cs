using System;

namespace StateExample.State
{
    public class MovingState: IState
    {
        public MovingState()
        {
            Console.WriteLine("Created a moving state");
        }

        public void Handle(AppContext context)
        {
            context.State = new StillState();
        }
    }
}