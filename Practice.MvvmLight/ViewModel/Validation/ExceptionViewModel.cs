using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MvvmLight.ViewModel.Validation
{
    public class ExceptionViewModel : ViewModelBase
    {

        public ExceptionViewModel()
        {

        }

        private String userNameEx;
        /// <summary>
        /// 用户名称（不为空）
        /// </summary>
        public string UserNameEx
        {
            get
            {
                return userNameEx;
            }
            set
            {
                userNameEx = value;
                RaisePropertyChanged(() => UserNameEx);
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("该字段不能为空！");
                }
            }
        }
    }
}
