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
using GalaSoft.MvvmLight.Messaging;

namespace Wpf.OrdersDemoAfterEAWithMessenger
{
    /// <summary>
    /// Interaction logic for OrdersListView.xaml
    /// </summary>
    public partial class OrdersListView : UserControl
    {
        public IMessenger Messenger { get; set; }

        public OrdersListView()
        {
            InitializeComponent();
            OrdersList.SelectionChanged += new SelectionChangedEventHandler(OrdersList_SelectionChanged);
        }

        void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var order = (Order)OrdersList.SelectedItem;
            Messenger.Send(new OrderSelected { Order = order });
        }
    }
}
