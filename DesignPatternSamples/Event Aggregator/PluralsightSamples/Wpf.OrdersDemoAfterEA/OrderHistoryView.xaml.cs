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

namespace Wpf.OrdersDemoAfterEA
{
    /// <summary>
    /// Interaction logic for OrderHistoryView.xaml
    /// </summary>
    public partial class OrderHistoryView : UserControl, ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
    {
        public OrderHistoryView(IEventAggregator ea)
        {
            InitializeComponent();
            ea.Subscribe(this);
        }

        public void OnEvent(OrderSelected e)
        {
            this.Label.Text = string.Format("Order History: {0}", e.Order.OrderNumber);
        }

        public void OnEvent(OrderSaved e)
        {
            this.Label.Text = string.Format("Order Saved: {0}", e.Order.OrderNumber);
        }
    }
}
