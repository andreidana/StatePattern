using System;

namespace StateExample.State
{
    public class StillState: IState
    {
        public StillState()
        {
            Console.WriteLine("Created a still state");
        }

        public void Handle(AppContext context)
        {
            context.State = new MovingState();
        }
    }
}