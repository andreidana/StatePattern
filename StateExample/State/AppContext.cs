using System;

namespace StateExample.State
{
    public class AppContext
    {
        private IState _state;

        public AppContext(IState state)
        {
            this.State = state;
        }

        public IState State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}