using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Wpf.OrdersDemoAfterEA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEventAggregator _ea;

        private ObservableCollection<Order> _orders;

        public MainWindow()
        {
            InitializeComponent();
            _ea = new SimpleEventAggregator();
            this.OrderListView.EventAggregator = this._ea;

            AddOrderViews();
            LoadOrders();

            this.New.Click += this.New_Click;
            this.Save.Click += this.Save_Click;
        }

        private void AddOrderViews()
        {
            var tabs = this.OrderViews.Items;
            tabs.Add(new TabItem() { Header = "Header", Content = new OrderView(this._ea) });
            tabs.Add(new TabItem() { Header = "Detail", Content = new OrderDetail(this._ea) });
            tabs.Add(new TabItem() { Header = "Order History", Content = new OrderHistoryView(this._ea) });
        }

        private void LoadOrders()
        {
            _orders = new ObservableCollection<Order>();
            _orders.Add(new Order { OrderNumber = "1000", Description = "An Order" });
            _orders.Add(new Order { OrderNumber = "2000", Description = "Another Order" });
            _orders.Add(new Order { OrderNumber = "3000", Description = "Yet Another Order" });
            OrderListView.SetOrders(_orders);
        }

        void New_Click(object sender, RoutedEventArgs e)
        {
            var order = new Order { Description = "New Order", OrderNumber = "New " + Order.NewID };
            _orders.Add(order);
            _ea.Publish(new OrderSelected { Order = order });
        }

        void Save_Click(object sender, RoutedEventArgs e)
        {
            var order = (Order)this.OrderListView.OrdersList.SelectedItem;
            _ea.Publish(new OrderSaved { Order = order });
        }
    }
}
