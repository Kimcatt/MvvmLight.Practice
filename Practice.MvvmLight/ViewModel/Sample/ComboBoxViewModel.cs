using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Practice.MvvmLight.Model.Sample;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class ComboBoxViewModel : ViewModelBase
    {
        public ComboBoxViewModel()
        {
            ComboBoxList = new List<ComplexInfoModel>
            {
                new ComplexInfoModel {Key = "0", Text = "苹果" },
                new ComplexInfoModel {Key = "1", Text = "香蕉" },
                new ComplexInfoModel {Key = "2", Text = "梨" },
                new ComplexInfoModel { Key = "3", Text = "樱桃"},
            };
        }

        #region 下拉框相关
        private ComplexInfoModel comboBoxItem;
        /// <summary>
        /// 下拉框选中信息
        /// </summary>
        public ComplexInfoModel ComboBoxItem
        {
            get { return comboBoxItem; }
            set { comboBoxItem = value; RaisePropertyChanged(() => ComboBoxItem); }
        }


        private List<ComplexInfoModel> comboBoxList;
        /// <summary>
        /// 下拉框列表
        /// </summary>
        public List<ComplexInfoModel> ComboBoxList
        {
            get { return comboBoxList; }
            set { comboBoxList = value; RaisePropertyChanged(() => ComboBoxList); }
        }
        #endregion

    }
}
