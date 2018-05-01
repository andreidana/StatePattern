namespace StateExample.State
{
    public interface IState
    {
        void Handle(AppContext context);
    }
}