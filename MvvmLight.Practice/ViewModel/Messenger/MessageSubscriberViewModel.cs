using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmLight.Practice.View.Messenger;

namespace MvvmLight.Practice.ViewModel.Messenger
{
    public class MessageSubscriberViewModel : ViewModelBase
    {
        public MessageSubscriberViewModel()
        {
            ///Messenger：信使
            ///Recipient：收件人
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<String>(this, "Message", ShowReceivedInfo);
        }


        #region 属性

        private String receivedInfo;
        /// <summary>
        /// 接收到信使传递过来的值
        /// </summary>
        public String ReceivedInfo
        {
            get { return receivedInfo; }
            set { receivedInfo = value; RaisePropertyChanged(() => ReceivedInfo); }
        }

        #endregion


        #region 启动新窗口

        private RelayCommand showPublisherWindowCommand;

        public RelayCommand ShowPublisherWindowCommand
        {
            get
            {
                if (showPublisherWindowCommand == null)
                    showPublisherWindowCommand = new RelayCommand(() => ExcuteShowPublisherWindow());
                return showPublisherWindowCommand;

            }
            set { showPublisherWindowCommand = value; }
        }

        private void ExcuteShowPublisherWindow()
        {
            MessagePublisherView sender = new MessagePublisherView();
            sender.Show();
        }

        #endregion


        #region 辅助函数
        /// <summary>
        /// 显示收件的信息
        /// </summary>
        /// <param name="msg"></param>
        private void ShowReceivedInfo(String msg)
        {
            ReceivedInfo += msg + "\n";
        }
        #endregion
    }
}
