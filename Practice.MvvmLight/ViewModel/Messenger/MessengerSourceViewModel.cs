using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using Practice.MvvmLight.Model.Messenger;

namespace Practice.MvvmLight.ViewModel.Messenger
{
    class MessengerSourceViewModel : ViewModelBase
    {
        public string MessengerTag { get; } = "MyMessenger";

        public MessengerSourceViewModel()
        {
            userPropertyModel = new UserPropertyModel();
        }

        #region 全局命令
        private RelayCommand sendMsg;
        /// <summary>
        /// 发送消息
        /// </summary>
        public RelayCommand SendMsg
        {
            get
            {
                if (sendMsg == null) sendMsg = new RelayCommand(() => ExcuteSendMsh());
                return sendMsg;
            }
            set
            {
                sendMsg = value;
            }
        }
        #endregion

        #region 附属方法
        private void ExcuteSendMsh()
        {
            NotificationMessage nm = new NotificationMessage(this, String.Format("发送消息：{0}", DateTime.Now));
            //获取已存在的Messenger实例
            GalaSoft.MvvmLight.Messaging.Messenger myMessenger = SimpleIoc.Default.GetInstance<GalaSoft.MvvmLight.Messaging.Messenger>(MessengerTag);
            //消息发送
            myMessenger.Send<NotificationMessage>(nm);
        }
        #endregion

        private UserPropertyModel userPropertyModel;

        public UserPropertyModel UserPropertyModel
        {
            get { return userPropertyModel; }
            set { userPropertyModel = value; RaisePropertyChanged(() => UserPropertyModel); }
        }

    }

    
}
