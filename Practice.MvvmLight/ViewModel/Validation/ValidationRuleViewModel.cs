﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Practice.MvvmLight.ViewModel.Validation
{
    public class ValidationRuleViewModel : ViewModelBase
    {
        public ValidationRuleViewModel()
        {

        }

        #region 属性

        private String userName;
        /// <summary>
        /// 用户名
        /// </summary>
        public String UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName); }
        }



        private String userEmail;
        /// <summary>
        /// 用户邮件
        /// </summary>
        public String UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; RaisePropertyChanged(() => UserName); }
        }

        #endregion
    }
}
