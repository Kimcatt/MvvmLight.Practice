using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Practice.MvvmLight.View.Messenger;

namespace Practice.MvvmLight.ViewModel.Messenger
{
    public class MessengerViewModel : ViewModelBase
    {

        public MessengerViewModel()
        {

        }

        #region 命令

        private RelayCommand sendCommand;
        /// <summary>
        /// 发送命令
        /// </summary>
        public RelayCommand SendCommand
        {
            get
            {
                if (sendCommand == null)
                    sendCommand = new RelayCommand(() => ExcuteSendCommand());
                return sendCommand;

            }
            set { sendCommand = value; }
        }

        private void ExcuteSendCommand()
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<String>("ViewModel通知View弹出消息框", "ViewAlert"); //注意：token参数一致
        }


        private RelayCommand showWindowCmd;

        public RelayCommand ShowWindowCmd
        {
            get
            {
                if ((showWindowCmd == null))
                    showWindowCmd = new RelayCommand(() => ExecuteShowWindow());
                return showWindowCmd;
            }
        }

        private void ExecuteShowWindow()
        {
            new MessageSubscriberView().Show();
        }


        private RelayCommand messengerWithDispatcherHelperCmd;

        public RelayCommand MessengerWithDispatcherHelperCmd
        {
            get
            {
                if (messengerWithDispatcherHelperCmd == null)
                    messengerWithDispatcherHelperCmd = new RelayCommand(() => ExecuteMessengerWithDispatcherHelper());
                return messengerWithDispatcherHelperCmd;
            }
        }

        private void ExecuteMessengerWithDispatcherHelper()
        {
            new MessengerWithDispatcherHelperView().Show();
        }

        private RelayCommand showMessengerSourceCmd;

        public RelayCommand ShowMessengerSourceCmd
        {
            get
            {
                if (showMessengerSourceCmd == null)
                    showMessengerSourceCmd = new RelayCommand(() => ExecuteShowMessengerSource());
                return showMessengerSourceCmd;
            }
        }

        private void ExecuteShowMessengerSource()
        {
            new MessengerSourceView().Show();
        }


        private RelayCommand showMessengerSinkCmd;

        public RelayCommand ShowMessengerSinkCmd
        {
            get
            {
                if (showMessengerSinkCmd == null)
                    showMessengerSinkCmd = new RelayCommand(() => ExecuteShowMessengerSink());
                return showMessengerSinkCmd;
            }
        }

        private void ExecuteShowMessengerSink()
        {
            new MessengerSinkView().Show();
        }

        #endregion
    }
}
