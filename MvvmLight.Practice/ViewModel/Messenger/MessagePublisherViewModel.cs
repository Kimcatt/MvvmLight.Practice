using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MvvmLight.Practice.ViewModel.Messenger
{
    public class MessagePublisherViewModel : ViewModelBase
    {
        public MessagePublisherViewModel()
        {
            
        }

        #region 属性
        private String publishInfo;
        /// <summary>
        /// 发送消息
        /// </summary>
        public String PublishInfo
        {
            get { return publishInfo; }
            set { publishInfo = value; RaisePropertyChanged(() => PublishInfo); }
        }

        #endregion

        #region 命令

        private RelayCommand publishCommand;
        /// <summary>
        /// 发送命令
        /// </summary>
        public RelayCommand PublishCommand
        {
            get
            {
                if (publishCommand == null)
                    publishCommand = new RelayCommand(() => ExcutePublishCommand());
                return publishCommand;

            }
            set { publishCommand = value; }
        }

        private void ExcutePublishCommand()
        {
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<String>(PublishInfo, "Message");
        }

        #endregion
    }
}
