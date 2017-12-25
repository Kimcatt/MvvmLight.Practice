using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MvvmLight.Practice.ViewModel.Sample
{
    public class RadioButtonViewModel : GalaSoft.MvvmLight.ViewModelBase
    {
        public RadioButtonViewModel()
        {
            InitSingleRadio();
        }

        private void InitSingleRadio()
        {
            SingleRadio = "喜欢吃苹果？";
            IsSingleRadioCheck = false;
        }

        private Boolean isSingleRadioCheck;
        /// <summary>
        /// 单选框是否选中
        /// </summary>
        public Boolean IsSingleRadioCheck
        {
            get { return isSingleRadioCheck; }
            set { isSingleRadioCheck = value; RaisePropertyChanged(() => IsSingleRadioCheck); }
        }

        private String singleRadio;
        /// <summary>
        /// 单选框相关
        /// </summary>
        public String SingleRadio
        {
            get { return singleRadio; }
            set { singleRadio = value; RaisePropertyChanged(() => SingleRadio); }
        }
    }
}
