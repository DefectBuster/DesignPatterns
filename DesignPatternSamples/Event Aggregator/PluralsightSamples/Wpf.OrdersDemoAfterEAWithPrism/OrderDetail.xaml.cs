using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Composite.Events;

namespace Wpf.OrdersDemoAfterEAWithPrism
{
    /// <summary>
    /// Interaction logic for OrderDetail.xaml
    /// </summary>
    public partial class OrderDetail : UserControl
    {
        //private SubscriptionToken _token;

        public OrderDetail(IEventAggregator ea)
        {
            InitializeComponent();
            ea.GetEvent<OrderSelected>().Subscribe(OnOrderSelected);
            ea.GetEvent<OrderCreated>().Subscribe(OnOrderSelected);
            ea.GetEvent<OrderSaved>().Subscribe(OnOrderSaved);
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
