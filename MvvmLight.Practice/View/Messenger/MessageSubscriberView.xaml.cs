using MvvmLight.Practice.ViewModel.Messenger;
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
using System.Windows.Shapes;

namespace MvvmLight.Practice.View.Messenger
{
    /// <summary>
    /// Interaction logic for MessageSubscriberView.xaml
    /// </summary>
    public partial class MessageSubscriberView : Window
    {
        public MessageSubscriberView()
        {
            InitializeComponent();
            this.DataContext = new MessageSubscriberViewModel();
        }
    }
}
