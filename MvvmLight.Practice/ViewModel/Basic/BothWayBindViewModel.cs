using GalaSoft.MvvmLight;
using MvvmLight.Practice.Model;
using MvvmLight.Practice.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight.Practice.ViewModel.Basic
{
    public class BothWayBindViewModel : ViewModelBase
    {
        public BothWayBindViewModel()
        {
            UserInfo = new UserInfoModel();
        }

        #region 属性

        private UserInfoModel userInfo;
        /// <summary>
        /// 用户信息
        /// </summary>
        public UserInfoModel UserInfo
        {
            get { return userInfo; }
            set
            {
                userInfo = value;
                RaisePropertyChanged(() => UserInfo);
            }
        }

        #endregion

        #region 命令
        #endregion
    }
}
