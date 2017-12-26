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
    /// Interaction logic for MessengerSourceView.xaml
    /// </summary>
    public partial class MessengerSourceView : Window
    {
        public MessengerSourceView()
        {
            InitializeComponent();
            this.DataContext = new MessengerSourceViewModel();
        }
    }
}
