using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace Wpf.OrdersDemoBeforeEA
{
    /// <summary>
    /// Interaction logic for OrdersListView.xaml
    /// </summary>
    public partial class OrdersListView : UserControl
    {
        public event EventHandler<OrderEventArgs> OrderSelected;

        public OrdersListView()
        {
            InitializeComponent();
            OrdersList.SelectionChanged += new SelectionChangedEventHandler(OrdersList_SelectionChanged);
        }

        public void SetOrders(ObservableCollection<Order> orders)
        {
            OrdersList.ItemsSource = orders;
            OrdersList.SelectedIndex = 0;
            orders.CollectionChanged += new NotifyCollectionChangedEventHandler(orders_CollectionChanged);
        }

        void orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                OrdersList.SelectedItem = e.NewItems[0];
            }
        }


        void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var handler = OrderSelected;
            if (handler == null)
                return;

            var order = (Order)OrdersList.SelectedItem;
            OrderSelected(this, new OrderEventArgs { Order = order });
        }

    }
}
