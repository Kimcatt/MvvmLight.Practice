using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Practice.MvvmLight.Model.Sample;
using GalaSoft.MvvmLight.Command;

namespace Practice.MvvmLight.ViewModel.Sample
{
    public class CheckBoxGroupViewModel : ViewModelBase
    {
        public CheckBoxGroupViewModel()
        {
            InitCompCheck();
        }
        private void InitCompCheck()
        {
            CheckButtons = new List<CompBottonModel>()
            {
                 new CompBottonModel(){ Content="苹果", IsCheck = false },
                 new CompBottonModel(){ Content="香蕉", IsCheck = false },
                 new CompBottonModel(){ Content="梨", IsCheck = false },
                 new CompBottonModel(){ Content="樱桃", IsCheck = false }
            };
        }

        private List<CompBottonModel> checkButtons;
        /// <summary>
        /// 组合复选框
        /// </summary>
        public List<CompBottonModel> CheckButtons
        {
            get { return checkButtons; }
            set
            {
                checkButtons = value; RaisePropertyChanged(() => CheckButtons);
            }
        }

        

        private String checkInfo;
        /// <summary>
        /// 确认框选中信息
        /// </summary>
        public String CheckInfo
        {
            get { return checkInfo; }
            set { checkInfo = value; RaisePropertyChanged(() => CheckInfo); }
        }

        private RelayCommand checkCommand;
        /// <summary>
        /// 复选框命令
        /// </summary>
        public RelayCommand CheckCommand
        {
            get
            {
                if (checkCommand == null)
                    checkCommand = new RelayCommand(() => ExcuteCheckCommand());
                return checkCommand;

            }
            set { checkCommand = value; }
        }
        private void ExcuteCheckCommand()
        {
            if (CheckButtons != null && CheckButtons.Count > 0)
            {
                CheckInfo = string.Join(",", CheckButtons.Where(p => p.IsCheck).Select(p => p.Content));
            }
        }
    }
}
