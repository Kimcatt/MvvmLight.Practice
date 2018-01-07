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
    /// Interaction logic for MessengerSinkView.xaml
    /// </summary>
    public partial class MessengerSinkView : Window
    {
        public MessengerSinkView()
        {
            InitializeComponent();
            this.DataContext = new MessengerSinkViewModel();
        }
    }
}
