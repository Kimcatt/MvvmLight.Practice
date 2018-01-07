using GalaSoft.MvvmLight;
using Practice.MvvmLight.Model;
using Practice.MvvmLight.Model.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MvvmLight.ViewModel.Basic
{
    public class WelcomeViewModel : ViewModelBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public WelcomeViewModel()
        {
            Welcome = new WelcomeModel() { Introduction = "Hello MvvmLight！" };
        }
        #region 属性

        private WelcomeModel welcome;
        /// <summary>
        /// 欢迎词属性
        /// </summary>
        public WelcomeModel Welcome
        {
            get { return welcome; }
            set { welcome = value; RaisePropertyChanged(() => Welcome); }
        }
        #endregion
    }
}
