﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MvvmLight.Practice.Model;
using MvvmLight.Practice.Model.Basic;

namespace MvvmLight.Practice.ViewModel.Bind
{
    public class DataContextBindViewModel : ViewModelBase
    {
        private UserInfoModel userInfo;

        public UserInfoModel UserInfo
        {
            get { return userInfo; }
            set
            {
                userInfo = value;
                RaisePropertyChanged(() => UserInfo);
            }
        }

        public DataContextBindViewModel()
        {
            UserInfo = new UserInfoModel
            {
                UserName = "Kimcatt",
                UserSex = 0,
                UserAdd = "上海，中国",
                UserPhone = 18388888888
            };
        }

    }
}
