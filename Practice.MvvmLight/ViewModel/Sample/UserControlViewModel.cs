using Practice.MvvmLight.ViewModel.UserControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class UserControlViewModel : ViewModelBase
    {
        public UserControlViewModel()
        {
            InitUCList();
        }

        private ObservableCollection<FruitInfoViewModel> fiList;
        /// <summary>
        /// 用户控件模板列表
        /// </summary>
        public ObservableCollection<FruitInfoViewModel> FiList
        {
            get { return fiList; }
            set { fiList = value; RaisePropertyChanged(() => FiList); }
        }

        private void InitUCList()
        {
            FiList = new ObservableCollection<FruitInfoViewModel>()
            {
                new FruitInfoViewModel{ Img = "/Practice.MvvmLight;component/Resources/Images/1.jpg", Info= "樱桃"},
                new FruitInfoViewModel{ Img = "/Practice.MvvmLight;component/Resources/Images/2.jpg", Info = "葡萄"}
            };
        }
    }
}
