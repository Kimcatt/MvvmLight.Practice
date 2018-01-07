using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Collections;
using System.Collections.ObjectModel;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class ListBoxViewModel : ViewModelBase
    {
        public ListBoxViewModel()
        {
            InitListBoxList();
        }

        private void InitListBoxList()
        {
            ListBoxData = new ObservableCollection<dynamic>(){
              new { Img="/Practice.MvvmLight;component/Resources/Images/1.jpg", Info="樱桃" },
              new { Img="/Practice.MvvmLight;component/Resources/Images/2.jpg", Info="葡萄" },
              new { Img="/Practice.MvvmLight;component/Resources/Images/3.jpg", Info="苹果" },
              new { Img="/Practice.MvvmLight;component/Resources/Images/4.jpg", Info="猕猴桃" },
              new { Img="/Practice.MvvmLight;component/Resources/Images/5.jpg", Info="柠檬" },
           };
        }
        #region ListBox 模板

        private IEnumerable listBoxData;
        /// <summary>
        /// LisBox数据模板
        /// </summary>
        public IEnumerable ListBoxData
        {
            get { return listBoxData; }
            set { listBoxData = value; RaisePropertyChanged(() => ListBoxData); }
        }

        #endregion
    }
}
