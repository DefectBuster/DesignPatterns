namespace Wpf.OrdersDemoBeforeEA
{
    public interface IOrderView
    {
        void OnOrderSelected(Order order);
        void OnOrderSaved(Order order);
    }
}
