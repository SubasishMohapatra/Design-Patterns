namespace Adapter
{
    internal interface IAdapter
    {
        void Push(string item);
        string Pop();
    }
}