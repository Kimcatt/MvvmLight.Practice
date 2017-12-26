using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MvvmLight.Practice.Model.Messenger;

namespace MvvmLight.Practice.ViewModel.Messenger
{
    public class MessengerSinkViewModel : ViewModelBase
    {
        public string MessengerTag { get; } = "MyMessenger";

        private GalaSoft.MvvmLight.Messaging.Messenger messenger;
        public MessengerSinkViewModel()
        {
            ////构造函数    
            //myMessenger = new GalaSoft.MvvmLight.Messaging.Messenger();

            ////注入一个Key为MyMessenger的Messenger对象
            //SimpleIoc.Default.Register(() => myMessenger, "MyMessenger"); 
            Init();
            
            //注册myMessenger,开启监听
            messenger.Register<NotificationMessage>(this, message =>  
            {
                // 判断来源来接受消息
                MsgInfo = message.Notification;
            });

            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<PropertyChangedMessage<String>>(this, message =>
            {
                if (message.PropertyName == UserPropertyModel.PropertyName) //接受特定属性值相关信道的消息
                {
                    PropertyChangedInfo = (message.OldValue + " --> " + message.NewValue);//输出旧值到新值的内容
                }
            });
        }

        private void Init()
        {
            try
            {
                messenger = SimpleIoc.Default.GetInstance<GalaSoft.MvvmLight.Messaging.Messenger>(MessengerTag);
            }
            catch (Exception ex)
            {
                //构造函数    
                messenger = new GalaSoft.MvvmLight.Messaging.Messenger();

                //注入一个Key为MyMessenger的Messenger对象
                SimpleIoc.Default.Register(() => messenger, MessengerTag);
            }
        }

        #region 全局属性
        private String msgInfo;
        private String propertyChangedInfo;


        public string MsgInfo
        {
            get
            {
                return msgInfo;
            }
            set
            {
                msgInfo = value;
                RaisePropertyChanged(() => MsgInfo);
            }
        }

        public string PropertyChangedInfo
        {
            get
            {
                return propertyChangedInfo;
            }

            set
            {
                propertyChangedInfo = value;
                RaisePropertyChanged(() => PropertyChangedInfo);
            }
        }

        #endregion
    }

    

}
