namespace Wpf.OrdersDemoAfterEA
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}
