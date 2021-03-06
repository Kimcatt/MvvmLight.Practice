﻿using System;
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
using GalaSoft.MvvmLight.Messaging;
using Practice.MvvmLight.ViewModel.Messenger;

namespace Practice.MvvmLight.View.Messenger
{
    /// <summary>
    /// Interaction logic for MessengerView.xaml
    /// </summary>
    public partial class MessengerView : Window
    {
        public MessengerView()
        {
            InitializeComponent();

            //消息标志token：ViewAlert，用于标识只阅读某个或者某些Sender发送的消息，并执行相应的处理，所以Sender那边的token要保持一致
            //执行方法Action：ShowReceiveInfo，用来执行接收到消息后的后续工作，注意这边是支持泛型能力的，所以传递参数很方便。
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<String>(this, "ViewAlert", ShowReceiveInfo);
            this.DataContext = new MessengerViewModel();
            //卸载当前(this)对象注册的所有MVVMLight消息
            this.Unloaded += (sender, e) => GalaSoft.MvvmLight.Messaging.Messenger.Default.Unregister(this);
        }

        /// <summary>
        /// 接收到消息后的后续工作：根据返回来的信息弹出消息框
        /// </summary>
        /// <param name="msg"></param>
        private void ShowReceiveInfo(String msg)
        {
            MessageBox.Show(msg);
        }
    }
}
