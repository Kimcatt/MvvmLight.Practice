using Practice.MvvmLight.ViewModel.Messenger;
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

namespace Practice.MvvmLight.View.Messenger
{
    /// <summary>
    /// Interaction logic for MessengerWithDispatcherHelperView.xaml
    /// </summary>
    public partial class MessengerWithDispatcherHelperView : Window
    {
        public MessengerWithDispatcherHelperView()
        {
            InitializeComponent();
            this.DataContext = new MessengerWithDispatcherHelperViewModel();
        }
    }
}
