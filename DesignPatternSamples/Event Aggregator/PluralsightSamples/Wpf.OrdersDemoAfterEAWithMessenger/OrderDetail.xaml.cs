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
    /// Interaction logic for OrderDetail.xaml
    /// </summary>
    public partial class OrderDetail : UserControl
    {
        public OrderDetail(IMessenger messenger)
        {
            InitializeComponent();
            messenger.Register<OrderSelected>(this, m => OnOrderSelected(m.Order));
            messenger.Register<OrderCreated>(this, m => OnOrderSelected(m.Order));
            messenger.Register<OrderSaved>(this, m => OnOrderSaved(m.Order));
        }

        public void OnOrderSelected(Order o)
        {
            this.Label.Text = string.Format("Order Detail: {0}", o.OrderNumber);
        }

        public void OnOrderSaved(Order o)
        {
            this.Label.Text = string.Format("Order Saved: {0}", o.OrderNumber);
        }
    }
}
