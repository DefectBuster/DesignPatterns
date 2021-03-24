using System.Windows.Controls;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Wpf.OrdersDemoAfterEA
{
    /// <summary>
    /// Interaction logic for OrdersListView.xaml
    /// </summary>
    public partial class OrdersListView : UserControl
    {
        public IEventAggregator EventAggregator { get; set; }

        public OrdersListView()
        {
            InitializeComponent();
            OrdersList.SelectionChanged += this.OrdersList_SelectionChanged;
        }

        void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var order = (Order)OrdersList.SelectedItem;
            EventAggregator.Publish(new OrderSelected { Order = order });
        }

        public void SetOrders(ObservableCollection<Order> orders)
        {
            OrdersList.ItemsSource = orders;
            OrdersList.SelectedIndex = 0;
            orders.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(orders_CollectionChanged);
        }

        void orders_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                OrdersList.SelectedItem = e.NewItems[0];
            }
        }
    }
}
