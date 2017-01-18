namespace State
{
    public interface IState
    {
        void Submit(SomeObject someObject);
        bool CanSubmit(SomeObject someObject);
    }
}